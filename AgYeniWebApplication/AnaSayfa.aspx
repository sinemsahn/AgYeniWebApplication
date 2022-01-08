<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="AgYeniWebApplication.AnaSayfa" %>

<!DOCTYPE html>
<html lang="en" >
<head>
  <meta charset="UTF-8">

<meta name="viewport" content="width=device-width, initial-scale=1.0"><link rel="stylesheet" href="./style.css">

</head>
<body>

<div class="page">
 
  <header class="header">
    <div class="header__logo-container">
      <a href="" target="_blank" class="header__logo"></a>
    </div>
    <div class="header__links">
      <a href="/AdminLoginSayfasi.aspx" runat="server" class="header__link">Admin Giriş</a>
      <a  href="/AnaSayfa.aspx"  runat="server" class="header__link">Tüm Ürünler</a>
      
    </div>
    <div class="header__search-container">
        
      <svg width="24" height="25" viewBox="0 0 24 25" fill="none" onclick="inputfunc();" xmlns="http://www.w3.org/2000/svg">
        <path d="M11 19.5C15.4183 19.5 19 15.9183 19 11.5C19 7.08172 15.4183 3.5 11 3.5C6.58172 3.5 3 7.08172 3 11.5C3 15.9183 6.58172 19.5 11 19.5Z" stroke="black" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" />
        <path d="M21 21.5L16.65 17.15" stroke="black" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" />
      </svg>
           <form runat="server">
            <asp:TextBox ID="TextBox1"  class="header__search" runat="server"></asp:TextBox>
        
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" class="button-paper" Text="Ürün Ara" />

        </form>
      
    </div>
      

   
  </header>

  <div class="main">
    <h2 class="main__title">Toplam Ürünler</h2>

   
     

      <asp:ListView ID="lstUrun" runat="server">
          <ItemTemplate>
        <div class="list">
             <div class="resimkutu"><img width="150px" height="150px"  src='<%# Eval("Resim")%>' /></div>
              <div  class="header__link"><a href='<%#"Urunwebformu.aspx?urun=" + Eval("ResimAdi").ToString()+"&"+"id="+Eval("ID") %>'><%# Eval("ResimAdi")%></a></div>  
              </div>
        </ItemTemplate>
          </asp:ListView>



  

</div>

  <script src='https://unpkg.co/gsap@3/dist/gsap.min.js'></script>
<script src='https://assets.codepen.io/16327/Flip.min.js'></script><script  src="./script.js"></script>

</body>
</html>
