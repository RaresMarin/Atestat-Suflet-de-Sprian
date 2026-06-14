<%@ Page Title="Evenimente" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Evenimente.aspx.cs" Inherits="Atestat___Spirit_de_Sprieni.Evenimente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>Activitati Culturale</h1>
    <div runat="server" class="a">
        <div ClientIdMode="Static" id="fanfara"  runat="server">
            <div style="backdrop-filter:blur(20px);">
            <h2 runat="server">Defilarea Fanfarii</h2>
            <p runat="server">1 mai</p>
            <asp:Button ClientIdMode="Static" ID="b1" runat="server" Text="Află mai multe" OnClick="Button"></asp:Button>
            <p runat="server" id="p1"></p>
            <address>Mai sunt <span runat="server" id="data1"></span> zile până la eveniment</address>
                </div>
        </div>
        <div ClientIdMode="Static" id="miner"  runat="server">
                    <div style="backdrop-filter:blur(20px);">
    <h2 runat="server">Ziua Minerului</h2>
    <p runat="server">15 august</p>
    <asp:Button ClientIdMode="Static" ID="b2" runat="server" Text="Află mai multe" OnClick="Button1"></asp:Button>
    <p runat="server" id="p2"></p>
    <address>Mai sunt <span runat="server" id="data2"></span> zile până la eveniment</address>
</div>
</div>
        <div ClientIdMode="Static" id="colinde"  runat="server">
            <div style="backdrop-filter:blur(20px);">
    <h2 runat="server">Evenimentul „Obiceiuri si Datini de Craciun”</h2>
    <p runat="server">7 decembrie</p>
    <asp:Button ClientIdMode="Static" ID="b3" runat="server" Text="Află mai multe" OnClick="Button2"></asp:Button>
    <p runat="server" id="p3"></p>
    <address>Mai sunt <span runat="server" id="data3"></span> zile până la eveniment</address>
</div>
</div>
                    <div ClientIdMode="Static" id="Div1"  runat="server">
            <div style="backdrop-filter:blur(20px);">
    <h2 runat="server">Expozitiei „Din suflet spre lume”</h2>
    <p runat="server">18 mai</p>
    <asp:Button ClientIdMode="Static" ID="b4" runat="server" Text="Află mai multe" OnClick="Button3"></asp:Button>
    <p runat="server" id="p4"></p>
    <address>Mai sunt <span runat="server" id="Span1"></span> zile până la eveniment</address>
</div>
</div>
                                <div ClientIdMode="Static" id="Div2"  runat="server">
            <div style="backdrop-filter:blur(20px);">
    <h2 runat="server"> Ziua Lacului Albastru</h2>
    <p runat="server">7 iunie</p>
    <asp:Button ClientIdMode="Static" ID="b5" runat="server" Text="Află mai multe" OnClick="Button4"></asp:Button>
    <p runat="server" id="p5"></p>
    <address>Mai sunt <span runat="server" id="Span2"></span> zile până la eveniment</address>
</div>
</div>
                                            <div ClientIdMode="Static" id="Div3"  runat="server">
            <div style="backdrop-filter:blur(20px);">
    <h2 runat="server">Tabara Practica de Olarit</h2>
    <p runat="server">13 iulie</p>
    <asp:Button ClientIdMode="Static" ID="b6" runat="server" Text="Află mai multe" OnClick="Button5"></asp:Button>
    <p runat="server" id="p6"></p>           
    <address>Mai sunt <span runat="server" id="Span3"></span> zile până la eveniment</address>
</div>
</div>

</div>
</asp:Content>
