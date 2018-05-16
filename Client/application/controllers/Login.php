<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Login extends CI_Controller {

	function __construct($foo = null)
	{
		parent::__construct();
		$this->API = "http://localhost:50768/api";
		$this->load->library('curl');
		$this->options = array(
			CURLOPT_RETURNTRANSFER => true,   // return web page
			CURLOPT_HEADER         => false,  // don't return headers
			CURLOPT_FOLLOWLOCATION => true,   // follow redirects
			CURLOPT_MAXREDIRS      => 10,     // stop after 10 redirects
			CURLOPT_ENCODING       => "",     // handle compressed
			CURLOPT_USERAGENT      => "test", // name of client
			CURLOPT_AUTOREFERER    => true,   // set referrer on redirect
			CURLOPT_CONNECTTIMEOUT => 120,    // time-out on connect
			CURLOPT_TIMEOUT        => 120,    // time-out on response
		);
	}

	public function index()
	{
		$this->load->view('header');
		$this->load->view('login');
		$this->load->view('footer');
	}

	public function loginAdmin()
	{
		$login = $this->input->post('username');
		$password = $this->input->post('password');
		$url = 'http://localhost:50768/api/adminAuth/Token';
		$ch = curl_init();
		curl_setopt($ch, CURLOPT_URL,$url);
		curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "POST");
		$headers = array(
			'Content-Type:application/json',
			'Authorization: Basic '. base64_encode($login.":".$password) // <---
		);
		curl_setopt($ch, CURLOPT_HTTPHEADER, $headers);
		curl_setopt($ch, CURLOPT_POSTFIELDS, base64_encode($login.":".$password));
		curl_setopt_array($ch, $this->options);
		$result = curl_exec($ch);
		curl_close($ch);

		$data_session = array(
			'token' => $result
		);

		$check = substr($result,1,-1);

		$this->session->set_userdata($data_session);
		if ($check == "Wrong Request")
		{
			redirect(base_url('index.php/login/errorHandling'));
		}
		else
		{
			redirect(base_url('index.php/home'));
		}
	}

	public function errorHandling()
	{
		$this->load->view('header');
		$this->load->view('error');
		$this->load->view('footer');
	}

	public function logout()
	{
		$this->session->sess_destroy();
		$this->index();
	}
}
