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
    <ul class="p_category_items" id="SelectCategorys">
        <li class="pci">
            <div class="pci_title">分类：</div>
            <ul class="pci_list">
                <li><a href="" target="_self" value="0">分类1</a></li>
                <li><a href="" target="_self" value="1">分类1</a></li>
                <li><a href="" target="_self" value="0">分类1</a></li>
                <li><a href="" target="_self" value="0">分类1</a></li>
                <li><a href="" target="_self" value="0">分类1</a></li>
                <li><a href="" target="_self" value="0">分类1</a></li>
                <li><a href="" target="_self" value="0">分类1</a></li>
                <li><a href="" target="_self" value="0">分类1</a></li>
                <li><a href="" target="_self" value="0">分类1</a></li>
                <li><a href="" target="_self" value="0">分类1</a></li>
            </ul>
            <b class="multiselect">+ 多选</b>
            <div class="pci_btns">
                 <ul>
                     <li class="submit">确定</li>
                     <li class="cancle" onclick="cancleMoreSelect(0)">取消</li>
                 </ul>
            </div>
        </li>
        <li class="pci">
            <div class="pci_title">品牌：</div>
            <ul class="pci_list">
                <li><a href="" target="_self" value="0">品牌</a></li>
                <li><a href="" target="_self" value="0">品牌</a></li>
                <li><a href="" target="_self" value="0">品牌</a></li>
                <li><a href="" target="_self" value="0">品牌</a></li>
                <li><a href="" target="_self" value="0">品牌</a></li>
                <li><a href="" target="_self" value="0">品牌</a></li>
                <li><a href="" target="_self" value="0">品牌</a></li>
                <li><a href="" target="_self" value="0">品牌</a></li>
                <li><a href="" target="_self" value="0">品牌</a></li>
                <li><a href="" target="_self" value="0">品牌</a></li>
            </ul>
            <b class="multiselect">+ 多选</b>
            <div class="pci_btns">
                 <ul>
                     <li class="submit">确定</li>
                     <li class="cancle" onclick="cancleMoreSelect(1)">取消</li>
                 </ul>
            </div>
        </li>
    </ul>
    
</div>
<% var path = Request.RawUrl.ToLower(); %>
<script type="text/javascript" language="javascript">
    var path = "<%=path %>";
    var Type = "";//类型，品牌？
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

    var currentOpenIndex = -1;//当前打开的

    var Categorys = document.getElementById("SelectCategorys");
    var addSelect = Categorys.getElementsByTagName("b");
    var pci = $('.p_category_items .pci');

    for (var i = 0; i < addSelect.length; i++) {
        addSelect[i].index = i;
        addSelect[i].onclick = function () {
            popupBtns(this.index);
        }
    }
    function popupBtns(index) {
        if (currentOpenIndex > -1) {//上一个选中添加的元素
            pci.eq(currentOpenIndex).removeClass("pci_add");
            pci.eq(currentOpenIndex).find(".pci_btns").css("display", "none");
            pci.eq(currentOpenIndex).find(".multiselect").css("display", "block");
            var currentCategory = document.getElementById("currentCategory").getElementsByTagName("li");
            var valuelis = $('#currentCategory').find("li"); //添加选中的元素
            var values = $('#currentCategory').find("a");
            var cc_length = currentCategory.length;
            for (var j = 0; j < cc_length; j++) {
                valuelis.eq(j).attr("class", "");
                var str = "<i>" + values.eq(j).attr("value") + "</i>";
                currentCategory[j].innerHTML = currentCategory[j].innerHTML.replace(str, "");
            }
            $('.pci_list').eq(currentOpenIndex).attr("id", "");
        }        
        pci.eq(index).addClass("pci_add");
        pci.eq(index).find(".pci_btns").css("display", "block");
        pci.eq(index).find(".multiselect").css("display", "none");
        currentOpenIndex = index;

        $('.pci_list').eq(index).attr("id","currentCategory");//给当前分类添加ID
        var currentCategory = document.getElementById("currentCategory").getElementsByTagName("li");
        var values = $('#currentCategory').find("a");
        var cc_length = currentCategory.length;
        for (var j = 0; j < cc_length; j++) {
            currentCategory[j].innerHTML = "<i>" + values.eq(j).attr("value") + "</i>" + currentCategory[j].innerHTML;
        }
        var selects= document.getElementById("currentCategory").getElementsByTagName("i");

        for (var g = 0; g < selects.length; g++) {
            selects[g].index = g;
            selects[g].onclick = function () {
                SelectCurrent(this.index);
            }
        }        
    }
    //关闭当前打开的项
    function cancleMoreSelect(value) {
        pci.eq(value).removeClass("pci_add");
        pci.eq(value).find(".pci_btns").css("display", "none");
        pci.eq(value).find(".multiselect").css("display", "block");
        var currentCategory = document.getElementById("currentCategory").getElementsByTagName("li");
        var valuelis = $('#currentCategory').find("li"); //添加选中的元素
        var values = $('#currentCategory').find("a");
        var cc_length = currentCategory.length;
        for (var j = 0; j < cc_length; j++) {
            valuelis.eq(j).attr("class", "");
            var str = "<i>" + values.eq(j).attr("value") + "</i>";
            currentCategory[j].innerHTML = currentCategory[j].innerHTML.replace(str, "");
        }
    }

    var selectValue ="";
    
    function SelectCurrent(g) {

        var c = document.getElementById("currentCategory").getElementsByTagName("i");
        var cValue = c[g].innerHTML;
        if (selectValue.indexOf(cValue) > 0) {

        }
        else { 
        
        }


    }


</script>
</asp:Content>
