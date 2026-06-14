using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Atestat___Spirit_de_Sprieni
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void S(object sender, EventArgs e)
        {
            if(Nume.Text!= "" && Email.Text!= "")
            {
                string connStr = ConfigurationManager
                     .ConnectionStrings["ConexiuneBazaDate"]
                     .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "INSERT INTO Utilizatorii(Nume, Email) VALUES (@Nume, @Email)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nume", Nume.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
               
            }
            }
            Nume.Text = "";
            Email.Text = "";
            Parola.Text = "";

        }
    }
}