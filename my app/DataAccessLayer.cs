using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_app
{
    class DataAccessLayer
    {
  
          private static string dbPath = Application.StartupPath + "\\" + "MANSMS,DATABASE.mdb";

        public static DataTable GetRecords(string qry)
        {
            OleDbConnection oledbconnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath);
            oledbconnection.Open();

            OleDbCommand oledbcommand = new OleDbCommand(qry, oledbconnection);

            var dt = new DataTable();
            dt.Load(oledbcommand.ExecuteReader());

            oledbconnection.Close();
            return dt;
        }

        public static void ExecuteNonQuery(string qry)
        {
            OleDbConnection oledbconnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath);
            oledbconnection.Open();
            
            OleDbCommand oledbcommand = new OleDbCommand(qry, oledbconnection);
            oledbcommand.CommandType = CommandType.Text;
            oledbcommand.ExecuteNonQuery();

        }

       

        internal static object GetRecords(Action Update)
        {
            throw new NotImplementedException();
        }
    }

}
