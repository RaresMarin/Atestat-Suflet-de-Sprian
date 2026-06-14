<%@ Page Title="Monumente" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Monumente.aspx.cs" Inherits="Atestat___Spirit_de_Sprieni.Monumente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <h1>Galerie</h1>
    <div ClientIDMode="Static" runat="server" id="gs">
        <button type="button" onclick="Inainte(-1)">&lt;</button>
        <img src="/imagine/a2.jpeg" ClientIDMode="Static" runat="server" ID="Galerie" alt="Galerie" />
        <button type="button" onclick="Inainte(1)">&gt;</button>
    </div>
    <p runat="server" ClientIDMode="Static" id="text"></p>
        <script src="script.js"></script>
</asp:Content>
