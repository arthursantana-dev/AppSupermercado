using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSupermercado
{
    public partial class Supermercado : Form
    {
        double valorTotal = 0;
        public Supermercado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtProduto.Text
                = string.Empty;
            txtQuantidade.Text = string.Empty; 
            txtValorUnit.Text = string.Empty;

            lstProdutos.Items.Clear();

            lblTotal.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            int quantidade = int.Parse(txtQuantidade.Text);
            double valorUnitario = double.Parse(txtValorUnit.Text);

            string listInput = $"{produto} - {quantidade} - {valorUnitario}";

            lstProdutos.Items.Add(listInput);

            valorTotal += quantidade * valorUnitario;
            lblTotal.Text = valorTotal.ToString("C");

        }
    }
}
