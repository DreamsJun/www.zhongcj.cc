<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="zhongcj.cc.Admin.Menu" %>
<div id="div_menu">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="170px"
        EnableViewState="False" Theme="Glass" 
        HeaderNavigateUrl="~/admin/Default.aspx" HeaderText="管理中心" >
        <ContentPaddings PaddingBottom="5px" PaddingLeft="0" PaddingRight="3px" 
            PaddingTop="10px" />
        <HeaderStyle BackColor="White" Height="23px" CssClass="admin_header">
        <Paddings PaddingBottom="0px" PaddingLeft="0" PaddingTop="0px" />
        <BorderBottom BorderStyle="None" />
        </HeaderStyle>
        <PanelCollection>
<dx:PanelContent ID="PanelContent1" runat="server">
<div style="padding-left:2px;margin-bottom:8px;"><img src="/styles/images/admin/products.gif" /></div>
<dx:ASPxNavBar ID="ASPxNavBar1" runat="server" AutoCollapse="True" EnableAnimation="true" 
        DataSourceID="xdsNavMenu" EnableTheming="true" Width="100%" 
        SyncSelectionMode="CurrentPath"
        OnItemDataBound="nbMenu_ItemDataBound"  CssPostfix="Aqua" 
        GroupSpacing="1px" >
        <GroupContentStyle ItemSpacing="1px">
        </GroupContentStyle>
        <ItemStyle ImageSpacing="10px" />
        <GroupDataFields TextField="tile" />
        <ItemDataFields NavigateUrlField="url" TextField="title" />
    </dx:ASPxNavBar>
</dx:PanelContent>
</PanelCollection>
        <HeaderImage Url="~/styles/images/admin/home.gif" />
    </dx:ASPxRoundPanel>

    <a href="https://www.google.com/intl/zh-CN/chrome/browser/?hl=zh-CN" target="_blank" style="display:block;font-size:12px;background:#fff;border:solid 1px #aecaf0;margin:10px 0;padding:8px;line-height:18px;color:#777;">温馨提示：使用谷歌浏览器，获得极速的管理体验。</a>
</div>
<asp:XmlDataSource ID="xdsNavMenu" runat="server" 
    DataFile="~/admin/Menu.xml" XPath="/root/menu1">
</asp:XmlDataSource>