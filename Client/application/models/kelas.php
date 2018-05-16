<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 11:00 AM
 */

class kelas extends CI_Model{

	function __construct($foo = null)
	{
		parent::__construct();
		$this->API = "http://localhost:50768/api/Kelas";
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

	function getAllKelas()
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

	public function delete($id)
	{
		$url = $this->API."/Delete/".$id;
		$ch = curl_init();
		curl_setopt($ch, CURLOPT_HTTPHEADER, array(
				'Content-Type: application/json',
				'Authorization: Bearer '. $this->session->userdata("token")
			)
		);
		curl_setopt($ch, CURLOPT_URL, $url);
		curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "DELETE");
		$result = curl_exec($ch);
		$httpCode = curl_getinfo($ch, CURLINFO_HTTP_CODE);
		curl_close($ch);
	}

	public function add($kode, $tempat)
	{
		$data['kode_kelas'] = $kode;
		$data['tempat'] = $tempat;

		$insert = json_encode($data);

		$curl = curl_init($this->API."/Insert");
		curl_setopt($curl, CURLOPT_CUSTOMREQUEST, "POST");

		curl_setopt($curl, CURLOPT_HTTPHEADER, array(
				'Content-Type: application/json',
				'Content-Length: ' . strlen($insert),
				'Authorization: Bearer '. $this->session->userdata("token")
			)
		);

		curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);
		curl_setopt($curl, CURLOPT_POSTFIELDS, $insert);

		$result = curl_exec($curl);
		curl_close($curl);

		$dt = $result;
		$data['hasil'] =  json_decode($dt);
	}

	public function update($id, $kode, $tempat)
	{
		$data['id'] = $id;
		$data['kode_kelas'] = $kode;
		$data['tempat'] = $tempat;

		$insert = json_encode($data);

		$curl = curl_init($this->API."/Update");
		curl_setopt($curl, CURLOPT_CUSTOMREQUEST, "PUT");

		curl_setopt($curl, CURLOPT_HTTPHEADER, array(
				'Content-Type: application/json',
				'Content-Length: ' . strlen($insert),
				'Authorization: Bearer '. $this->session->userdata("token")
			)
		);

		curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);
		curl_setopt($curl, CURLOPT_POSTFIELDS, $insert);

		$result = curl_exec($curl);
		curl_close($curl);

		$dt = $result;
		$data['hasil'] =  json_decode($dt);
	}
}
