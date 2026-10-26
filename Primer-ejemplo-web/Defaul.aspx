<%@ Page Title="" Language="C#" MasterPageFile="~/Mastergrid.Master" AutoEventWireup="true" CodeBehind="Defaul.aspx.cs" Inherits="Primer_ejemplo_web.Defaul" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .oculto{
            display:none;
        }
    </style>
    <hr />
    <asp:GridView OnSelectedIndexChanged="dgvDirecciones_SelectedIndexChanged" runat="server" DatakeyNames="id" ID="dgvDirecciones" CssClass ="table table-dark table-striped-columns" AutoGenerateColumns="false" >
        <Columns>
            <%--Con oculto , ocultamos la columna con su cabecera y sus datos para q no se dibujen en el html--%>
            <%--<asp:BoundField headertext="id" DataField="id" headerstyle-cssClass="oculto" ItemStyle-cssClass="oculto" />--%>
           <asp:BoundField headertext="Calle" DataField="Calle" />
           <asp:BoundField HeaderText="altura" DataField="altura" />
           <asp:BoundField HeaderText="Habitantes" DataField="habitantes" />
           <asp:CheckBoxField HeaderText="visitado" DataField="visitado" />
            <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Accion" />
            
        </Columns>      
    </asp:GridView>
    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Articulo" OnClick="Button1_Click"  CssClass="btn btn-primary"/>
<a     
</asp:Content>
