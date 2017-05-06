using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RequestClass;

namespace Policlinic_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RepositoryFactory rpFactory = new RepositoryFactory("127.0.0.1", "5432", "Policlinic");
            rpFactory.CloseConnection();
        }
    }
}
