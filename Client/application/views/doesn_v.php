<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 1:55 PM
 */

$counter = 1;

if (!isset($dosen))
{
	redirect(base_url());
}
?>

<hr class="container">
<h1 class="text-center">Daftar Dosen</h1>
<hr class="container">

<div class="container">


	<div class="row mt-3">
		<div class="col-2">
			<a href="<?php echo base_url('index.php/dosen_c/add')?>" class="btn btn-info">Tambahkan Dosen</a>
		</div>
	</div>


	<table class="table table-hover mt-3">
		<thead>
		<tr>
			<th scope="col">No</th>
			<th scope="col">NIP</th>
			<th scope="col">Nama Dosen</th>
			<th scope="col">Kode Dosen</th>
			<th scope="col">Opsi</th>
		</tr>
		</thead>
		<tbody>
		<?php foreach ($dosen as $key){?>
			<tr class="table-success">
				<th scope="row"><?php echo $counter++;?></th>
				<td><?php echo $key->nip;?></td>
				<td><?php echo $key->nama;?></td>
				<td><?php echo $key->kode_dosen;?></td>
				<td>
					<a href="<?php echo base_url() ?>index.php/dosen_c/delete/<?php echo $key->id?>" class="btn btn-warning">Hapus</a>
					<a href="<?php echo base_url() ?>index.php/dosen_c/edit/<?php echo $key->id?>" class="btn btn-danger">Edit</a>
				</td>
			</tr>
		<?php }?>
		</tbody>
	</table>
</div>
