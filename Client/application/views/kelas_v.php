<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 6:39 PM
 */

$counter = 1;

if (!isset($kelas))
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
			<a href="<?php echo base_url('index.php/kelas_c/add')?>" class="btn btn-info">Tambahkan Kelas</a>
		</div>
	</div>


	<table class="table table-hover mt-3">
		<thead>
		<tr>
			<th scope="col">No</th>
			<th scope="col">Kode Kelas</th>
			<th scope="col">Tempat</th>
			<th scope="col">Opsi</th>
		</tr>
		</thead>
		<tbody>
		<?php foreach ($kelas as $key){?>
			<tr class="table-success">
				<th scope="row"><?php echo $counter++;?></th>
				<td><?php echo $key->kode_kelas;?></td>
				<td><?php echo $key->tempat;?></td>
				<td>
					<a href="<?php echo base_url() ?>index.php/kelas_c/delete/<?php echo $key->id?>" class="btn btn-warning">Hapus</a>
					<a href="<?php echo base_url() ?>index.php/kelas_c/edit/<?php echo $key->id?>" class="btn btn-danger">Edit</a>
				</td>
			</tr>
		<?php }?>
		</tbody>
	</table>
</div>
