<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 1:51 AM
 */

$counter = 1;
?>


<div class="container">


	<div class="row mt-3">
		<div class="col-2">
			<a href="" class="btn btn-info">Tambahkan Jadwal</a>
		</div>
	</div>


	<table class="table table-hover mt-3">
		<thead>
		<tr>
			<th scope="col">No</th>
			<th scope="col">Hari</th>
			<th scope="col">Waktu</th>
			<th scope="col">Kode Kelas</th>
			<th scope="col">Nama Mata Kuliah</th>
			<th scope="col">Nama Dosen</th>
			<th scope="col">Opsi</th>
		</tr>
		</thead>
		<tbody>
		<?php foreach ($matkul as $key){?>
		<tr class="table-success">
			<th scope="row"><?php echo $counter++;?></th>
			<td><?php echo $key->hari;?></td>
			<td><?php echo $key->waktu;?></td>
			<td><?php echo $key->kode_kelas;?></td>
			<td><?php echo $key->nama_matkul;?></td>
			<td><?php echo $key->nama;?></td>
			<td>

				<a href="<?php echo base_url() ?>index.php/home/deletejadwal/<?php echo $key->id?>" class="btn btn-warning">Hapus</a>
				<a href="<?php echo base_url() ?>index.php/admin/editNews/<?php echo $key->id?>" class="btn btn-danger">Edit</a>

			</td>
		</tr>
		<?php }?>
		</tbody>
	</table>
</div>
