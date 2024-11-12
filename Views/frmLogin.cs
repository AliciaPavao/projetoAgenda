namespace ProjetoAgenda
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void habilitarBotaoLogin()
        {
            // Se o Usu�rio for diferente de vazio e a quantidade de caracteres na Senha for maior ou igual a 8, habilita  o bot�o de login
            if (txtUsuario.Text != "" && txtSenha.Text.Length >= 8)
            {
                btnLogar.Enabled = true;
            }
            else
            {
                btnLogar.Enabled = false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCadastro formularioCadastro = new frmCadastro();
            formularioCadastro.ShowDialog();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmPrincipal Principal = new frmPrincipal();
            Principal.ShowDialog();

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
