<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 1:38 PM
 */
?>

<hr class="container">
	<h1 class="text-center">Daftar Tabel</h1>
<hr class="container">

<div class="container my-3">
	<div class="row justify-content-center">
		<div class="col-3 text-center">
			<a href="<?php echo base_url('index.php/dosen_c')?>" class="btn btn-success">Dosen</a>
		</div>
		<div class="col-3 text-center">
			<a href="<?php echo base_url('index.php/home/jadwal')?>" class="btn btn-success">Jadwal</a>
		</div>
		<div class="col-3 text-center">
			<a href="<?php echo base_url('index.php/kelas_c')?>" class="btn btn-success">Kelas</a>
		</div>
		<div class="col-3 text-center">
			<a href="<?php echo base_url('index.php/matkul_c')?>" class="btn btn-success">Mata Kuliah</a>
		</div>
	</div>
</div>
