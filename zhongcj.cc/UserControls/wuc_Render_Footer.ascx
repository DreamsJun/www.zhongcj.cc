<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wuc_Render_Footer.ascx.cs" Inherits="zhongcj.cc.UserControls.wuc_Render_Footer" %>
<div class="footer"><% var styles = ""; if ((this.Page is zhongcj.cc.Default) == false) { styles = @"style=""background:none;"""; } %>
     <div class="f_bg"<%=styles %>></div>
     <div class="f_top">
         <ul class="f_w">
             <li class="w_item">
                 <strong>购物指南</strong>
                 <ul class="wis">
                     <li><a href="" target="_blank">会员介绍</a></li>
                     <li><a href="" target="_blank">会员介绍</a></li>
                     <li><a href="" target="_blank">常见问题</a></li>
                     <li><a href="" target="_blank">联系客服</a></li>
                 </ul>             
             </li>
             <li class="w_item">
                 <strong>配送方式</strong>
                 <ul class="wis">
                 <li><a href="" target="_blank">上门自提</a></li>
                 <li><a href="" target="_blank">配送费收取标准</a></li>
                 <li><a href="" target="_blank">订单说明</a></li>
                 <li><a href="" target="_blank">签收注意事项</a></li>
                 </ul>             
             </li>
             <li class="w_item">
                 <strong>支付方式</strong>
                 <ul class="wis">
                 <li><a href="" target="_blank">货到付款</a></li>
                 <li><a href="" target="_blank">在线支付</a></li>
                 <li><a href="" target="_blank">分期付款</a></li>
                 </ul>             
             </li>
             <li class="w_item">
                 <strong>售后服务</strong>
                 <ul class="wis">
                 <li><a href="" target="_blank">售后政策</a></li>
                 <li><a href="" target="_blank">价格保护</a></li>
                 <li><a href="" target="_blank">退款说明</a></li>
                 <li><a href="" target="_blank">返修/退换货</a></li>
                 <li><a href="" target="_blank">取消订单</a></li>
                 </ul>             
             </li>
             <li class="w_item">
                 <strong>热点服务</strong>
                 <ul class="wis">
                 <li><a href="" target="_blank">联系我们</a></li>
                 <li><a href="" target="_blank">帮助中心</a></li>
                 <li><a href="" target="_blank">投诉已建议</a></li>
                 <li><a href="" target="_blank">联系客服</a></li>
                 </ul>             
             </li>
         </ul>
         <div class="f_qrc">
              <span class="ts">技术支持</span>
              <img src="/styles/images/qrc.png" alt="扫一扫,添加好友" />
              <span class="af">扫一扫,添加好友</span>
         </div>
     </div>
     <div class="clear"></div>
     <div class="copyright">
          版权所有&copy;2017:&nbsp;&nbsp;梦境网&nbsp;&nbsp;/&nbsp;&nbsp;备案号码：<a href="http://www.miitbeian.gov.cn/publish/query/indexFirst.action" target="_blank">粤ICP备16128220号-1</a>&nbsp;&nbsp;/&nbsp;&nbsp;主办单位名称：钟承军<br />
          <a href="" target="_blank">留言</a>&nbsp;&nbsp;/&nbsp;&nbsp;QQ交谈：<a href="http://wpa.qq.com/msgrd?v=3&uin=563594702&site=qq&menu=yes" target="_blank" rel="nofollow" class="service"><img border="0" src="http://wpa.qq.com/pa?p=2:563594702:52" alt="点击这里给我发消息" title="点击这里给我发消息"/></a>
          &nbsp;&nbsp;/&nbsp;&nbsp;电子邮件：<a href="mailto:563594702@qq.com" title="" rel="nofollow">563594702@qq.com</a>
          &nbsp;&nbsp;/&nbsp;&nbsp;电话：15119519824&nbsp;&nbsp;/&nbsp;&nbsp;住宅地区：广东省广州市番禺区市桥镇
     </div>
</div>