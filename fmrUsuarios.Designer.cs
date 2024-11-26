namespace ProjetoAgenda
{
    partial class fmrUsuarios
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
            dgvUsers = new DataGridView();
            btnSair = new Button();
            label1 = new Label();
            btnExcluir = new Button();
            gbAlterarsenha = new GroupBox();
            btnAlterasenha = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            gbAlterarsenha.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = SystemColors.Info;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(33, 72);
            dgvUsers.Margin = new Padding(3, 4, 3, 4);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(357, 327);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Khaki;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.Location = new Point(311, 411);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(79, 37);
            btnSair.TabIndex = 1;
            btnSair.Text = "fechar";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(401, 32);
            label1.TabIndex = 2;
            label1.Text = "Selecione um usuario para excluir";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Khaki;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExcluir.Location = new Point(33, 411);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(79, 37);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // gbAlterarsenha
            // 
            gbAlterarsenha.Controls.Add(btnAlterasenha);
            gbAlterarsenha.Controls.Add(textBox1);
            gbAlterarsenha.Location = new Point(411, 116);
            gbAlterarsenha.Margin = new Padding(3, 4, 3, 4);
            gbAlterarsenha.Name = "gbAlterarsenha";
            gbAlterarsenha.Padding = new Padding(3, 4, 3, 4);
            gbAlterarsenha.Size = new Size(272, 235);
            gbAlterarsenha.TabIndex = 4;
            gbAlterarsenha.TabStop = false;
            gbAlterarsenha.Text = "Alterar senha";
            // 
            // btnAlterasenha
            // 
            btnAlterasenha.BackColor = Color.Khaki;
            btnAlterasenha.FlatStyle = FlatStyle.Flat;
            btnAlterasenha.Location = new Point(66, 139);
            btnAlterasenha.Margin = new Padding(3, 4, 3, 4);
            btnAlterasenha.Name = "btnAlterasenha";
            btnAlterasenha.Size = new Size(135, 68);
            btnAlterasenha.TabIndex = 1;
            btnAlterasenha.Text = "Alterar";
            btnAlterasenha.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(15, 63);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 39);
            textBox1.TabIndex = 0;
            // 
            // fmrUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(712, 462);
            Controls.Add(btnExcluir);
            Controls.Add(label1);
            Controls.Add(btnSair);
            Controls.Add(dgvUsers);
            Controls.Add(gbAlterarsenha);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "fmrUsuarios";
            Text = "fmrUsuarios";
            FormClosing += fmrUsuarios_FormClosing;
            FormClosed += fmrUsuarios_FormClosed;
            Load += fmrUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            gbAlterarsenha.ResumeLayout(false);
            gbAlterarsenha.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Button btnSair;
        private Label label1;
        private Button btnExcluir;
        private GroupBox gbAlterarsenha;
        private Button btnAlterasenha;
        private TextBox textBox1;
    }
}