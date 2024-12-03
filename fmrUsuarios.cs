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
    public partial class fmrUsuarios : Form
    {
        public fmrUsuarios()
        {
            InitializeComponent();
        }

        private void atualiza_tabela()
        {
            UsuarioController atualizaTabela = new UsuarioController();
            DataTable tabela = atualizaTabela.GetUsuarios();
            dgvUsers.DataSource = tabela;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string usuario = Convert.ToString(dgvUsers.SelectedRows[0].Cells[0].Value);
            UsuarioController RemoveUser = new UsuarioController();
            RemoveUser.DelUsuario(usuario);
            atualiza_tabela();
        }

        private void fmrUsuarios_Load(object sender, EventArgs e)
        {
            atualiza_tabela();
        }

        private void fmrUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void fmrUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnAlterasenha_Click(object sender, EventArgs e)
        {
            string senha = txtNovaSenha.Text;
            string usuario = Convert.ToString(dgvUsers.SelectedRows[0].Cells[0].Value);
            UsuarioController updateSenha = new UsuarioController();
            updateSenha.UpdateSenha(usuario, senha);
        }
    }
}
