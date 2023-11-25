<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto1.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Neste local são colocados "META DADOS" ou links para arquivos JavaScript ou css -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">

    <!-- Neste local são colocados os conteúdos para exibir no browse -->
    <!-- Place somewhere in the <body> of your page -->
    <div class="flexslider">
        <ul class="slides">
            <li>
                <img src="images/banner0.png" />
            </li>

            <li>
                <img src="images/banner1.png" />
            </li>

            <li>
                <img src="images/banner2.png" />
            </li>

            <li>
                <img src="images/banner3.png" />
            </li>

            <li>
                <img src="images/banner4.png" />
            </li>
        </ul>
    </div>

    <script>
        // Can also be used with $(document).ready()
        $(window).load(function () {
            $('.flexslider').flexslider({
                animation: "slide"
            });
        });
    </script>

    <!-- Dividir em colunas com display: flex -->
    <div class="row margin-top-60">

        <div class="col-3">
            <div class="box margin-right-20">
                <img width="100%" src="images/si1.png" />
                <br />
                <h3>Analise de Sistemas</h3>
                <p>
                    Faça perguntas reais. Converse e crie. Receba respostas melhores de seu copiloto com tecnologia de IA para web.
                </p>
            </div>
        </div>

        <div class="col-3">
            <div class="box margin-right-20">
                <img width="100%" src="images/si2.jpg" />
                <br />
                <h3>Video aulas</h3>
                <p>
                    Faça perguntas reais. Converse e crie. Receba respostas melhores de seu copiloto com tecnologia de IA para web.
                </p>
            </div>
        </div>

        <div class="col-3">
            <div class="box margin-right-20">
                <img width="100%" src="images/si3.jpg" />
                <br />
                <h3>Perguntas Frequentes</h3>
                <p>
                    Faça perguntas reais. Converse e crie. Receba respostas melhores de seu copiloto com tecnologia de IA para web.
                </p>
            </div>
        </div>

        <div class="col-3">
            <div class="box">
                <img width="100%" src="images/si4.jpg" />
                <br />
                <h3>Consultoria</h3>
                <p>
                    Faça perguntas reais. Converse e crie. Receba respostas melhores de seu copiloto com tecnologia de IA para web.
                </p>
            </div>
        </div>

    </div>

</asp:Content>

