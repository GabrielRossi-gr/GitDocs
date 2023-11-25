<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="FormularioUsuario.aspx.cs" Inherits="Projeto1.FormularioUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    
    <div class="margin-top-60">
        <div class="row">
            <div class="col-4">
                <div class="box border margin-right-20">
                    <h2>Formulario</h2>

                    <asp:Label ID="MsgError" ForeColor="Red" runat="server"></asp:Label>
                    <br />

                    <asp:Label ID="Codigo" runat="server" Font-Size="20px"></asp:Label>

                    <br />
                    <label>Nome Completo</label>
                    <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
                    <br />

                    <label>E-mail</label>
                    <asp:TextBox ID="Email" runat="server" TextMode="Email"></asp:TextBox>
                    <br />

                    <label>Telefone</label>
                    <asp:TextBox ID="Telefone" MaxLenght="9" runat="server"></asp:TextBox>
                    <br />

                    <label>Anotações</label>
                    <asp:TextBox ID="Anotacoes" MaxLenght="255" runat="server"></asp:TextBox>
                    <br />

                    <label>Status</label>
                    <asp:DropDownList ID="Status" runat="server">
                        <asp:ListItem Value="0">Ativo</asp:ListItem>
                        <asp:ListItem Value="-1">Inativo</asp:ListItem>
                    </asp:DropDownList>

                    <label>Nome Acesso</label>
                    <asp:TextBox ID="NomeAcesso" MaxLenght="15" runat="server"></asp:TextBox>
                    <br />

                    <label>Senha</label>
                    <asp:TextBox ID="Senha" MaxLenght="15" runat="server" TextMode="Password"></asp:TextBox>
                    <br />

                    <asp:Button ID="Salvar" OnClick="Salvar_Click" runat="server" Text="Salvar" />
                    <asp:Button Visible="false" CssClass="botao-delete" ID="Excluir" OnClick="Excluir_Click" runat="server" Text="Excluir" />
                </div>
            </div>

            <div class="col-4">
                <div class="box border">
                    <asp:GridView AutoGenerateSelectButton="true" OnSelectedIndexChanged="ListaUsuarios_SelectedIndexChanged" ID="ListaUsuarios" Width="100%" CellPadding="6" runat="server"></asp:GridView>
                    
                </div>
            </div>



        </div>
    </div>


</asp:Content>
