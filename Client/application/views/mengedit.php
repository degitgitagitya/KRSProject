<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 12:37 PM
 */

?>

<div class="container">
	<form action="<?php echo base_url('index.php/home/editJadwal') ?>" method="post">
		<input type="text" name="id" value="<?php echo $tampungan->id?>" hidden>
		<div class="row mt-3">
			<div class="col-6 text-right">
				Hari
			</div>
			<div class="col-6">
				<select name="hari" id="hari">
					<option <?php if ($tampungan->hari == "Senin"){?> selected <?php }?> value="Senin">Senin</option>
					<option <?php if ($tampungan->hari == "Selasa"){?> selected <?php }?> value="Selasa">Selasa</option>
					<option <?php if ($tampungan->hari == "Rabu"){?> selected <?php }?>value="Rabu">Rabu</option>
					<option <?php if ($tampungan->hari == "Kamis"){?> selected <?php }?>value="Kamis">Kamis</option>
					<option <?php if ($tampungan->hari == "Jum'at"){?> selected <?php }?> value="Jum'at">Jum'at</option>
				</select>
			</div>
		</div>
		<div class="row mt-3">
			<div class="col-6 text-right">
				Waktu Perkuliahan
			</div>
			<div class="col-6">
				<select name="waktu" id="waktu">
					<option <?php if ($tampungan->waktu == "07.00-08.40"){?> selected <?php }?> value="07.00-08.40">07.00-08.40</option>
					<option <?php if ($tampungan->waktu == "07.00-09.30"){?> selected <?php }?> value="07.00-09.30">07.00-09.30</option>
					<option <?php if ($tampungan->waktu == "09.30-12.00"){?> selected <?php }?> value="09.30-12.00">09.30-12.00</option>
					<option <?php if ($tampungan->waktu == "09.30-11.10"){?> selected <?php }?> value="09.30-11.10">09.30-11.10</option>
					<option <?php if ($tampungan->waktu == "13.00-15.30"){?> selected <?php }?> value="13.00-15.30">13.00-15.30</option>
					<option <?php if ($tampungan->waktu == "13.00-14.40"){?> selected <?php }?> value="13.00-14.40">13.00-14.40</option>
					<option <?php if ($tampungan->waktu == "15.30-17.10"){?> selected <?php }?> value="15.30-17.10">15.30-17.10</option>
					<option <?php if ($tampungan->waktu == "15.30-18.00"){?> selected <?php }?> value="15.30-18.00">15.30-18.00</option>
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
						<option <?php if ($key->kode_kelas == $tampungan->kode_kelas){?> selected <?php }?> value="<?php echo $key->id?>">
							<?php echo $key->kode_kelas?>, <?php echo $key->tempat?>
						</option>
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
						<option  <?php if ($key->nama_matkul == $tampungan->nama_matkul){?> selected <?php }?> value="<?php echo $key->id?>">
							<?php echo $key->nama_matkul?>
						</option>
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
						<option  <?php if ($key->nama== $tampungan->nama){?> selected <?php }?> value="<?php echo $key->id?>">
							<?php echo $key->nama?>
						</option>
					<?php } ?>
				</select>
			</div>
		</div>
		<div class="row mt-3 justify-content-center">
			<div class="col-4 text-center">
				<input type="submit" class="btn btn-info" value="Edit">
			</div>
		</div>
	</form>
</div>
