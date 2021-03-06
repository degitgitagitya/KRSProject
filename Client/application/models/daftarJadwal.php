<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 2:09 AM
 */

class daftarJadwal extends CI_Model{

	function __construct($foo = null)
	{
		parent::__construct();
		$this->API = "http://localhost:50768/api/DaftarJadwal";
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


	function getAllJadwal()
	{
		$curl = curl_init($this->API."/GetAll");
		curl_setopt($curl, CURLOPT_HTTPHEADER, array(
				'Content-Type: application/json',
				'Authorization: Bearer '. $this->session->userdata("token")
			)
		);
		curl_setopt_array($curl, $this->options);

		return json_decode(curl_exec($curl));
	}

	function getBy($id)
	{
		$curl = curl_init($this->API."/GetBy/".$id);
		curl_setopt($curl, CURLOPT_HTTPHEADER, array(
				'Content-Type: application/json',
				'Authorization: Bearer '. $this->session->userdata("token")
			)
		);
		curl_setopt_array($curl, $this->options);

		return json_decode(curl_exec($curl));
	}
}
