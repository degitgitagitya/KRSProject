<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/17/2018
 * Time: 6:17 AM
 */
?>

<div class="container">
	<form action="<?php echo base_url('index.php/matkul_c/addMatkul') ?>" method="post">
		<div class="row mt-3">
			<div class="col-6 text-right">
				Kode Mata Kuliah
			</div>
			<div class="col-6">
				<input type="text" name="kode">
			</div>
		</div>
		<div class="row mt-3">
			<div class="col-6 text-right">
				Nama Mata Kuliah
			</div>
			<div class="col-6">
				<input type="text" name="nama">
			</div>
		</div>
		<div class="row mt-3">
			<div class="col-6 text-right">
				SKS
			</div>
			<div class="col-6">
				<input type="text" name="sks">
			</div>
		</div>
		<div class="row mt-3 justify-content-center">
			<div class="col-4 text-center">
				<input type="submit" class="btn btn-info" value="Tambahkan">
			</div>
		</div>
	</form>
</div>
