<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Historias.aspx.cs" Inherits="Cliente_CSharp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="color: #FFFFFF; background-color: #000000"><%: Title %>Lista de Historias Clinicas</h2>

    <h3>&nbsp;</h3>
    <p>
        <asp:GridView ID="gvHistoriasClinicas" class="*" runat="server"  AutoGenerateColumns="False" DataKeyNames="idH" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="gvHistoriasClinicas_SelectedIndexChanged" BorderStyle="Solid" AllowPaging="True" AllowSorting="True" BackColor="#CCCCCC" BorderColor="#999999" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black " CssClass="table-responsive-center" >

            <Columns>
                <asp:BoundField DataField="idH" HeaderText="idH" ReadOnly="True" SortExpression="idH" />
                <asp:BoundField DataField="detalle" HeaderText="detalle" SortExpression="detalle" />
                <asp:BoundField DataField="nroExpediente" HeaderText="nroExpediente" SortExpression="nroExpediente" />
                <asp:BoundField DataField="Antecedente" HeaderText="Antecedente" SortExpression="Antecedente" />
                <asp:BoundField DataField="peso" HeaderText="peso" SortExpression="peso" />
                <asp:BoundField DataField="talla" HeaderText="talla" SortExpression="talla" />
                <asp:BoundField DataField="motivoConsulta" HeaderText="motivoConsulta" SortExpression="motivoConsulta" />
                <asp:BoundField DataField="sintomas" HeaderText="sintomas" SortExpression="sintomas" />
                <asp:BoundField DataField="adicciones" HeaderText="adicciones" SortExpression="adicciones" />
                <asp:BoundField DataField="procedimiento" HeaderText="procedimiento" SortExpression="procedimiento" />
                <asp:BoundField DataField="idP" HeaderText="idP" SortExpression="idP" />
                <asp:BoundField DataField="idD" HeaderText="idD" SortExpression="idD" />
                <asp:BoundField DataField="idU" HeaderText="idU" SortExpression="idU" />
                <asp:BoundField DataField="idHo" HeaderText="idHo" SortExpression="idHo" />
                <asp:BoundField DataField="fechaRegistro" HeaderText="fechaRegistro" SortExpression="fechaRegistro" />
            </Columns>
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBClinicaConnectionString %>" SelectCommand="SELECT * FROM [THistoria]"></asp:SqlDataSource>
    </p>
    <p>&nbsp;</p>
</asp:Content>
