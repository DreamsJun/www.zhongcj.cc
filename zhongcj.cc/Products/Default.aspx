<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="zhongcj.cc.Products.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
<div class="navbody">
    <ul class="navs">
        <li>全部结果</li>
        <li class="nav_gt">&gt;</li>
        <li class="nav"><a href="">钢化膜</a></li>
        <li class="nav_gt">&gt;</li>
        <li class="nav_c"><a onclick="RemoveKey(1,'类别')">类别：类别</a></li>
        <li class="nav_gt">&gt;</li>
        <li class="nav_c"><a onclick="RemoveKey(2,'品牌')">品牌：品牌</a></li>
        <li class="nav_gt">&gt;</li>
        <li class="nav">"哥弟女装经典超值款舒"</li>
    </ul>
</div>
<div class="product">     
    <ul class="p_category_items">
        <li class="pci">
            <div class="pci_title">分类：</div>
            <ul class="pci_list">
                <li><a href="" target="_self">分类1</a></li>
                <li><a href="" target="_self">分类1</a></li>
                <li><a href="" target="_self">分类1</a></li>
                <li><a href="" target="_self">分类1</a></li>
                <li><a href="" target="_self">分类1</a></li>
                <li><a href="" target="_self">分类1</a></li>
                <li><a href="" target="_self">分类1</a></li>
                <li><a href="" target="_self">分类1</a></li>
                <li><a href="" target="_self">分类1</a></li>
                <li><a href="" target="_self">分类1</a></li>
            </ul>
        </li>
        <li class="pci">
            <div class="pci_title">品牌：</div>
            <ul class="pci_list">
                <li><a href="" target="_self">品牌</a></li>
                <li><a href="" target="_self">品牌</a></li>
                <li><a href="" target="_self">品牌</a></li>
                <li><a href="" target="_self">品牌</a></li>
                <li><a href="" target="_self">品牌</a></li>
                <li><a href="" target="_self">品牌</a></li>
                <li><a href="" target="_self">品牌</a></li>
                <li><a href="" target="_self">品牌</a></li>
                <li><a href="" target="_self">品牌</a></li>
                <li><a href="" target="_self">品牌</a></li>
            </ul>
        </li>
    </ul>
     
</div>
<% var path = Request.RawUrl.ToLower(); %>
<script type="text/javascript" language="javascript">
    var path = "<%=path %>";
    
    function RemoveKey(c,value) {
        var prefix = "";
        var rewrite = "";
        switch (c) {
            case 1: prefix = "-c_"; break;
            case 2: prefix = "-b_"; break;
        }
        rewrite = path.replace(prefix + value, prefix + "");

        alert(rewrite);
    }
    function removebrand(value) { 
    alert(value);
    }
</script>
</asp:Content>
