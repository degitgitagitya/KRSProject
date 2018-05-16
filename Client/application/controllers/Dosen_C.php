<?php
defined('BASEPATH') OR exit('No direct script access allowed');
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 1:53 PM
 */

class Dosen_C extends CI_Controller{

	function index()
	{
		$this->load->view('header');
		$this->load->view('navbar');
		$this->load->view('start');
		$data['dosen'] = $this->dosen->getAllDosen();
		$this->load->view('doesn_v',$data);
		$this->load->view('footer');
	}

	function add()
	{
		$this->load->view('header');
		$this->load->view('navbar');
		$this->load->view('tambahkandosen');
		$this->load->view('footer');
	}

	function addDosen()
	{
		$nip = $this->input->post('nip');
		$nama = $this->input->post('nama');
		$kode = $this->input->post('kode');

		$this->dosen->add($nip,$nama,$kode);
		$this->index();
	}

	function delete($id)
	{
		$this->dosen->delete($id);
		$this->index();
	}

	function edit($id)
	{
		$data['dosen'] = $this->dosen->getBy($id);
		$this->load->view('header');
		$this->load->view('navbar');
		$this->load->view('editdosen',$data);
		$this->load->view('footer');
	}

	function editDosen()
	{
		$id = $this->input->post('id');
		$nip = $this->input->post('nip');
		$nama = $this->input->post('nama');
		$kode = $this->input->post('kode');

		$this->dosen->update($id, $nip, $nama, $kode);
		$this->index();
	}
}
