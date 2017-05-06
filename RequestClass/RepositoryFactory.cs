using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace RequestClass
{
    public class RepositoryFactory
    {
        private NpgsqlConnection npgsql;
        private SQLConnect sqlConnect;

        public RepositoryFactory(string server, string port, /*string userId, string password,*/ string database)
        {
            npgsql = new NpgsqlConnection("Server=" + server +
                                            "; Port=" + port +
                                            /*"; User Id=" + userId +
                                            "; Password=" + password +*/
                                            "; Database=" + database);
            sqlConnect = new SQLConnect(npgsql);
            OpenConnection();
            MessageBox.Show("Connection opened");
        }

        public void OpenConnection()
        {
            sqlConnect.GetNewSQLConnection().OpenConnection();
        }

        public void CloseConnection()
        {
            sqlConnect.GetNewSQLConnection().CloseConnection();
        }
    }
}
