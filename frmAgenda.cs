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

        }
    }
}
