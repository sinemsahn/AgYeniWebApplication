<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminAnaSayfa.aspx.cs" Inherits="AgYeniWebApplication.AdminAnaSayfa" %>

<!DOCTYPE html>
<html lang="en" >
<head>
  <meta charset="UTF-8">
  <title>CodePen - Buttons-CSS</title>
  <link rel="stylesheet" href="./style5.css">

</head>
<body>
    <form runat="server">
  <li>
    <p class="button-cover" role="button"><span class="text">Admin Sayfası Hoşgeldiniz!</span><span>Hey!</span></p>
  </li>
<!-- partial:index.partial.html -->
<ul class="container">
  <li>
      <asp:Button class="button-perspective"  ID="Button1"  Text="Yorum Silme- Düzenleme- Ekleme" runat=server OnClick="Button1_Click" /> 
  </li>

</ul>
<ul class="container">
  <li>
      <asp:Button ID="Button3"  class="button-perspective" Text="Ürün Silme-Ekleme -Düzenleme" runat="server" OnClick="Button3_Click" /> 
  </li
    
  <li>
      <asp:Button class="button-paper"  ID="Button4" Text="Çıkış" OnClick="Button4_Click" runat="server" /> 
  </li>
  
</ul
        </form>
<!-- partial -->
  
</body>
</html>
