<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="UsingMasterPage.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="carousel slide" data-ride="carousel">
            <div class="carousel-inner">
                <div class="carousel-item active" style="width:100%">
                    <img src="technical-skills-training.jpg"/>
                </div>
                <div class="carousel-item">
                    <img src="unnamed-5.jpg"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
