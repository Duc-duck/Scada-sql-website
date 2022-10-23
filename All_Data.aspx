<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="All_Data.aspx.cs" Inherits="All_Data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <h1 class="fa fa-users" style="font-size:150%;margin-left:20px"><b> General Informations</b></h1>
            <div style="margin-left:405px">
                <asp:Button ID="Button1" runat="server" Text="Ascending" OnClick="All_Asc_Click" /> &ensp;&nbsp
                <asp:Button ID="Button2" runat="server" Text="Descending" OnClick="All_Desc_Click"/>
            </div>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
</asp:Content>

