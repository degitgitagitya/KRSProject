<?php
defined('BASEPATH') OR exit('No direct script access allowed');
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 1:53 PM
 */

class Kelas_C extends CI_Controller{

	function index()
	{
		$this->load->view('header');
		$this->load->view('navbar');
		$this->load->view('start');
		$data['kelas'] = $this->kelas->getAllKelas();
		$this->load->view('kelas_v',$data);
		$this->load->view('footer');
	}

	function add()
	{
		$this->load->view('header');
		$this->load->view('navbar');
		$this->load->view('tambahkankelas');
		$this->load->view('footer');
	}

	function addKelas()
	{
		$kode = $this->input->post('kode');
		$kelas = $this->input->post('tempat');

		$this->kelas->add($kode,$kelas);
		$this->index();
	}

	function delete($id)
	{
		$this->kelas->delete($id);
		$this->index();
	}

	function edit($id)
	{
		$data['kelas'] = $this->kelas->getBy($id);
		$this->load->view('header');
		$this->load->view('navbar');
		$this->load->view('editkelas',$data);
		$this->load->view('footer');
	}

	function editKelas()
	{
		$id = $this->input->post('id');
		$kode = $this->input->post('kode');
		$tempat = $this->input->post('tempat');

		$this->kelas->update($id, $kode, $tempat);
		$this->index();
	}
}
