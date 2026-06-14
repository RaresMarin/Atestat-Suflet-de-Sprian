<%@ Page Title="Trasee" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Trasee.aspx.cs" Inherits="Atestat___Spirit_de_Sprieni.Trasee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Calatorii</h1>
    <div style="text-align:center;">
    <h2>Alege un loc de vizitat pentru mine aleatoriu</h2>
    <h2 runat="server" id="H1"></h2>
    <asp:Image ClientIdMode="Static" runat="server" id="Image1"></asp:Image>
    <p runat="server" id="p1"></p>
    <asp:Button ClientIdMode="Static" id="b4" runat="server" Text="Alege" OnClick="Unnamed_Click1"></asp:Button>
    </div>
</asp:Content>
