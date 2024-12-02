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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }
        private void AtualizaDataGrid()
        {
            ContatoController controleContato = new ContatoController();
            DataTable tabela = controleContato.GetContatos();
            dgvContatos.DataSource = tabela;
        }

        private void lbltelefone_Click(object sender, EventArgs e)
        {

        }

        private void frmAgenda_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            cmbCategoria.DataSource = tabela;
            cmbCategoria.DisplayMember = "categoria";

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string contato = txtcontato.Text;
            string telefone = txttelefone.Text;
            string categoria = cmbCategoria.Text;
            ContatoController AddContato = new ContatoController();
            AddContato.AddContato(contato, telefone, categoria);

            AtualizaDataGrid();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            int codContato = Convert.ToInt32(dgvContatos.SelectedRows[0].Cells[0].Value);

            //int Codcontatos = Convert.ToInt32(txtCategoria.Text);
            ContatoController ExcluirContato = new ContatoController();
            ExcluirContato.DelContato(codContato);

            AtualizaDataGrid();
        }
    }
}
