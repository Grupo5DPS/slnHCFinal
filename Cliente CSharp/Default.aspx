<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cliente_CSharp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>UNIVERSIDAD ANDINA DEL CUSCO</h1>
        </div>

    <div class="row">
        <div class="view full-page-intro">
            <h2>
                <asp:Image ID="ImgUac" runat="server" Height="308px" Width="850px" 
               imgUac ImageUrl = "https://www.uandina.edu.pe/wp-content/uploads/2021/02/home_slider_bg.jpg" CssClass="img-responsive" />
            </h2>
        </div>
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
