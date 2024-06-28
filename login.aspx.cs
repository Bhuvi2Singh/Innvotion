using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Inception
{
    public partial class Login : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            conn = new MySqlConnection(connectionString);
            conn.Open();

        }
    }
}