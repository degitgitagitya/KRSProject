<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/17/2018
 * Time: 6:17 AM
 */

$counter = 1;

if (!isset($matkul))
{
	redirect(base_url());
}
?>

<hr class="container">
<h1 class="text-center">Daftar Kelas</h1>
<hr class="container">

<div class="container">


	<div class="row mt-3">
		<div class="col-2">
			<a href="<?php echo base_url('index.php/matkul_c/add')?>" class="btn btn-info">Tambahkan Mata Kuliah</a>
		</div>
	</div>


	<table class="table table-hover mt-3">
		<thead>
		<tr>
			<th scope="col">No</th>
			<th scope="col">Kode Mata Kuliah</th>
			<th scope="col">Nama Mata Kuliah</th>
			<th scope="col">SKS</th>
			<th scope="col">Opsi</th>
		</tr>
		</thead>
		<tbody>
		<?php foreach ($matkul as $key){?>
			<tr class="table-success">
				<th scope="row"><?php echo $counter++;?></th>
				<td><?php echo $key->kd_matkul;?></td>
				<td><?php echo $key->nama_matkul;?></td>
				<td><?php echo $key->sks;?></td>
				<td>
					<a href="<?php echo base_url() ?>index.php/matkul_c/delete/<?php echo $key->id?>" class="btn btn-warning">Hapus</a>
					<a href="<?php echo base_url() ?>index.php/matkul_c/edit/<?php echo $key->id?>" class="btn btn-danger">Edit</a>
				</td>
			</tr>
		<?php }?>
		</tbody>
	</table>
</div>
