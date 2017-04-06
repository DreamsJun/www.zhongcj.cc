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
                <li><a href="" target="_self" value="1">分类1</a></li>
                <li><a href="" target="_self" value="2">分类1</a></li>
                <li><a href="" target="_self" value="3">分类1</a></li>
                <li><a href="" target="_self" value="4">分类1</a></li>
                <li><a href="" target="_self" value="5">分类1</a></li>
                <li><a href="" target="_self" value="6">分类1</a></li>
                <li><a href="" target="_self" value="7">分类1</a></li>
                <li><a href="" target="_self" value="8">分类1</a></li>
                <li><a href="" target="_self" value="9">分类1</a></li>
                <li><a href="" target="_self" value="10">分类1</a></li>
            </ul>
            <b class="multiselect">+ 多选</b>
            <div class="pci_btns">
                 <ul>
                     <li class="submit" onclick="SerachSubmit('c')">确定</li>
                     <li class="cancle" onclick="cancleMoreSelect(0)">取消</li>
                 </ul>
            </div>
        </li>
        <li class="pci">
            <div class="pci_title">品牌：</div>
            <ul class="pci_list">
                <li><a href="" target="_self" value="3">品牌</a></li>
                <li><a href="" target="_self" value="6">品牌</a></li>
                <li><a href="" target="_self" value="7">品牌</a></li>
                <li><a href="" target="_self" value="9">品牌</a></li>
                <li><a href="" target="_self" value="8">品牌</a></li>
                <li><a href="" target="_self" value="10">品牌</a></li>
                <li><a href="" target="_self" value="20">品牌</a></li>
                <li><a href="" target="_self" value="31">品牌</a></li>
                <li><a href="" target="_self" value="36">品牌</a></li>
                <li><a href="" target="_self" value="98">品牌</a></li>
            </ul>
            <b class="multiselect">+ 多选</b>
            <div class="pci_btns">
                 <ul>
                     <li class="submit" onclick="SerachSubmit('b')">确定</li>
                     <li class="cancle" onclick="cancleMoreSelect(1)">取消</li>
                 </ul>
            </div>
        </li>
    </ul>
    <div class="product_body">
         <div class="product_left">
              <ul class="pl_list">
                  <li class="pl_list_title">精品推荐</li>
                  <li>
                      <a class="pll_img"><img src="" alt="" /></a>
                      <span class="price">¥208.00</span>
                      <a class="pll_title">JJC CD1E佳能700D 750D+18-55mm STM镜</a>
                  </li>
                  <li>
                      <a class="pll_img"><img src="" alt="" /></a>
                      <span class="price">¥208.00</span>
                      <a class="pll_title">JJC CD1E佳能700D 750D+18-55mm STM镜</a>
                  </li>
                  <li>
                      <a class="pll_img"><img src="" alt="" /></a>
                      <span class="price">¥208.00</span>
                      <a class="pll_title">JJC CD1E佳能700D 750D+18-55mm STM镜</a>
                  </li>
                  <li>
                      <a class="pll_img"><img src="" alt="" /></a>
                      <span class="price">¥208.00</span>
                      <a class="pll_title">JJC CD1E佳能700D 750D+18-55mm STM镜</a>
                  </li>
                  <li>
                      <a class="pll_img"><img src="" alt="" /></a>
                      <span class="price">¥208.00</span>
                      <a class="pll_title">JJC CD1E佳能700D 750D+18-55mm STM镜</a>
                  </li>
                  <li>
                      <a class="pll_img"><img src="" alt="" /></a>
                      <span class="price">¥208.00</span>
                      <a class="pll_title">JJC CD1E佳能700D 750D+18-55mm STM镜</a>
                  </li>
              </ul>

              <div class="pl_rcm"><a href="" target="_blank"><img src="/styles/images/prcm.jpg" alt="广告位" /></a></div>

              <ul class="pl_list">
                  <li class="pl_list_title">我的足迹</li>
                  <li>
                      <a class="pll_img"><img src="" alt="" /></a>
                      <span class="price">¥208.00</span>
                      <a class="pll_title">JJC CD1E佳能700D 750D+18-55mm STM镜</a>
                  </li>
                  <li>
                      <a class="pll_img"><img src="" alt="" /></a>
                      <span class="price">¥208.00</span>
                      <a class="pll_title">JJC CD1E佳能700D 750D+18-55mm STM镜</a>
                  </li>
                  <li>
                      <a class="pll_img"><img src="" alt="" /></a>
                      <span class="price">¥208.00</span>
                      <a class="pll_title">JJC CD1E佳能700D 750D+18-55mm STM镜</a>
                  </li>
                  <li>
                      <a class="pll_img"><img src="" alt="" /></a>
                      <span class="price">¥208.00</span>
                      <a class="pll_title">JJC CD1E佳能700D 750D+18-55mm STM镜</a>
                  </li>
                  <li>
                      <a class="pll_img"><img src="" alt="" /></a>
                      <span class="price">¥208.00</span>
                      <a class="pll_title">JJC CD1E佳能700D 750D+18-55mm STM镜</a>
                  </li>
                  <li>
                      <a class="pll_img"><img src="" alt="" /></a>
                      <span class="price">¥208.00</span>
                      <a class="pll_title">JJC CD1E佳能700D 750D+18-55mm STM镜</a>
                  </li>
              </ul>
         </div>
         <div class="product_right">
              <div class="product_screen">
                   <ul class="ul_screen">
                       <li class="current"><a href="" target="_self">默认</a></li>
                       <li><a href="" target="_self">销量</a></li>
                       <li><a href="" target="_self">评论</a></li>
                       <li><a href="" target="_self">新品</a></li>
                       <li><a href="" target="_self" class="price">价格</a></li>
                   </ul>
                   <ul class="ps_btns">
                        <li class="ps_dsps">共1200件商品&nbsp;&nbsp;<span>1</span>/3</li>
                        <li class="psb_item">
                            <a href="" target="_self">&lt;</a>
                            <a href="" target="_self">&gt;</a>
                        </li>
                   </ul>
              </div>
              <div class="productlist">
                   <ul></ul>
              </div>
         </div>
    </div>
</div>
<% var path = Request.RawUrl.ToLower(); %>
<script type="text/javascript" language="javascript">
    var path = "<%=path %>";
    var Type = ""; //类型，品牌？
    var ValuesArray = new Array();//当前选择的值
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
        ValuesArray = new Array(); //清空当前选择值
        $('.pci_btns ul li.submit').css("display", "none"); //隐藏确定按钮
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
        ValuesArray = new Array();
        $('.pci_btns ul li.submit').css("display", "none"); //隐藏确定按钮
    }

    var arrayLength = 0;

    function SelectCurrent(g) {
        var c = document.getElementById("currentCategory").getElementsByTagName("i");
        var cValue = c[g].innerHTML;//获取当前点击的值
        arrayLength = ValuesArray.length;//获取当前数组长度
        var item;
        if (arrayLength > 0) {
            var isIndexOF = false;
            for (item in ValuesArray) {//这个循环判断是否已经有选中当前的值了
                if (ValuesArray[item] == cValue) {//如果有
                    $("#currentCategory li").eq(g).removeClass("current");//删除当前选中值
                    isIndexOF = true;
                    arrayLength = ValuesArray.splice(item, 1);  //删除当前选择项
                    arrayLength = ValuesArray.length;
                    if (arrayLength == 0) { //如果全部删除值
                        $('.pci_btns ul li.submit').css("display", "none"); //隐藏确定按钮
                    }
                }                
            }
            if (isIndexOF == false) {//如果
                $("#currentCategory li").eq(g).addClass("current");
                arrayLength = ValuesArray.push(cValue);
            }
        }
        else {
            arrayLength = ValuesArray.push(cValue);//添加第一个数组
            $("#currentCategory li").eq(g).addClass("current");
            $('.pci_btns ul li.submit').css("display", "block");//显示确定按钮
        }
    }

    function SerachSubmit(type) {
        switch (type) {
            case "c":
                Type = type;
                //alert("分类" + ValuesArray.join(","));
                break;
            case "b":
                Type = type;
                //alert("品牌" + ValuesArray.join(","));
                break;
        }
        alert(Type + ValuesArray.join(","));
    }

</script>
</asp:Content>
