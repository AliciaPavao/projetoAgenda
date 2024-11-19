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
            dgvUsers.Location = new Point(29, 92);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(312, 245);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Khaki;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.Location = new Point(272, 343);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(69, 28);
            btnSair.TabIndex = 1;
            btnSair.Text = "fechar";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(29, 53);
            label1.Name = "label1";
            label1.Size = new Size(312, 25);
            label1.TabIndex = 2;
            label1.Text = "Selecione um usuario para excluir";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Khaki;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExcluir.Location = new Point(29, 343);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(69, 28);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // gbAlterarsenha
            // 
            gbAlterarsenha.Controls.Add(btnAlterasenha);
            gbAlterarsenha.Controls.Add(textBox1);
            gbAlterarsenha.Location = new Point(399, 92);
            gbAlterarsenha.Name = "gbAlterarsenha";
            gbAlterarsenha.Size = new Size(238, 176);
            gbAlterarsenha.TabIndex = 4;
            gbAlterarsenha.TabStop = false;
            gbAlterarsenha.Text = "Alterar senha";
            // 
            // btnAlterasenha
            // 
            btnAlterasenha.BackColor = Color.Khaki;
            btnAlterasenha.FlatStyle = FlatStyle.Flat;
            btnAlterasenha.Location = new Point(58, 104);
            btnAlterasenha.Name = "btnAlterasenha";
            btnAlterasenha.Size = new Size(118, 51);
            btnAlterasenha.TabIndex = 1;
            btnAlterasenha.Text = "Alterar";
            btnAlterasenha.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(13, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 32);
            textBox1.TabIndex = 0;
            // 
            // fmrUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(669, 395);
            Controls.Add(btnExcluir);
            Controls.Add(label1);
            Controls.Add(btnSair);
            Controls.Add(dgvUsers);
            Controls.Add(gbAlterarsenha);
            Name = "fmrUsuarios";
            Text = "fmrUsuarios";
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