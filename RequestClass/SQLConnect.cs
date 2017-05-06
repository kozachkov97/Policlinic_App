using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace RequestClass
{
    public class SQLConnect
    {
        private NpgsqlConnection _conn;
        private static SQLConnect _newConnect = null;

        public SQLConnect(NpgsqlConnection newConn)
        {
            _conn = newConn;
        }

        public SQLConnect GetNewSQLConnection()
        {
            return (_newConnect = new SQLConnect(_conn));
        }

        public NpgsqlConnection GetConnection()
        {
            return _conn;
        }

        public void OpenConnection()
        {
            try
            {
                _conn.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(Convert.ToString(exp));
            }
        }

        public void CloseConnection()
        {
            try
            {
                _conn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(Convert.ToString(exp));
            }
        }
    }
}
