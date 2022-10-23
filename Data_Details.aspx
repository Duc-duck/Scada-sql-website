<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Data_Details.aspx.cs" Inherits="Data_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <h1 class="fa fa-eye" style="font-size:150%;margin-left:20px"><b> Searching Data</b></h1><br /><br />
    <div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
           <div style="margin-left:200px"> 
            <asp:TextBox ID="tbxName" runat="server" placeholder="Name"></asp:TextBox>
            <asp:TextBox ID="tbxStarttime" runat="server" placeholder="Start time"></asp:TextBox>
            <asp:TextBox ID="tbxEndtime" runat="server" placeholder="End time"></asp:TextBox>
            <asp:Button ID="btnXem" runat="server" Text="Search" OnClick="btnXem_Click"/>
            </div> <br />
            <div style="margin-left:405px">
                   <asp:Button ID="Button1" runat="server" Text="Ascending" OnClick="Asc_Click" /> &ensp;&nbsp
                   <asp:Button ID="Button2" runat="server" Text="Descending" OnClick="Desc_Click"/>
            </div> 
            <asp:literal ID="Literal2" runat="server"></asp:literal>          
        </ContentTemplate>
    </asp:UpdatePanel>                        
    </div><br />
</asp:Content>



