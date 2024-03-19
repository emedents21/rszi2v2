using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using rszi2v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rszi2v2
{
    public partial class RSZIMEDENTSOV : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonPush_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `users` (`Name`, `Surname`) VALUES (@name, @surname);", db.getConnection());
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = FirstNameBox.Text;
            cmd.Parameters.Add("@surname", MySqlDbType.VarChar).Value = SecondNameBox.Text;

            db.OpenConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                Label1.Text = "OK";
            }
            else
            {
                Label1.Text = "NE OK";
            }
            db.ClosedConnection();

        }
    }

}

