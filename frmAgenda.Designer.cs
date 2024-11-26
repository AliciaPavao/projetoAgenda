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
            lblcategoria = new Label();
            lbltelefone = new Label();
            lblcontato = new Label();
            btnalterar = new Button();
            btnexcluir = new Button();
            btncadastrar = new Button();
            txtcategoria = new TextBox();
            txttelefone = new TextBox();
            txtcontato = new TextBox();
            dataGridView1 = new DataGridView();
            btnsair = new Button();
            gbAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbAgenda
            // 
            gbAgenda.Controls.Add(btnsair);
            gbAgenda.Controls.Add(lblcategoria);
            gbAgenda.Controls.Add(lbltelefone);
            gbAgenda.Controls.Add(lblcontato);
            gbAgenda.Controls.Add(btnalterar);
            gbAgenda.Controls.Add(btnexcluir);
            gbAgenda.Controls.Add(btncadastrar);
            gbAgenda.Controls.Add(txtcategoria);
            gbAgenda.Controls.Add(txttelefone);
            gbAgenda.Controls.Add(txtcontato);
            gbAgenda.Location = new Point(27, 18);
            gbAgenda.Name = "gbAgenda";
            gbAgenda.Size = new Size(244, 408);
            gbAgenda.TabIndex = 0;
            gbAgenda.TabStop = false;
            gbAgenda.Text = "Agenda";
            // 
            // lblcategoria
            // 
            lblcategoria.AutoSize = true;
            lblcategoria.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblcategoria.Location = new Point(17, 170);
            lblcategoria.Name = "lblcategoria";
            lblcategoria.Size = new Size(60, 15);
            lblcategoria.TabIndex = 9;
            lblcategoria.Text = "Categoria";
            // 
            // lbltelefone
            // 
            lbltelefone.AutoSize = true;
            lbltelefone.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lbltelefone.Location = new Point(17, 102);
            lbltelefone.Name = "lbltelefone";
            lbltelefone.Size = new Size(56, 15);
            lbltelefone.TabIndex = 8;
            lbltelefone.Text = "Telefone";
            lbltelefone.Click += lbltelefone_Click;
            // 
            // lblcontato
            // 
            lblcontato.AutoSize = true;
            lblcontato.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblcontato.Location = new Point(17, 35);
            lblcontato.Name = "lblcontato";
            lblcontato.Size = new Size(51, 15);
            lblcontato.TabIndex = 7;
            lblcontato.Text = "Contato";
            // 
            // btnalterar
            // 
            btnalterar.BackColor = Color.Khaki;
            btnalterar.FlatStyle = FlatStyle.Flat;
            btnalterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnalterar.Location = new Point(17, 331);
            btnalterar.Name = "btnalterar";
            btnalterar.Size = new Size(93, 62);
            btnalterar.TabIndex = 6;
            btnalterar.Text = "alterar";
            btnalterar.UseVisualStyleBackColor = false;
            // 
            // btnexcluir
            // 
            btnexcluir.BackColor = Color.Khaki;
            btnexcluir.FlatStyle = FlatStyle.Flat;
            btnexcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnexcluir.Location = new Point(134, 253);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(93, 62);
            btnexcluir.TabIndex = 5;
            btnexcluir.Text = "excluir";
            btnexcluir.UseVisualStyleBackColor = false;
            // 
            // btncadastrar
            // 
            btncadastrar.BackColor = Color.Khaki;
            btncadastrar.FlatStyle = FlatStyle.Flat;
            btncadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btncadastrar.Location = new Point(17, 253);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(93, 62);
            btncadastrar.TabIndex = 4;
            btncadastrar.Text = "cadastrar";
            btncadastrar.UseVisualStyleBackColor = false;
            // 
            // txtcategoria
            // 
            txtcategoria.BackColor = SystemColors.Info;
            txtcategoria.Font = new Font("Segoe UI", 12F);
            txtcategoria.Location = new Point(17, 188);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(210, 34);
            txtcategoria.TabIndex = 3;
            // 
            // txttelefone
            // 
            txttelefone.BackColor = SystemColors.Info;
            txttelefone.Font = new Font("Segoe UI", 12F);
            txttelefone.Location = new Point(17, 120);
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(210, 34);
            txttelefone.TabIndex = 2;
            // 
            // txtcontato
            // 
            txtcontato.BackColor = SystemColors.Info;
            txtcontato.Font = new Font("Segoe UI", 12F);
            txtcontato.Location = new Point(17, 53);
            txtcontato.Name = "txtcontato";
            txtcontato.Size = new Size(210, 34);
            txtcontato.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(295, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(421, 408);
            dataGridView1.TabIndex = 1;
            // 
            // btnsair
            // 
            btnsair.BackColor = Color.Khaki;
            btnsair.FlatStyle = FlatStyle.Flat;
            btnsair.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsair.Location = new Point(134, 331);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(93, 62);
            btnsair.TabIndex = 10;
            btnsair.Text = "sair";
            btnsair.UseVisualStyleBackColor = false;
            btnsair.Click += btnsair_Click;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(740, 450);
            Controls.Add(dataGridView1);
            Controls.Add(gbAgenda);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgenda";
            Text = "frmAgenda";
            FormClosed += frmAgenda_FormClosed;
            gbAgenda.ResumeLayout(false);
            gbAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAgenda;
        private Button btnalterar;
        private Button btnexcluir;
        private Button btncadastrar;
        private TextBox txtcategoria;
        private TextBox txttelefone;
        private TextBox txtcontato;
        private DataGridView dataGridView1;
        private Label lbltelefone;
        private Label lblcontato;
        private Label lblcategoria;
        private Button btnsair;
    }
}