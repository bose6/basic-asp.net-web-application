<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="webproject.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="loginbox">
     <img src="/image/login.png" alt="Alternate text" class="user"  />
     <h2 class="log-in">Log-in</h2>
      
         <asp:Label Text="email" CssClass="lblemail" runat="server" />
         <asp:TextBox runat="server" CssClass="textemail" placeholder="enter email" ID="username" />
         <asp:Label Text="password" CssClass="lblpassword" runat="server" />
         <asp:TextBox runat="server" CssClass="textpass" placeholder="**********" ID="password" TextMode="Password"/>
         <asp:button Text="sign in" CssClass="bttnsign" runat="server" OnClick="Unnamed3_Click"   />
         <br />
         <asp:Label ID="wroung" Text=" " runat="server" ForeColor="#CCCCCC"  />
     </div>
</asp:Content>
