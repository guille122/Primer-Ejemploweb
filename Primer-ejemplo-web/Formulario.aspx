<%@ Page Title="" Language="C#" MasterPageFile="~/Mastergrid.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Primer_ejemplo_web.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">ID</label>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Label runat="server" ID="lblError" Text=""></asp:Label>
            </div>
            <div class="mb-3">
                <label for="txtAltura" class="form-label">Altura</label>
                <asp:TextBox ID="txtAltura" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Label runat="server" ID="lblErrorAltura" Text=""></asp:Label>
            </div>
            <div class="mb-3">
                <label for="txtDireccion" class="form-label">Calle</label>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="dropList">Cantidad de Habitantes</label>
                <br />
                <asp:DropDownList ID="dropList" runat="server"></asp:DropDownList>
            </div>
            <asp:CheckBox runat="server" ID="chkVisitado" Text="" />
            <asp:Label runat="server" Text="Visitado" CssClass="form-check-label"></asp:Label>
            <%if (Request.QueryString["id"] == null)
                { %>
                <div class="mb-3">
                    <asp:Button runat="server" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" Text="Aceptar" />
                    <a href="Defaul.aspx">Cancelar</a>
                </div>
            <%}
                else
                { %>
                 <div class="mb-3">
                   <asp:Button runat="server" ID="btnActualizar" CssClass="btn btn-primary" onclick="btnActualizar_Click" Text="Actualizar" />
                    <asp:Button runat="server" ID="btnEliminar" CssClass="btn btn-primary" OnClick="btnEliminar_Click" Text="Eliminar" />
                    <a href="Defaul.aspx">Cancelar</a>
                 </div>    
              <%} %>    

        </div>
    </div>
</asp:Content>
