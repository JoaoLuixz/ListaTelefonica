namespace ListaTelefonica
{
    partial class ListaTelefonica
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaTelefonica));
            this.lbAgenda = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAgenda
            // 
            this.lbAgenda.AutoSize = true;
            this.lbAgenda.Location = new System.Drawing.Point(259, 38);
            this.lbAgenda.Name = "lbAgenda";
            this.lbAgenda.Size = new System.Drawing.Size(82, 22);
            this.lbAgenda.TabIndex = 0;
            this.lbAgenda.Text = "Agenda!";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(21, 164);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(66, 22);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(209, 164);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(89, 22);
            this.lbTelefone.TabIndex = 2;
            this.lbTelefone.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lista de Telefones";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 161);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(110, 29);
            this.txtNome.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(304, 161);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(207, 29);
            this.txtNumero.TabIndex = 5;
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.ItemHeight = 22;
            this.listBoxNumeros.Location = new System.Drawing.Point(21, 331);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(569, 268);
            this.listBoxNumeros.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(479, 259);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(90, 44);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(517, 161);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(85, 29);
            this.btnIncluir.TabIndex = 8;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ListaTelefonica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.listBoxNumeros);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbAgenda);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ListaTelefonica";
            this.Text = "ListaTelefonica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbAgenda;
        private Label lbNome;
        private Label lbTelefone;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtNumero;
        private ListBox listBoxNumeros;
        private Button btnListar;
        private Button btnIncluir;
        private PictureBox pictureBox1;
    }
}