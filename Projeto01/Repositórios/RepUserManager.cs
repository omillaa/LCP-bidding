using Projeto01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Data.SqlTypes;

namespace Projeto01.Repositórios
{
    internal class RepUserManager : InterUserManagerInterface
    {
        public UserManager Get(string email, string senha)
        {
            // Cria o obejto da conexão, define o local da conexão, abre a conexão
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=LocalHost; Database=LCP-bidding;UID=sa;PWD=Ped9922.;";
            conn.Open();

            SqlCommand comand = new SqlCommand();
            comand.Connection = conn;
            comand.CommandText =
                "SELECT * " +
                "FROM Usuarios " +
                "WHERE Email = '" + email + "' and Senha = '" + senha + "'";
            SqlDataReader dr = comand.ExecuteReader();
            List<UserManager> LU = new List<UserManager>();

            UserManager u = null;
            while (dr.Read())
            {
                u = new UserManager();
                u.Nome = dr[1].ToString();
                u.Email= dr[2].ToString();
                u.Senha = dr[3].ToString();
                u.Cadastro = DateTime.Parse(dr[4].ToString());
                LU.Add(u);
            }
            conn.Close();
            return u;
        }

        public UserManager RecuperaEmail(string email)
        {
            // Cria o obejto da conexão, define o local da conexão, abre a conexão
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=LocalHost; Database=LCP-bidding;UID=sa;PWD=Ped9922.;";
            conn.Open();

            SqlCommand comand = new SqlCommand();
            comand.Connection = conn;
            comand.CommandText =
                "SELECT * " +
                "FROM Usuarios " +
                "WHERE Email = '" + email + "'";
            SqlDataReader dr = comand.ExecuteReader();
            List<UserManager> LU = new List<UserManager>();

            UserManager u = null;
            while (dr.Read())
            {
                u = new UserManager();
                u.Nome = dr[1].ToString();
                u.Email = dr[2].ToString();
                LU.Add(u);
            }

            conn.Close();
            return u;
        }
    }
}
