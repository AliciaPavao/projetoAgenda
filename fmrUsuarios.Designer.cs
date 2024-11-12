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
            dataGridView1 = new DataGridView();
            btnSair = new Button();
            label1 = new Label();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(340, 295);
            dataGridView1.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Khaki;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.Location = new Point(330, 418);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(62, 28);
            btnSair.TabIndex = 1;
            btnSair.Text = "fechar";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(29, 70);
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
            btnExcluir.Location = new Point(12, 418);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(62, 28);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // fmrUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(395, 450);
            Controls.Add(btnExcluir);
            Controls.Add(label1);
            Controls.Add(btnSair);
            Controls.Add(dataGridView1);
            Name = "fmrUsuarios";
            Text = "fmrUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSair;
        private Label label1;
        private Button btnExcluir;
    }
}