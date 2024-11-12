namespace ProjetoAgenda
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtTelefone = new TextBox();
            label5 = new Label();
            txtRepeteSenha = new TextBox();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            txtNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCCadastrar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtRepeteSenha);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 323);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(19, 159);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(325, 23);
            txtTelefone.TabIndex = 9;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 141);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "Telefone";
            label5.Click += label5_Click;
            // 
            // txtRepeteSenha
            // 
            txtRepeteSenha.Location = new Point(19, 265);
            txtRepeteSenha.Name = "txtRepeteSenha";
            txtRepeteSenha.Size = new Size(325, 23);
            txtRepeteSenha.TabIndex = 7;
            txtRepeteSenha.TextChanged += txtRepeteSenha_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(19, 210);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(325, 23);
            txtSenha.TabIndex = 6;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(19, 105);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(325, 23);
            txtUsuario.TabIndex = 5;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(19, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(325, 23);
            txtNome.TabIndex = 4;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 247);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 3;
            label4.Text = "Repita a senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 192);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 87);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // btnCCadastrar
            // 
            btnCCadastrar.BackColor = Color.Khaki;
            btnCCadastrar.FlatStyle = FlatStyle.Flat;
            btnCCadastrar.Location = new Point(21, 358);
            btnCCadastrar.Name = "btnCCadastrar";
            btnCCadastrar.Size = new Size(165, 50);
            btnCCadastrar.TabIndex = 1;
            btnCCadastrar.Text = "Cadastrar";
            btnCCadastrar.UseVisualStyleBackColor = false;
            btnCCadastrar.Click += btnCCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Khaki;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(219, 358);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(165, 50);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(414, 428);
            Controls.Add(btnCancelar);
            Controls.Add(btnCCadastrar);
            Controls.Add(groupBox1);
            Name = "frmCadastro";
            Text = "Form1";
            Load += frmCadastro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtRepeteSenha;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCCadastrar;
        private Button btnCancelar;
        private TextBox txtTelefone;
        private Label label5;
        private Button button1;
    }
}