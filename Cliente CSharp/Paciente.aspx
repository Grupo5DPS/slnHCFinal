<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paciente.aspx.cs" Inherits="Cliente_CSharp.Escuela" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="background-color: #000000; color: #FFFFFF">Formulario Pacientes</h1>
    Ingrese los campos para registrar a su paciente:
<br />
    <br />
        <table style="width:46%;">
            <tr>
                <td style="border-style: inset; background-color: #333333; list-style-type: square; color: #FFFFFF;">ID:</td>
                <td> <asp:TextBox runat="server" Id="txtId"/>
                </td>
                  <td>
                    <asp:Button ID="btnAgregar" runat="server" OnClick="Button1_Click1" Text="Agregar Paciente" CssClass="bg-primary" />
                </td>
            <tr>
                <td style="border-style: inset; background-color: #333333; list-style-type: square; color: #FFFFFF;">Nombre</td>
                <td> <asp:TextBox runat="server" Id="txtNombre"/>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="border-style: inset; background-color: #333333; list-style-type: square; color: #FFFFFF;">Apellidos</td>
                <td> <asp:TextBox runat="server" Id="txtApellidos"/>
                </td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td style="border-style: inset; background-color: #333333; list-style-type: square; color: #FFFFFF;">Fecha Nacimiento</td>
                <td> <asp:TextBox runat="server" Id="txtFechaNac"/>
                </td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td style="border-style: inset; background-color: #333333; list-style-type: square; color: #FFFFFF;">Sexo</td>
                <td> <asp:TextBox runat="server" Id="txtSexo"/>
                </td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td style="border-style: inset; background-color: #333333; list-style-type: square; color: #FFFFFF;">Estado Civil</td>
                <td> <asp:TextBox runat="server" Id="txtEstadoCivil"/>
                </td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td style="border-style: inset; background-color: #333333; list-style-type: square; color: #FFFFFF;">Ocupación</td>
                <td> <asp:TextBox runat="server" Id="txtOcupacion"/>
                </td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td style="border-style: inset; background-color: #333333; list-style-type: square; color: #FFFFFF;">Dirección</td>
                <td> <asp:TextBox runat="server" Id="txtDireccion"/>
                </td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td style="border-style: inset; background-color: #333333; list-style-type: square; color: #FFFFFF;">Teléfono</td>
                <td> <asp:TextBox runat="server" Id="txtTelefono"/>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
   
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="gvPaciente"  runat="server" Height="139px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="819px" CssClass="table-responsive table-striped center">
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
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <br />
</asp:Content>
