<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministrarEstacionServicio.aspx.cs" Inherits="AdministracionEstacionesPuntos.AdministrarEstacionServicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="card">
        <div class="card-header bg-primary text-white">
            Agregar Nueva Estacion de Servicio
        </div>
        <div class="card-body">
            <div class="form-group">
                <label for="nombreTxt">Nombre De La Estacion De Servicio</label>
                <asp:TextBox ID="nombreTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFielValidator1" runat="server" ErrorMessage="Debe Ingresar Un Nombre Valido" CssClass="text-danger" ControlToValidate="nombreTxt"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="direccionTxt">Direccion De La Estacion De Servicio</label>
                <asp:TextBox ID="direccionTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFiedValidator1" runat="server" ErrorMessage="Debe Ingresar Una Direccion Valida" CssClass="text-danger" ControlToValidate="direccionTxt"></asp:RequiredFieldValidator>
            </div>
             <div class="form-group">
                <label for="codigoTxt">Codigo De La Estacion De Servicio</label>
                <asp:TextBox ID="codigoTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe Ingresar Un Codigo Valido" CssClass="text-danger" ControlToValidate="codigoTxt"></asp:RequiredFieldValidator>
            </div>
             <div class="form-group">
                <label for="capacidadTxt">Capacidad Maxima De La Estacion De Servicio</label>
                <asp:TextBox ID="capacidadTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe Ingresar Una Capacidad Maxima Valida" CssClass="text-danger" ControlToValidate="capacidadTxt"></asp:RequiredFieldValidator>
            </div>

        </div>

        <asp:Button ID="AgregarBtn" runat="server" Text="Agregar Estacion" CssClass="btn btn-dark" OnClick="AgregarBtn_Click" />

    </div>

</asp:Content>
