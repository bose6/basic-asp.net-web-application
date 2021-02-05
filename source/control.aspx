<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="control.aspx.cs" Inherits="webproject.control" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="control">
      <asp:Label Text="Default page text1" CssClass="lbltxt1" runat="server"  />
            <asp:TextBox runat="server" CssClass="tboxtxt1"  ID ="txt1"  placeholder="Default page text1" />
            <asp:Label Text="Default page text " CssClass="lbltxt2" runat="server" />
            <asp:TextBox runat="server" CssClass="tboxtxt2" placeholder="Default page text2" ID="txt2"/>
            <asp:Label Text="Header Text" CssClass="lblheader" runat="server" />
            <asp:TextBox runat="server" CssClass="tboxheader" placeholder="Default header" ID="dheader"/>
            <asp:Label Text="Footer Text" CssClass="lblfooter" runat="server" />
            <asp:TextBox runat="server" CssClass="tboxfooter" placeholder="Default footer" ID="dfooter" />
            <asp:button Text="Change" CssClass="btnchange" runat="server" OnClick="Unnamed9_Click" />
        </div>
</asp:Content>
