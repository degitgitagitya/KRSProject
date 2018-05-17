<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/17/2018
 * Time: 6:17 AM
 */
?>

<div class="container">
	<form action="<?php echo base_url('index.php/matkul_c/editMatkul') ?>" method="post">
		<input type="text" hidden value="<?php echo $matkul->id?>" name="id">
		<div class="row mt-3">
			<div class="col-6 text-right">
				Kode Mata Kuliah
			</div>
			<div class="col-6">
				<input type="text" name="kode" value="<?php echo $matkul->kd_matkul?>">
			</div>
		</div>
		<div class="row mt-3">
			<div class="col-6 text-right">
				Nama Mata Kuliah
			</div>
			<div class="col-6">
				<input type="text" name="nama" value="<?php echo $matkul->nama_matkul?>">
			</div>
		</div>
		<div class="row mt-3">
			<div class="col-6 text-right">
				SKS
			</div>
			<div class="col-6">
				<input type="text" name="sks" value="<?php echo $matkul->sks?>">
			</div>
		</div>
		<div class="row mt-3 justify-content-center">
			<div class="col-4 text-center">
				<input type="submit" class="btn btn-info" value="Edit">
			</div>
		</div>
	</form>
</div>
