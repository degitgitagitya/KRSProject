<?php
defined('BASEPATH') OR exit('No direct script access allowed');
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 1:57 AM
 */

class Home extends CI_Controller {

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
		$this->load->view('navbar');
		$data['matkul'] = $this->daftarJadwal();
		$this->load->view('home',$data);
		$this->load->view('footer');
	}

	public function daftarJadwal()
	{
		return $this->daftarJadwal->getAllJadwal();
	}

	public function deleteJadwal($id)
	{
		$this->jadwal->delete($id);
		$this->index();
	}
}
