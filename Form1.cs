using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Forms1 : Form
    {
        public Forms1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //verificar se produto txbProduto está vazio:
            if(txbproduto.Text.Length == 0)
            {
                MessageBox.Show("O nome do produto não pode estar vazio!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mudar a cor do fundo e a cor da letra:
                txbproduto.BackColor = Color.Red;
                txbproduto.ForeColor = Color.Black;
            }
            else if(txbproduto.Text.Length < 2)
            {
                MessageBox.Show("O nome do produto precisa ter no minimo duas letras!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // verificar se o item esta na lista
                if (libCompras.Items.Contains(txbproduto.Text))
                {
                    MessageBox.Show("O nome do produto não pode estar vazio!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    //Adicionar o item, na lista:
                    libCompras.Items.Add(txbproduto.Text);
                    MessageBox.Show($"{txbproduto.Text} foi adicionado na lista de compras!",
                        "show!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //retornar o txbproduto para a cor normal:
                    txbproduto.BackColor = Color.White;
                    txbproduto.ForeColor = Color.Black;

                    //limpar o campo:
                    txbproduto.Text = "";
                }

            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Tem certeza deseja apagar tudo?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //se optar por sim, apagar:
            if (Resposta == DialogResult.Yes)
            {
                libCompras.Items.Clear();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //verificar se o usuario não selecionoi nada:
            if(libCompras.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um item para remover!", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {
                //salvar temporariamente o nome do item que será removido:
                string itemremovido = libCompras.SelectedItem.ToString();
                //remover item selecionado:
                libCompras.Items.Remove(libCompras.SelectedIndex);
                MessageBox.Show($"{itemremovido}O item foi removido da lista!",
                    "show!", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void txbproduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //"Pressionar" o btnAdicionar:
                btnAdicionar.PerformClick();
            }
        }
    }
}
