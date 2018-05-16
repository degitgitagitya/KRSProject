<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 6:44 PM
 */
?>

<div class="container">
	<form action="<?php echo base_url('index.php/kelas_c/addKelas') ?>" method="post">
		<div class="row mt-3">
			<div class="col-6 text-right">
				Kode Kelas
			</div>
			<div class="col-6">
				<input type="text" name="kode">
			</div>
		</div>
		<div class="row mt-3">
			<div class="col-6 text-right">
				Tempat
			</div>
			<div class="col-6">
				<input type="text" name="tempat">
			</div>
		</div>
		<div class="row mt-3 justify-content-center">
			<div class="col-4 text-center">
				<input type="submit" class="btn btn-info" value="Tambahkan">
			</div>
		</div>
	</form>
</div>

