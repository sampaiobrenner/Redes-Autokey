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
            this.txbPainel = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnForcaBruta = new System.Windows.Forms.Button();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.btnGerarChave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbPainel
            // 
            this.txbPainel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPainel.Location = new System.Drawing.Point(261, 12);
            this.txbPainel.Multiline = true;
            this.txbPainel.Name = "txbPainel";
            this.txbPainel.ReadOnly = true;
            this.txbPainel.Size = new System.Drawing.Size(294, 474);
            this.txbPainel.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.BackColor = System.Drawing.Color.Transparent;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(155, 71);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(0, 16);
            this.lblKey.TabIndex = 6;
            this.lblKey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnForcaBruta
            // 
            this.btnForcaBruta.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForcaBruta.Image = global::Autokey_Cipher.Properties.Resources.alter;
            this.btnForcaBruta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForcaBruta.Location = new System.Drawing.Point(12, 396);
            this.btnForcaBruta.Name = "btnForcaBruta";
            this.btnForcaBruta.Size = new System.Drawing.Size(243, 90);
            this.btnForcaBruta.TabIndex = 4;
            this.btnForcaBruta.Text = "Força bruta";
            this.btnForcaBruta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnForcaBruta.UseVisualStyleBackColor = true;
            this.btnForcaBruta.Click += new System.EventHandler(this.btnForcaBruta_Click);
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarArquivo.Image = global::Autokey_Cipher.Properties.Resources.folder;
            this.btnSelecionarArquivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(13, 108);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(242, 90);
            this.btnSelecionarArquivo.TabIndex = 3;
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
            this.btnDescriptografar.Location = new System.Drawing.Point(13, 300);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(242, 90);
            this.btnDescriptografar.TabIndex = 2;
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
            this.btnCriptografar.Location = new System.Drawing.Point(13, 204);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(242, 90);
            this.btnCriptografar.TabIndex = 1;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // btnGerarChave
            // 
            this.btnGerarChave.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarChave.Image = global::Autokey_Cipher.Properties.Resources.chave;
            this.btnGerarChave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarChave.Location = new System.Drawing.Point(13, 12);
            this.btnGerarChave.Name = "btnGerarChave";
            this.btnGerarChave.Size = new System.Drawing.Size(243, 90);
            this.btnGerarChave.TabIndex = 0;
            this.btnGerarChave.Text = "Gerar chave";
            this.btnGerarChave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerarChave.UseVisualStyleBackColor = true;
            this.btnGerarChave.Click += new System.EventHandler(this.btnGerarChave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 497);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txbPainel);
            this.Controls.Add(this.btnForcaBruta);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Controls.Add(this.btnDescriptografar);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.btnGerarChave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autokey ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarChave;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Button btnDescriptografar;
        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.Button btnForcaBruta;
        private System.Windows.Forms.TextBox txbPainel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblKey;
    }
}

