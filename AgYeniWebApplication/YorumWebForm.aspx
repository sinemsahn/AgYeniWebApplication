<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YorumWebForm.aspx.cs" Inherits="AgYeniWebApplication.YorumWebForm" %>

<!DOCTYPE html>
<html lang="en" >
<head>
  <meta charset="UTF-8">
  <title>CodePen - #5 - Contact Form</title>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css"><link rel="stylesheet" href="./style3.css">

</head>
<body>
<!-- partial:index.partial.html -->

<div class="wrapper">
	    <form action="" runat="server">
	        <div class="title">Yorum Yaz</div>
	        <div class="name-wrapper">
	                <input type="text" name="Ad" placeholder="Ad" autofocus="autofocus" required>
	                <input type="text" name="Soyad" placeholder="Soyad" required>
	        </div>
        <input type="Yorum" name="Yorum" placeholder="Yorum" required>
        <asp:Button ID="Button3" runat="server" Text="Gönder" class="button-paper" OnClick="Button3_Click"/>
	    </form>
	</div>

  <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
</body>
</html>

