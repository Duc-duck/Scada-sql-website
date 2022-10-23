<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Sensors_Details.aspx.cs" Inherits="Sensors_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <h1 class="fa fa-thermometer-full" style="font-size:150%;margin-left:20px"><b> Sensors</b></h1>
    <div style="margin-left:50px;font-size:120%">
            <h2 class="fa fa-hand-o-right"> Cam bien nhiet</h2> <br />
            <h2 class="fa fa-hand-o-right"> Cam bien luu luong</h2><br />
            <h2 class="fa fa-hand-o-right"> SP tiet trung</h2><br />
            <h2 class="fa fa-hand-o-right"> Sp trong thung</h2>
    </div><br /><br />
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
    <div style="margin-left:390px">
        <asp:TextBox ID="tbxNamed" runat="server" placeholder="Sensors name"></asp:TextBox>&ensp;&nbsp
        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Name_Click" />
    </div><br />
    <asp:literal ID="Literal3" runat="server"></asp:literal>
        </ContentTemplate>
    </asp:UpdatePanel>  
</asp:Content>

