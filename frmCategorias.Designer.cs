namespace ProjetoAgenda
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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
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
            pictureBox1.Location = new Point(349, 220);
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
            pictureBox3.Location = new Point(21, 164);
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
            btnSair.Font = new Font("Segoe UI", 12F);
            btnSair.Location = new Point(12, 458);
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
            dgvCategoria.Location = new Point(75, 301);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.Size = new Size(323, 133);
            dgvCategoria.TabIndex = 20;
            dgvCategoria.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(173, 266);
            button1.Name = "button1";
            button1.Size = new Size(103, 29);
            button1.TabIndex = 21;
            button1.Text = "Botão";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(475, 491);
            Controls.Add(button1);
            Controls.Add(dgvCategoria);
            Controls.Add(btnSair);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblCadastro);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCategoria);
            Name = "frmCategorias";
            Text = "frmCategorias";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
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
        private Button button1;
    }
}