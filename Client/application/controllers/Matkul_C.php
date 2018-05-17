<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/17/2018
 * Time: 6:18 AM
 */

class Matkul_C extends CI_Controller{

	function index()
	{
		$this->load->view('header');
		$this->load->view('navbar');
		$this->load->view('start');
		$data['matkul'] = $this->matakuliah->getAllMatkul();
		$this->load->view('matkul_v',$data);
		$this->load->view('footer');
	}

	function add()
	{
		$this->load->view('header');
		$this->load->view('navbar');
		$this->load->view('tambahkanmatkul');
		$this->load->view('footer');
	}

	function addMatkul()
	{
		$kode = $this->input->post('kode');
		$nama = $this->input->post('nama');
		$sks = $this->input->post('sks');

		$this->matakuliah->add($kode,$nama,$sks);
		$this->index();
	}

	function delete($id)
	{
		$this->matakuliah->delete($id);
		$this->index();
	}

	function edit($id)
	{
		$data['matkul'] = $this->matakuliah->getBy($id);
		$this->load->view('header');
		$this->load->view('navbar');
		$this->load->view('editmatkul',$data);
		$this->load->view('footer');
	}

	function editMatkul()
	{
		$id = $this->input->post('id');
		$kode = $this->input->post('kode');
		$nama = $this->input->post('nama');
		$sks = $this->input->post('sks');;

		$this->matakuliah->update($id, $kode, $nama, $sks);
		$this->index();
	}
}
