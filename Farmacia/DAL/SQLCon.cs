using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class SQLCon {
        public SqlConnection con;
        public SqlCommand cmd;
        public SQLCon() {
            con = new SqlConnection("Server=DESKTOP-HB8K8AS\\MSSQLSERVER01;Database=farmacia;Trusted_Connection=True;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public SQLCon(string con) : this() {
            this.con = new SqlConnection(con);
        }
        public void exec_command() {
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
