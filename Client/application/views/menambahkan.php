<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 11:05 AM
 */

?>

<div class="container">
	<form action="<?php echo base_url('index.php/home/addJadwal') ?>" method="post">
		<div class="row mt-3">
			<div class="col-6 text-right">
				Hari
			</div>
			<div class="col-6">
				<select name="hari" id="hari">
					<option value="Senin">Senin</option>
					<option value="Selasa">Selasa</option>
					<option value="Rabu">Rabu</option>
					<option value="Kamis">Kamis</option>
					<option value="Jum'at">Jum'at</option>
				</select>
			</div>
		</div>
		<div class="row mt-3">
			<div class="col-6 text-right">
				Waktu Perkuliahan
			</div>
			<div class="col-6">
				<select name="waktu" id="waktu">
					<option value="07.00-08.40">07.00-08.40</option>
					<option value="07.00-09.30">07.00-09.30</option>
					<option value="09.30-12.00">09.30-12.00</option>
					<option value="09.30-11.10">09.30-11.10</option>
					<option value="13.00-15.30">13.00-15.30</option>
					<option value="13.00-14.40">13.00-14.40</option>
					<option value="15.30-17.10">15.30-17.10</option>
					<option value="15.30-18.00">15.30-18.00</option>
				</select>
			</div>
		</div>
		<div class="row mt-3">
			<div class="col-6 text-right">
				Tempat Perkuliahan
			</div>
			<div class="col-6">
				<select name="kelas" id="kelas">
					<?php foreach ($kelas as $key){ ?>
					<option value="<?php echo $key->id?>"><?php echo $key->kode_kelas?>, <?php echo $key->tempat?></option>
					<?php } ?>
				</select>
			</div>
		</div>
		<div class="row mt-3">
			<div class="col-6 text-right">
				Nama Mata Kuliah
			</div>
			<div class="col-6">
				<select name="matkul" id="matkul">
					<?php foreach ($matkul as $key){ ?>
						<option value="<?php echo $key->id?>"><?php echo $key->nama_matkul?></option>
					<?php } ?>
				</select>
			</div>
		</div>
		<div class="row mt-3">
			<div class="col-6 text-right">
				Nama Dosen
			</div>
			<div class="col-6">
				<select name="dosen" id="dosen">
					<?php foreach ($dosen as $key){ ?>
						<option value="<?php echo $key->id?>"><?php echo $key->nama?></option>
					<?php } ?>
				</select>
			</div>
		</div>
		<div class="row mt-3 justify-content-center">
			<div class="col-4 text-center">
				<input type="submit" class="btn btn-info" value="Tambahkan">
			</div>
		</div>
	</form>
</div>
