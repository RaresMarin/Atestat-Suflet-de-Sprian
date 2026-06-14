<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Atestat___Spirit_de_Sprieni.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Conectare</h1>
<div style="display:grid;grid-template-rows:repeat(1,1fr)">
<asp:Label runat="server" CssClass="l">Nume</asp:Label>
<asp:TextBox ClientIDMode="Static" ID="Nume" runat="server"></asp:TextBox>
<asp:Label runat="server" CssClass="l">Email</asp:Label>
<asp:TextBox ClientIDMode="Static" ID="Email" runat="server"></asp:TextBox>
<asp:Label runat="server" CssClass="l">Parola</asp:Label>
<asp:TextBox ClientIDMode="Static" ID="Parola" runat="server" TextMode="Password"></asp:TextBox>
<asp:Button ClientIDMode="Static" ID="Salveaza"
            runat="server"
            Text="Salvează"
            OnClick="S" />
    </div>
</asp:Content>
