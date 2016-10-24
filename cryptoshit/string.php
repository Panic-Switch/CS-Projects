// I know this is PHP, but I am putting because it will be used in some projects

<?php

if(isset($_GET['name']) && !empty($_GET['name']))
{
    $data = $_GET['name'];
    
    $download = "Test string.";

    print $download;
    
    print $data;
}
?>
