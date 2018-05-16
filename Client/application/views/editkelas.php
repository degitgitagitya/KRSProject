<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 6:45 PM
 */
?>

<div class="container">
	<form action="<?php echo base_url('index.php/kelas_c/editKelas') ?>" method="post">
		<input type="text" hidden value="<?php echo $kelas->id?>" name="id">
		<div class="row mt-3">
			<div class="col-6 text-right">
				NIP
			</div>
			<div class="col-6">
				<input type="text" name="kode" value="<?php echo $kelas->kode_kelas?>">
			</div>
		</div>
		<div class="row mt-3">
			<div class="col-6 text-right">
				Nama
			</div>
			<div class="col-6">
				<input type="text" name="tempat" value="<?php echo $kelas->tempat?>">
			</div>
		</div>
		<div class="row mt-3 justify-content-center">
			<div class="col-4 text-center">
				<input type="submit" class="btn btn-info" value="Edit">
			</div>
		</div>
	</form>
</div>
