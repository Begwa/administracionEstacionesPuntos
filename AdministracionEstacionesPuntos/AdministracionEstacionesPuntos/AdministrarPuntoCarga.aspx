<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministrarPuntoCarga.aspx.cs" Inherits="AdministracionEstacionesPuntos.AdministrarPuntoCarga" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="card">
        <div class="card-header bg-primary text-white">
            Agregar Nuevo Punto De Carga
        </div>
        <div class="card-body">
            <div class="form-group">
                <label for="idTxt">ID De Punto De Carga</label>
                <asp:TextBox ID="idTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFielValidator1" runat="server" ErrorMessage="Debe Ingresar Un ID Valido" CssClass="text-danger" ControlToValidate="idTxt"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="tipoDdl">Tipo De Punto De Carga</label>
                <asp:DropDownList ID="tipoDdl" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="capacidadMaxTxt">Capacidad Maxima Del Punto De Carga</label>
                <asp:TextBox ID="capacidadMaxTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe Ingresar Una Capacidad Maxima Valida" CssClass="text-danger" ControlToValidate="capacidadMaxTxt"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="fechaTxt">Fecha De Vencimiento Del Punto De Carga</label>
                <asp:TextBox ID="fechaTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe Ingresar Una Fecha De Vencimiento Valida" CssClass="text-danger" ControlToValidate="fechaTxt"></asp:RequiredFieldValidator>
            </div>

        </div>

        <asp:Button ID="IngresarBtn" runat="server" Text="Agregar Punto De Carga" CssClass="btn btn-dark" OnClick="IngresarBtn_Click" />

        </div>

</asp:Content>
