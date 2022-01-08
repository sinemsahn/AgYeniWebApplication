<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Urunwebformu.aspx.cs" Inherits="AgYeniWebApplication.Urunwebformu" %>


<!DOCTYPE html>
<html lang="en" >
<head>
  <meta charset="UTF-8">
  <title>CodePen - Single Blog Page Bootstrap - 5th</title>
  <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.5.0/css/bootstrap.min.css'><link rel="stylesheet" href="./style2.css">

</head>
<body>
<!-- partial:index.partial.html -->

<form id="form1" runat="server">

  <asp:ListView ID="lstUrun" runat="server" >
        <ItemTemplate>

<div class="container my-5">
  <div style="max-width: 700px; top: -80px;" class="mx-auto text-secondary">
  
    <h1 class="font-weight-bold text-dark"> <%# Eval("ResimAdi") %>
</h1>
    </div>
    </div>

  <div align="center"><img width="500" height="500" src='<%# Eval("Resim")%>' /></div>
  
  <div style="max-width: 700px; top: -80px;" class="mx-auto text-secondary">
    
    <h3 class="font-weight-bold text-dark">Ürün Hakkında Bilgi:</h3>
    <p class="my-2" style="line-height: 2;"> <%# Eval("HakkindaBilgi")%></p>
  </ItemTemplate>
</asp:ListView>

<asp:ListView ID="lstUrunYorum" runat="server">
  <ItemTemplate>
   
    <div class="my-3 d-flex align-items-center justify-content-between">
      <div class="d-flex align-items-center">
      <img src="https://raw.githubusercontent.com/sinemsahn/AgYeniWebApplication/main/resimler/2.PNG" style="width: 50px;"/>
      <small class="ml-2">
        <a href="#" class="text-primary d-block"><%# Eval("YorumAdi")%></a>
        <span> <%# Eval("Yorumu")%></span>
      </small>
      <br><br>
   
      
    </div>
  </ItemTemplate>
</asp:ListView>
 
    
  </div>
</div>
<!-- partial -->
       <div style="margin-left: 560px">
           <asp:Button ID="Button1" runat="server" Text="Yorum Ekle" class="button-paper" OnClick="Button1_Click" />
           
           <asp:Button class="button-paper"  ID="Button4" Text="Ana Sayfa" OnClick="Button4_Click" runat="server" />
   
    </div>
    <div style="margin-left: 760px">
    </div>
    <div style="margin-left: 40px">
    </div>

</form>

  
  
</body>
</html>

