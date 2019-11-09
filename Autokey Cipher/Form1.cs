using System;
using System.Text;
using System.Windows.Forms;

namespace Autokey_Cipher
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private string Chave => $"{PalavraChave}{txbPainel1.Text.Replace(" ", "").ToLower()}";
        private string PalavraChave { get; set; }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            if (!ValidarSeExisteChave()) return;

            txbPainel2.Text = new AutoKeyCipher().Cipher(txbPainel1.Text.Replace(" ", "").ToLower(), Chave);
        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            if (!ValidarSeExisteChave()) return;

            txbPainel3.Text = new AutoKeyCipher().Decipher(txbPainel2.Text, Chave);
        }

        private void btnForcaBruta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPainel2.Text))
            {
                MessageBox.Show("Não foi gerada a cifra para executar a força bruta.");
                return;
            }

            var retorno = ForcaBruta.ExecutarForcaBruta(txbPainel2.Text, txbPainel1.Text.Replace(" ", "").ToLower(), PalavraChave.Length, PalavraChave, out var tempoDeExecucao);
            txbKey2.Text = $@"{retorno}{Environment.NewLine}Tempo de execução: {TimeSpan.FromMilliseconds(tempoDeExecucao).Seconds}s";
        }

        private void btnGerarChave_Click(object sender, EventArgs e) => GerarChave();

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            txbPainel1.Text = System.IO.File.ReadAllText(dialog.FileName, Encoding.Default).ToLower();
        }

        private void GerarChave()
        {
            var prompt = new FormPrompt("Informe a palavra chave:", PalavraChave);
            prompt.ShowDialog();
            if (prompt.DialogResult != DialogResult.OK) return;

            PalavraChave = prompt.txbMensagem.Text;
            txbKey.Text = $"{Environment.NewLine}{PalavraChave}";
        }

        private bool ValidarSeExisteChave()
        {
            if (!string.IsNullOrEmpty(PalavraChave)) return true;

            MessageBox.Show("A palavra chave não foi informada.");
            GerarChave();
            return false;
        }
    }
}