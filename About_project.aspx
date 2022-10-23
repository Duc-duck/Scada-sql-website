<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="About_project.aspx.cs" Inherits="About_project" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <h1 class="fa fa-cogs" style="font-size:150%;margin-left:20px"><b> Operating line</b></h1><br />
    <h5 class="fa fa-play-circle-o" style="font-size:130%;margin-left:30px"> &nbsp;Sau đây là video về nguyên lý hoạt động của hệ thống:</h5>
    <div style="margin-left:210px">
    <video width="640" height="480" controls>
        <source src="assets/images/Video.mp4" type="video/mp4">
    </video>
    </div><br /><br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

