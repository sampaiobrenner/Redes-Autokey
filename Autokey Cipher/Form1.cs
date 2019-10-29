using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autokey_Cipher
{
    public partial class Form1 : Form
    {
        private string Key { get; set; }

        public Form1() => InitializeComponent();

        private void btnForcaBruta_Click(object sender, EventArgs e)
        {
        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            if (!ValidarSeExisteChave()) return;

            txbPainel.Text = Autokey.Decrypt(txbPainel.Text, Key);
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            if (!ValidarSeExisteChave()) return;

            txbPainel.Text = Autokey.Encrypt(txbPainel.Text, Key);
        }

        private bool ValidarSeExisteChave()
        {
            if (!string.IsNullOrEmpty(Key)) return true;

            MessageBox.Show("A chave não foi informada.");
            GerarChave();
            return false;
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            txbPainel.Text = System.IO.File.ReadAllText(dialog.FileName, Encoding.Default).SubstituirCaracteresEspeciais();
        }

        private void btnGerarChave_Click(object sender, EventArgs e) => GerarChave();

        private void GerarChave()
        {
            var prompt = new FormPrompt("Informe a chave:", Key);
            prompt.ShowDialog();
            if (prompt.DialogResult != DialogResult.OK) return;

            Key = prompt.txbMensagem.Text;
            lblKey.Text = Key;
        }
    }
}