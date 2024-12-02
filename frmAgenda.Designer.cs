namespace ProjetoAgenda
{
    partial class frmAgenda
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
            gbAgenda = new GroupBox();
            cmbCategoria = new ComboBox();
            btnsair = new Button();
            lblcategoria = new Label();
            lbltelefone = new Label();
            lblcontato = new Label();
            btnalterar = new Button();
            btnexcluir = new Button();
            btncadastrar = new Button();
            txttelefone = new TextBox();
            txtcontato = new TextBox();
            dgvContatos = new DataGridView();
            gbAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // gbAgenda
            // 
            gbAgenda.Controls.Add(cmbCategoria);
            gbAgenda.Controls.Add(btnsair);
            gbAgenda.Controls.Add(lblcategoria);
            gbAgenda.Controls.Add(lbltelefone);
            gbAgenda.Controls.Add(lblcontato);
            gbAgenda.Controls.Add(btnalterar);
            gbAgenda.Controls.Add(btnexcluir);
            gbAgenda.Controls.Add(btncadastrar);
            gbAgenda.Controls.Add(txttelefone);
            gbAgenda.Controls.Add(txtcontato);
            gbAgenda.Location = new Point(24, 14);
            gbAgenda.Margin = new Padding(3, 2, 3, 2);
            gbAgenda.Name = "gbAgenda";
            gbAgenda.Padding = new Padding(3, 2, 3, 2);
            gbAgenda.Size = new Size(214, 306);
            gbAgenda.TabIndex = 0;
            gbAgenda.TabStop = false;
            gbAgenda.Text = "Agenda";
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = SystemColors.Info;
            cmbCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(15, 141);
            cmbCategoria.Margin = new Padding(3, 2, 3, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(184, 29);
            cmbCategoria.TabIndex = 11;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // btnsair
            // 
            btnsair.BackColor = Color.Khaki;
            btnsair.FlatStyle = FlatStyle.Flat;
            btnsair.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsair.Location = new Point(117, 248);
            btnsair.Margin = new Padding(3, 2, 3, 2);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(81, 46);
            btnsair.TabIndex = 10;
            btnsair.Text = "sair";
            btnsair.UseVisualStyleBackColor = false;
            btnsair.Click += btnsair_Click;
            // 
            // lblcategoria
            // 
            lblcategoria.AutoSize = true;
            lblcategoria.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblcategoria.Location = new Point(15, 128);
            lblcategoria.Name = "lblcategoria";
            lblcategoria.Size = new Size(49, 12);
            lblcategoria.TabIndex = 9;
            lblcategoria.Text = "Categoria";
            // 
            // lbltelefone
            // 
            lbltelefone.AutoSize = true;
            lbltelefone.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lbltelefone.Location = new Point(15, 76);
            lbltelefone.Name = "lbltelefone";
            lbltelefone.Size = new Size(44, 12);
            lbltelefone.TabIndex = 8;
            lbltelefone.Text = "Telefone";
            lbltelefone.Click += lbltelefone_Click;
            // 
            // lblcontato
            // 
            lblcontato.AutoSize = true;
            lblcontato.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblcontato.Location = new Point(15, 26);
            lblcontato.Name = "lblcontato";
            lblcontato.Size = new Size(42, 12);
            lblcontato.TabIndex = 7;
            lblcontato.Text = "Contato";
            // 
            // btnalterar
            // 
            btnalterar.BackColor = Color.Khaki;
            btnalterar.FlatStyle = FlatStyle.Flat;
            btnalterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnalterar.Location = new Point(15, 248);
            btnalterar.Margin = new Padding(3, 2, 3, 2);
            btnalterar.Name = "btnalterar";
            btnalterar.Size = new Size(81, 46);
            btnalterar.TabIndex = 6;
            btnalterar.Text = "alterar";
            btnalterar.UseVisualStyleBackColor = false;
            // 
            // btnexcluir
            // 
            btnexcluir.BackColor = Color.Khaki;
            btnexcluir.FlatStyle = FlatStyle.Flat;
            btnexcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnexcluir.Location = new Point(117, 190);
            btnexcluir.Margin = new Padding(3, 2, 3, 2);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(81, 46);
            btnexcluir.TabIndex = 5;
            btnexcluir.Text = "excluir";
            btnexcluir.UseVisualStyleBackColor = false;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // btncadastrar
            // 
            btncadastrar.BackColor = Color.Khaki;
            btncadastrar.FlatStyle = FlatStyle.Flat;
            btncadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btncadastrar.Location = new Point(15, 190);
            btncadastrar.Margin = new Padding(3, 2, 3, 2);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(81, 46);
            btncadastrar.TabIndex = 4;
            btncadastrar.Text = "cadastrar";
            btncadastrar.UseVisualStyleBackColor = false;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // txttelefone
            // 
            txttelefone.BackColor = SystemColors.Info;
            txttelefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txttelefone.Location = new Point(15, 90);
            txttelefone.Margin = new Padding(3, 2, 3, 2);
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(184, 29);
            txttelefone.TabIndex = 2;
            // 
            // txtcontato
            // 
            txtcontato.BackColor = SystemColors.Info;
            txtcontato.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtcontato.Location = new Point(15, 40);
            txtcontato.Margin = new Padding(3, 2, 3, 2);
            txtcontato.Name = "txtcontato";
            txtcontato.Size = new Size(184, 29);
            txtcontato.TabIndex = 1;
            // 
            // dgvContatos
            // 
            dgvContatos.BackgroundColor = SystemColors.Info;
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Location = new Point(258, 14);
            dgvContatos.Margin = new Padding(3, 2, 3, 2);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.RowHeadersWidth = 51;
            dgvContatos.Size = new Size(368, 306);
            dgvContatos.TabIndex = 1;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(648, 338);
            Controls.Add(dgvContatos);
            Controls.Add(gbAgenda);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAgenda";
            Text = "frmAgenda";
            FormClosed += frmAgenda_FormClosed;
            Load += frmAgenda_Load;
            gbAgenda.ResumeLayout(false);
            gbAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAgenda;
        private Button btnalterar;
        private Button btnexcluir;
        private Button btncadastrar;
        private TextBox txttelefone;
        private TextBox txtcontato;
        private DataGridView dgvContatos;
        private Label lbltelefone;
        private Label lblcontato;
        private Label lblcategoria;
        private Button btnsair;
        private ComboBox cmbCategoria;
    }
}