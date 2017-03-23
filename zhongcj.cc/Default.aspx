<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="zhongcj.cc.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
<div class="banner">
     <ul class="slides">
         <li style="background-image:url(/styles/images/banner_01.jpg); display:block;"><a href="">Banner1</a></li>
         <li style="background-image:url(/styles/images/banner_02.jpg);"><a href="">Banner1</a></li>
         <li style="background-image:url(/styles/images/banner_03.jpg);"><a href="">Banner1</a></li>
     </ul>
</div>

<%--<script type="text/javascript" language="javascript">

    //从第二幅开始
    var NowIn = 1;//出来
    var NowOut = 0;//消失
    var speed = 4000;//每幅画移动的时间（毫秒）
    var Banners = document.getElementById("JsSlides").getElementsByTagName("li");
    var BannerLengths = Banners.length
    InitTabBtns(BannerLengths);//初始化按钮
    var li_TabBtns = document.getElementById("TabBtns").getElementsByTagName("li");
    for (var i = 0; i < BannerLengths; i++) {
        li_TabBtns[i].index = i;
        li_TabBtns[i].onclick = function () {
            ClickTabBtns(this.index);
        }
    }

    function ClickTabBtns(current) {        
        for (var i = 0; i < BannerLengths; i++) {
            if (current == i) {
                li_TabBtns[i].className = "current";
            }
            else {
                li_TabBtns[i].className = "";
            }
        }
        $('#JsSlides li').eq(current).fadeIn(300);
        $('#JsSlides li').eq(NowOut).fadeOut(300);
        NowIn = current;
    }
    function TabBanner() {
        if (BannerLengths > 1) {
            if (NowIn == 0) {
                NowOut = BannerLengths - 1;
            } else {
                NowOut = NowIn - 1;
            }
            $('#JsSlides li').eq(NowIn).css('z-index', '900');
            $('#JsSlides li').eq(NowOut).css({ 'z-index': '800' }).show();
            li_TabBtns[NowIn].className = "current";
            li_TabBtns[NowOut].className = "";

            $('#JsSlides li').eq(NowIn).fadeIn(600, function () { $('#JsSlides li').eq(NowOut).fadeOut(); });

            NowIn++;
            if (NowIn == BannerLengths) {
                NowIn = 0;
            }
            NowOut = NowIn;
            setTimeout(TabBanner, speed);
        }
    }
    setTimeout(TabBanner, speed);
    //初始化按钮
    function InitTabBtns(lenght) {
        var TabBtns = $('#TabBtns');
        var html = "";
        for (var i = 0; i < lenght; i++) {
            if (i == 0) {
                html = "<li class='current'><b>#</b></li>".replace("#",i);
            }
            else {
                html += "<li><b>#</b></li>".replace("#", i); ;
            }
        }
        TabBtns.html(html);        
    }
    
</script>--%>
<script src="/javascript/bannerslide.js" type="text/javascript"></script>
</asp:Content>
