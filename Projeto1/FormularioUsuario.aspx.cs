using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto1
{
    public partial class FormularioUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ExibirUsuarios();
            }
        }

        protected void ExibirUsuarios()
        {
            ListaUsuarios.DataSource = Usuarios.UsuariosAtivos();
            ListaUsuarios.DataBind();
        }


        protected void Salvar_Click(object sender, EventArgs e)
        {
            if (Nome.Text.Trim() == "") {
                MsgError.Text = "Digite o nome!"; 
            }
            else if (Email.Text.Trim() == "") {
                MsgError.Text = "Digite o Email!";
            }
            else if (Telefone.Text.Trim() == "")
            {
                MsgError.Text = "Digite o Telefone!";
            }
            else if (Anotacoes.Text.Trim() == "")
            {
                MsgError.Text = "Digite uma Anotação!";
            }
            else if (Senha.Text.Trim() == "")
            {
                MsgError.Text = "Digite uma Senha!";
            }
            else if (NomeAcesso.Text.Trim() == "")
            {
                MsgError.Text = "Digite os Nome de Acesso!";
            }
            else
            {
                Model.Usuarios usuario = new Model.Usuarios();
                usuario.Nome = Nome.Text.Trim();
                usuario.Email = Email.Text.Trim();
                usuario.Telefone = Telefone.Text.Trim();
                usuario.Anotacoes = Anotacoes.Text.Trim();
                usuario.NomeAcesso = NomeAcesso.Text.Trim();
                usuario.Senha = Senha.Text.Trim();
                usuario.Status = Convert.ToInt16(Status.Text);

                DataBase.Open();

                if (Codigo.Text == "")
                {
                    DataBase.Command.Insert(usuario, "Codigo");
                }
                else
                {
                    DataBase.Command.Update(usuario, "Codigo", Codigo.Text);
                }
                ExibirUsuarios();
                LimparDados();
            }
        }
        protected void LimparDados()
        {
            Codigo.Text = "";
            Nome.Text = "";
            Email.Text = "";
            Telefone.Text = "";
            Anotacoes.Text = "";
            NomeAcesso.Text = "";
            Senha.Text = "";
            Excluir.Visible = false;
            Salvar.Text = "Inserir";
        }
        protected void Excluir_Click(object sender, EventArgs e)
        {
            string comandoSql = "DELETE FROM Usuarios WHERE Codigo=" + Codigo.Text;

            DataBase.Open();
            DataBase.Command.Query(comandoSql);
            LimparDados();
            ExibirUsuarios();

        }

        protected void ListaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Codigo.Text = ListaUsuarios.SelectedRow.Cells[1].Text;

            string comandoSql = "SELECT * FROM Usuarios WHERE Codigo=" + Codigo.Text;

            DataBase.Open();
 
            DataTable tb = (DataTable)DataBase.Command.Query(comandoSql);

            if (tb.Rows.Count > 0)
            {
                Nome.Text = tb.Rows[0]["Nome"].ToString();
                Email.Text = tb.Rows[0]["Email"].ToString();
                Telefone.Text = tb.Rows[0]["Telefone"].ToString();
                Anotacoes.Text = tb.Rows[0]["Anotacoes"].ToString();
                NomeAcesso.Text = tb.Rows[0]["NomeAcesso"].ToString();
                Senha.Text = tb.Rows[0]["Senha"].ToString();
                Status.SelectedValue = tb.Rows[0]["Status"].ToString();

            }

            Excluir.Visible = true;
        
        }
    }
}