using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Pollux.DataBase
{
    static public partial class SqlDataProvider
    {
        static public OleDbConnection connect;

        static public bool DBConnect()
        {
            try
            {
                connect = new OleDbConnection(@"Provider=SQLOLEDB;Data Source=localhost;Integrated Security=SSPI;Initial Catalog=CASTORFINDER");
                connect.Open();
                return (connect.State == ConnectionState.Open);
            }
            catch (Exception)
            {
                MessageBox.Show("erreur connexion BdD","Attention");
                return false;
            }
        }


       

    }
}
