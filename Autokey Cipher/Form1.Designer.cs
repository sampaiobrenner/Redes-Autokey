namespace Autokey_Cipher
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPainel1 = new System.Windows.Forms.TextBox();
            this.txbPainel2 = new System.Windows.Forms.TextBox();
            this.txbPainel3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTempoDecorrido = new System.Windows.Forms.Label();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.btnGerarChave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbKey2 = new System.Windows.Forms.TextBox();
            this.btnForcaBruta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Texto descriptografado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Texto criptografado";
            // 
            // txbPainel1
            // 
            this.txbPainel1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPainel1.Location = new System.Drawing.Point(15, 151);
            this.txbPainel1.Multiline = true;
            this.txbPainel1.Name = "txbPainel1";
            this.txbPainel1.Size = new System.Drawing.Size(242, 345);
            this.txbPainel1.TabIndex = 22;
            // 
            // txbPainel2
            // 
            this.txbPainel2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPainel2.Location = new System.Drawing.Point(263, 151);
            this.txbPainel2.Multiline = true;
            this.txbPainel2.Name = "txbPainel2";
            this.txbPainel2.ReadOnly = true;
            this.txbPainel2.Size = new System.Drawing.Size(242, 345);
            this.txbPainel2.TabIndex = 21;
            // 
            // txbPainel3
            // 
            this.txbPainel3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPainel3.Location = new System.Drawing.Point(511, 151);
            this.txbPainel3.Multiline = true;
            this.txbPainel3.Name = "txbPainel3";
            this.txbPainel3.ReadOnly = true;
            this.txbPainel3.Size = new System.Drawing.Size(242, 345);
            this.txbPainel3.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 19;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarArquivo.Image = global::Autokey_Cipher.Properties.Resources.folder;
            this.btnSelecionarArquivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(15, 12);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(242, 90);
            this.btnSelecionarArquivo.TabIndex = 16;
            this.btnSelecionarArquivo.Text = "Selecionar\r\narquivo";
            this.btnSelecionarArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // btnDescriptografar
            // 
            this.btnDescriptografar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescriptografar.Image = global::Autokey_Cipher.Properties.Resources.cadeado_aberto;
            this.btnDescriptografar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescriptografar.Location = new System.Drawing.Point(511, 13);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(242, 90);
            this.btnDescriptografar.TabIndex = 15;
            this.btnDescriptografar.Text = "Descriptografar";
            this.btnDescriptografar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescriptografar.UseVisualStyleBackColor = true;
            this.btnDescriptografar.Click += new System.EventHandler(this.btnDescriptografar_Click);
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptografar.Image = global::Autokey_Cipher.Properties.Resources.cadeado_fechado;
            this.btnCriptografar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriptografar.Location = new System.Drawing.Point(263, 13);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(242, 90);
            this.btnCriptografar.TabIndex = 14;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Texto original";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSelecionarArquivo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCriptografar);
            this.panel1.Controls.Add(this.btnDescriptografar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbPainel3);
            this.panel1.Controls.Add(this.txbPainel1);
            this.panel1.Controls.Add(this.txbPainel2);
            this.panel1.Location = new System.Drawing.Point(13, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 511);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTempoDecorrido);
            this.panel2.Controls.Add(this.txbKey);
            this.panel2.Controls.Add(this.btnGerarChave);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 108);
            this.panel2.TabIndex = 28;
            // 
            // lblTempoDecorrido
            // 
            this.lblTempoDecorrido.AutoSize = true;
            this.lblTempoDecorrido.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoDecorrido.Location = new System.Drawing.Point(513, 9);
            this.lblTempoDecorrido.Name = "lblTempoDecorrido";
            this.lblTempoDecorrido.Size = new System.Drawing.Size(0, 18);
            this.lblTempoDecorrido.TabIndex = 28;
            this.lblTempoDecorrido.Visible = false;
            // 
            // txbKey
            // 
            this.txbKey.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKey.Location = new System.Drawing.Point(265, 9);
            this.txbKey.MaxLength = 5;
            this.txbKey.Multiline = true;
            this.txbKey.Name = "txbKey";
            this.txbKey.ReadOnly = true;
            this.txbKey.Size = new System.Drawing.Size(242, 90);
            this.txbKey.TabIndex = 27;
            // 
            // btnGerarChave
            // 
            this.btnGerarChave.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarChave.Image = global::Autokey_Cipher.Properties.Resources.chave;
            this.btnGerarChave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarChave.Location = new System.Drawing.Point(16, 8);
            this.btnGerarChave.Name = "btnGerarChave";
            this.btnGerarChave.Size = new System.Drawing.Size(243, 90);
            this.btnGerarChave.TabIndex = 26;
            this.btnGerarChave.Text = "Gerar chave";
            this.btnGerarChave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerarChave.UseVisualStyleBackColor = true;
            this.btnGerarChave.Click += new System.EventHandler(this.btnGerarChave_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txbKey2);
            this.panel3.Controls.Add(this.btnForcaBruta);
            this.panel3.Location = new System.Drawing.Point(13, 647);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 108);
            this.panel3.TabIndex = 29;
            // 
            // txbKey2
            // 
            this.txbKey2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKey2.Location = new System.Drawing.Point(263, 8);
            this.txbKey2.Multiline = true;
            this.txbKey2.Name = "txbKey2";
            this.txbKey2.ReadOnly = true;
            this.txbKey2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbKey2.Size = new System.Drawing.Size(490, 90);
            this.txbKey2.TabIndex = 20;
            // 
            // btnForcaBruta
            // 
            this.btnForcaBruta.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForcaBruta.Image = global::Autokey_Cipher.Properties.Resources.alter;
            this.btnForcaBruta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForcaBruta.Location = new System.Drawing.Point(15, 8);
            this.btnForcaBruta.Name = "btnForcaBruta";
            this.btnForcaBruta.Size = new System.Drawing.Size(243, 90);
            this.btnForcaBruta.TabIndex = 19;
            this.btnForcaBruta.Text = "Força bruta";
            this.btnForcaBruta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnForcaBruta.UseVisualStyleBackColor = true;
            this.btnForcaBruta.Click += new System.EventHandler(this.btnForcaBruta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 763);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPainel1;
        private System.Windows.Forms.TextBox txbPainel2;
        private System.Windows.Forms.TextBox txbPainel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.Button btnDescriptografar;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.Button btnGerarChave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbKey2;
        private System.Windows.Forms.Button btnForcaBruta;
        private System.Windows.Forms.Label lblTempoDecorrido;
    }
}

