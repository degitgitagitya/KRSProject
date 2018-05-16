<?php
/**
 * Created by PhpStorm.
 * User: De Gitgit Agitya
 * Date: 5/16/2018
 * Time: 12:51 AM
 */

?>
<body>

<br>
<br>
<br>
<br>
<br>

	<div class="container">
		<div class="row justify-content-center mt-5">
			<form action="<?php echo base_url('index.php/login/loginAdmin'); ?>" method="post"class="col-10 col-md-6 col-lg-4 text-center bg-primary p-5">
				<h3><strong style="color: white;">Login Disini.</strong></h3>
				<input type="text" name="username" placeholder="Username" class="p-2 my-1" style="border-radius: 20px; border: 1px;" autofocus>
				<br>
				<input type="password" name="password" placeholder="Password" class="p-2 my-1" style="border-radius: 20px; border: 1px;">
				<br>
				<input type="submit" class="btn btn-success px-4 my-1" value="Login" style="border-radius: 20px; border: 1px;">
			</form>
		</div>
	</div>

