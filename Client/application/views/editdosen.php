<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 2:18 PM
 */

?>

<div class="container">
	<form action="<?php echo base_url('index.php/dosen_c/editDosen') ?>" method="post">
		<input type="text" hidden value="<?php echo $dosen->id?>" name="id">
		<div class="row mt-3">
			<div class="col-6 text-right">
				NIP
			</div>
			<div class="col-6">
				<input type="text" name="nip" value="<?php echo $dosen->nip?>">
			</div>
		</div>
		<div class="row mt-3">
			<div class="col-6 text-right">
				Nama
			</div>
			<div class="col-6">
				<input type="text" name="nama" value="<?php echo $dosen->nama?>">
			</div>
		</div>
		<div class="row mt-3">
			<div class="col-6 text-right">
				Kode
			</div>
			<div class="col-6">
				<input type="text" name="kode" value="<?php echo $dosen->kode_dosen?>">
			</div>
		</div>
		<div class="row mt-3 justify-content-center">
			<div class="col-4 text-center">
				<input type="submit" class="btn btn-info" value="Edit">
			</div>
		</div>
	</form>
</div>
