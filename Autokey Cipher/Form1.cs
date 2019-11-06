using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Autokey_Cipher
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private string Chave => $"{PalavraChave}{txbPainel1.Text}";
        private string PalavraChave { get; set; }
        private string RetornoForcaBruta { get; set; }
        private string TempoDecorrido { get; set; }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            if (!ValidarSeExisteChave()) return;

            txbPainel2.Text = new AutoKeyCipher().Cipher(txbPainel1.Text, Chave);
        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            if (!ValidarSeExisteChave()) return;

            txbPainel3.Text = new AutoKeyCipher().Decipher(txbPainel2.Text, Chave);
        }

        private void btnForcaBruta_Click(object sender, EventArgs e)
        {
            lblTempoDecorrido.Visible = true;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var cifra = txbPainel2.Text;

            //var task = new Task(() =>
            //{
            RetornoForcaBruta = ForcaBruta.ExecutarForcaBruta(cifra, txbPainel1.Text);
            //});

            //task.Start();

            //do
            //{
            TempoDecorrido = $"Tempo: {stopwatch.Elapsed}";
            ExibirRetornoForcaBruta();
            ExibirTempoDecorrido();
            //} while (!task.IsCompleted);

            stopwatch.Stop();
        }

        private void btnGerarChave_Click(object sender, EventArgs e) => GerarChave();

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            txbPainel1.Text = System.IO.File.ReadAllText(dialog.FileName, Encoding.Default);
        }

        private void ExibirRetornoForcaBruta() => txbKey2.Text = RetornoForcaBruta;

        private void ExibirTempoDecorrido() => lblTempoDecorrido.Text = TempoDecorrido;

        private void GerarChave()
        {
            var prompt = new FormPrompt("Informe a palavra chave:", PalavraChave);
            prompt.ShowDialog();
            if (prompt.DialogResult != DialogResult.OK) return;

            PalavraChave = prompt.txbMensagem.Text;
            txbKey.Text = PalavraChave;
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