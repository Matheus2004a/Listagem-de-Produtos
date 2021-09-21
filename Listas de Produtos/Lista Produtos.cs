using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class form_Listagem : Form
    {
        public form_Listagem()
        {
            InitializeComponent();
        }

        private void btnAdicionaProduto_Click(object sender, EventArgs e)
        {
            if (nomeProduto.Text == "")
            {
                MessageBox.Show("Digite o nome de um produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                cmb_ListaProdutos.Items.Add(nomeProduto.Text);
                MessageBox.Show("Produto listado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nomeProduto.Clear();
                nomeProduto.Focus();
            }
        }

        private void btnLimpaProduto_Click(object sender, EventArgs e)
        {
            if (nomeProduto.Text == "")
            {
                MessageBox.Show("Digite o nome de um produto para limpar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                nomeProduto.Clear();
                nomeProduto.Focus();
            }
        }

        private void btnRemoveProduto_Click(object sender, EventArgs e)
        {
            if (cmb_ListaProdutos.Text == "")
            {
                MessageBox.Show("Digite o nome de um produto para removê-lo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                cmb_ListaProdutos.Items.Remove(cmb_ListaProdutos.SelectedItem);
                MessageBox.Show("Produto removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nomeProduto.Focus();
            }
        }

        private void form_Listagem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair do formulário?","Mensagem", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
