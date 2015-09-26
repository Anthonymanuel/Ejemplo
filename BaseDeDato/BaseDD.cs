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

namespace BaseDeDato
{
    public partial class BaseDeDato : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=Noel\\SQLEXPRESS;Initial Catalog=Ejemplo; Integrated security=true");

        public BaseDeDato()
        {
            InitializeComponent();
        }

        private void mostrarButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Ejemplo_Load(object sender, EventArgs e)
        {
            cn.Open();
            if (cn != null)
                estadoLabel.Text = "Conectado";
            else
                estadoLabel.Text = "Desconectado";
        }

       
    }
}
