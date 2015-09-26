using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=Noel\\SQLEXPRESS;Initial Catalog=Ejemplo; Integrated security=true");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn.Open();
            if (cn != null)
                estadoLabel.Text = "Conectado";
            else
                estadoLabel.Text = "Desconectado";
        }
    }
}
