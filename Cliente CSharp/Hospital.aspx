<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Hospital.aspx.cs" Inherits="Cliente_CSharp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
<h1 style="background-color: #000000; color: #FFFFFF">Formulario Hospitales</h1>
<p>
        &nbsp;&nbsp;<table style="width: 87%; height: 124px;">
            <tr>
                <td style="border-style: groove; color: #FFFFFF; background-color: #000000;">ID:</td>
                <td style="height: 20px"> <asp:TextBox runat="server" Id="txtId"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnAgregar" runat="server" OnClick="Button1_Click" Text="Agregar Hospitales" CssClass="bg-primary" />
                </td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td style="color: #FFFFFF; background-color: #000000; border-style: groove">Descripción:</td>
                <td> <asp:TextBox runat="server" Id="txtDescripcion"/>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="color: #FFFFFF; background-color: #000000; border-style: groove">Director:</td>
                <td> <asp:TextBox runat="server" Id="txtDirector"/>
                </td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td style="color: #FFFFFF; background-color: #000000; border-style: groove">Dirección:</td>
                <td> <asp:TextBox runat="server" Id="txtDireccion"/>
                </td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td style="color: #FFFFFF; background-color: #000000; border-style: groove">Contacto:</td>
                <td> <asp:TextBox runat="server" Id="txtContacto"/>
                </td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td style="color: #FFFFFF; background-color: #000000; border-style: groove">Correo:</td>
                <td> <asp:TextBox runat="server" Id="txtCorreo"/>
                </td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td>&nbsp;</td>
                <td> &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
   
    &nbsp;<asp:GridView ID="gvHospital" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnSelectedIndexChanged="gvHospital_SelectedIndexChanged" Width="757px" CssClass="table-responsive table-striped-center">
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
   
    </p>
    </asp:Content>
