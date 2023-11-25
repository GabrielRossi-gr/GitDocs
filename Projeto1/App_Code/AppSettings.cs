using System.Web;
using Datapost.DB;
public class DataBase
{
    // DAO (Data Access Object) pertence a biblioteca Datapost.Access e contém os métodos para INSERT, UPDATE, DELETE e SELECT no banco de dados Access. 
    public static DAO Command = new DAO();
    // UTIL (Utilities) são métodos utilizados em tabela de banco de dados para criptografar, filtar injeção de sql, etc. 
    public static UTIL Utilities = new UTIL();

    /// <summary>
    /// Método para conectar o DAO ao banco de dados "Access".
    /// </summary>
    public static void Open()
    {
        // provedor de banco de dados Access
        Command.DataProviderName = DAO.ProviderName.OleDb;
        // string de conexão com o banco de dados Access
        // ref: https://www.connectionstrings.com
        Command.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/DB2023.accdb") + ";Persist Security Info=False;";
    }

}
