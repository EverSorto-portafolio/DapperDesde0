using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperDemo
{
    public partial class Form1 : Form
    {
        CustomerRepository customerR = new CustomerRepository();

        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnObtenerTodos_Click(object sender, EventArgs e)
        {
            var cliente = customerR.ObtenerTodos();
            dgvCustomers.DataSource = cliente;  
        }

        private void btnObtenerId_Click(object sender, EventArgs e)
        {
            var cliente = customerR.ObtenerPorID(tboxOBtenerID.Text);
             dgvCustomers.DataSource = new List<Customers> { cliente };
        }
    }
}
