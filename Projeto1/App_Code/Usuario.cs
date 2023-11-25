using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Model
{
    public class Usuarios
    {
        public string Nome { get; set;  }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Anotacoes { get; set; }
        public Int16 Status { get; set; }
        public string NomeAcesso { get; set; }
        public string Senha { get; set; }

        public static DataTable UsuariosAtivos()
        {
            string comandoSQL = "SELECT Codigo,Nome,Email FROM Usuarios ORDER BY Nome";

            DataBase.Open();
            return (DataTable)DataBase.Command.Query(comandoSQL);
        }
    }
}