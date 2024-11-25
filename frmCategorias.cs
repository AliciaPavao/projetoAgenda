using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void AtualizaDataGrid()
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string categoria = txtCategoria.Text;
            CategoriaController AddCategoria = new CategoriaController();
            AddCategoria.AddCategoria(categoria);

            AtualizaDataGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codCategoria = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);

            //int Codcategoria = Convert.ToInt32(txtCategoria.Text);
            CategoriaController ExcluirCategoria = new CategoriaController();
            ExcluirCategoria.DelCategoria(codCategoria);

            AtualizaDataGrid();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            int codCategoria = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);
            string categoria = txtCategoria.Text;

            CategoriaController AlterarCategoria = new CategoriaController();
            AlterarCategoria.UpdateCategoria(codCategoria, categoria);

            AtualizaDataGrid();
        }
    }
}
