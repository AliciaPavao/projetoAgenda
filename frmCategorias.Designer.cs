﻿namespace ProjetoAgenda
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            txtCategoria = new TextBox();
            btnCadastrar = new Button();
            lblCadastro = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnSair = new Button();
            dgvCategoria = new DataGridView();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnExcluir = new Button();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            btn_alterar = new Button();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Segoe UI", 14F);
            txtCategoria.Location = new Point(74, 126);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(323, 32);
            txtCategoria.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Khaki;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCadastrar.Location = new Point(173, 179);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(103, 48);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCadastro.Location = new Point(74, 90);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(295, 25);
            lblCadastro.TabIndex = 2;
            lblCadastro.Text = "DIGITE O NOME DA CATEGORIA";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(349, 203);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 63);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(64, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(96, 88);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(21, 160);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 106);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(382, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 55);
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Khaki;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSair.Location = new Point(12, 451);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(55, 29);
            btnSair.TabIndex = 19;
            btnSair.Text = "sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // dgvCategoria
            // 
            dgvCategoria.BackgroundColor = SystemColors.Info;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(75, 241);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(323, 133);
            dgvCategoria.TabIndex = 20;
            dgvCategoria.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(146, 440);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 40);
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(21, 344);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 31);
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Khaki;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluir.Location = new Point(382, 451);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 29);
            btnExcluir.TabIndex = 24;
            btnExcluir.Text = "excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(262, 421);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(80, 76);
            pictureBox7.TabIndex = 25;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(84, 383);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(73, 63);
            pictureBox8.TabIndex = 26;
            pictureBox8.TabStop = false;
            // 
            // btn_alterar
            // 
            btn_alterar.BackColor = Color.Khaki;
            btn_alterar.FlatStyle = FlatStyle.Flat;
            btn_alterar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_alterar.Location = new Point(382, 416);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(82, 29);
            btn_alterar.TabIndex = 27;
            btn_alterar.Text = "alterar";
            btn_alterar.UseVisualStyleBackColor = false;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.Location = new Point(196, 391);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(56, 55);
            pictureBox9.TabIndex = 28;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Location = new Point(341, 380);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(33, 36);
            pictureBox10.TabIndex = 29;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Transparent;
            pictureBox11.BackgroundImage = (Image)resources.GetObject("pictureBox11.BackgroundImage");
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox11.Location = new Point(404, 320);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(60, 60);
            pictureBox11.TabIndex = 30;
            pictureBox11.TabStop = false;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(475, 491);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(btn_alterar);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(btnExcluir);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(dgvCategoria);
            Controls.Add(btnSair);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblCadastro);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCategoria);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategorias";
            Text = "frmCategorias";
            Load += frmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoria;
        private Button btnCadastrar;
        private Label lblCadastro;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnSair;
        private DataGridView dgvCategoria;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnExcluir;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Button btn_alterar;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
    }
}