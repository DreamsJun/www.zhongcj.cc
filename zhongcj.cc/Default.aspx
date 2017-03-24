<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="zhongcj.cc.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
<div class="banner">
     <div id="full-screen-slider">
	     <ul id="slides">
             <li style="background-image:url(/styles/images/banner_01.jpg); display:block;"><a href="">Banner1</a></li>
             <li style="background-image:url(/styles/images/banner_02.jpg);"><a href="">Banner1</a></li>
             <li style="background-image:url(/styles/images/banner_03.jpg);"><a href="">Banner1</a></li>
	     </ul>
     </div>
</div>
<div class="h_product">
     <div class="hp_category">
          <div class="hpc_title"><h3></h3></div>
     </div>
</div>

<script src="/javascript/bannerslide.js" type="text/javascript"></script>
</asp:Content>
