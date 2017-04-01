<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wuc_Render_ProductCategoryMenu.ascx.cs" Inherits="zhongcj.cc.UserControls.wuc_Render_ProductCategoryMenu" %>
<%var styles = @" style=""display:none;""";
  if (this.Page is zhongcj.cc.Default)
  {
      styles = "";
  }
     %>
<div class="produtcategorymenu">
     <div class="ptm_all">全部商品</div>
     <ul class="ptm_seniors"<%=styles %>>
         <li class="ptm_senior">
             <a class="ptm_senior_title" rel="nofllow">苹果(Apple)</a>
             <ul class="ptms_ul">
                 <li>钢化玻璃</li>
                 <li>高清软膜</li>
                 <li>液态纳米</li>
                 <li>其他</li>
             </ul>
         </li>
         <li class="ptm_senior">
             <a class="ptm_senior_title" rel="nofllow">OPPOvivo</a>
             <ul class="ptms_ul">
                 <li>钢化玻璃</li>
                 <li>高清软膜</li>
                 <li>液态纳米</li>
                 <li>其他</li>
             </ul>
         </li>
         <li class="ptm_senior">
             <a class="ptm_senior_title" rel="nofllow">小米（MI）</a>
             <ul class="ptms_ul">
                 <li>钢化玻璃</li>
                 <li>高清软膜</li>
                 <li>液态纳米</li>
                 <li>其他</li>
             </ul>
         </li>
         <li class="ptm_senior">
             <a class="ptm_senior_title" rel="nofllow">华为（HUAWEI）</a>
             <ul class="ptms_ul">
                 <li>钢化玻璃</li>
                 <li>高清软膜</li>
                 <li>液态纳米</li>
                 <li>其他</li>
             </ul>
         </li>
         <li class="ptm_senior">
             <a class="ptm_senior_title" rel="nofllow">三星（SAMSUNG）</a>
             <ul class="ptms_ul">
                 <li>钢化玻璃</li>
                 <li>高清软膜</li>
                 <li>液态纳米</li>
                 <li>其他</li>
             </ul>
         </li>
         <li class="ptm_senior">
             <a class="ptm_senior_title" rel="nofllow">魅族（MEIZU）</a>
             <ul class="ptms_ul">
                 <li>钢化玻璃</li>
                 <li>高清软膜</li>
                 <li>液态纳米</li>
                 <li>其他</li>
             </ul>
         </li>
         <li class="ptm_senior">
            <a class="ptm_senior_title" rel="nofllow">魅族（MEIZU）</a>
             <ul class="ptms_ul">
                 <li>钢化玻璃</li>
                 <li>高清软膜</li>
                 <li>液态纳米</li>
                 <li>其他</li>
             </ul>
         </li>
         <li class="ptm_senior">
             <a class="ptm_senior_title" rel="nofllow">魅族（MEIZU）</a>
             <ul class="ptms_ul">
                 <li>钢化玻璃</li>
                 <li>高清软膜</li>
                 <li>液态纳米</li>
                 <li>其他</li>
             </ul>
         </li>
         <li class="ptm_senior">
             <a class="ptm_senior_title" rel="nofllow">魅族（MEIZU）</a>
             <ul class="ptms_ul">
                 <li>钢化玻璃</li>
                 <li>高清软膜</li>
                 <li>液态纳米</li>
                 <li>其他</li>
             </ul>
         </li>
         <li class="ptm_senior"><a href="/product/" class="ptm_senior_title ptm_senior_title_more">查看更多</a></li>
     </ul>
</div>