using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autokey_Cipher
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private static int Timer { get; set; }
        private string Chave => $"{PalavraChave}{txbPainel1.Text}";
        private string PalavraChave { get; set; }
        private string RetornoForcaBruta { get; set; }

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
            RetornoForcaBruta = null;
            lblTempoDecorrido.Visible = true;
            Timer = 0;

            var cifra = txbPainel2.Text;

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            txbKey2.Text = "Por favor aguarde...";

            var task = new Task(() =>
            {
                RetornoForcaBruta = ForcaBruta.ExecutarForcaBruta(cifra, txbPainel1.Text);
                Thread.Sleep(1000);
                timer1.Stop();
            });

            task.Start();
        }

        private void btnGerarChave_Click(object sender, EventArgs e) => GerarChave();

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            txbPainel1.Text = System.IO.File.ReadAllText(dialog.FileName, Encoding.Default);
        }

        private void GerarChave()
        {
            var prompt = new FormPrompt("Informe a palavra chave:", PalavraChave);
            prompt.ShowDialog();
            if (prompt.DialogResult != DialogResult.OK) return;

            PalavraChave = prompt.txbMensagem.Text;
            txbKey.Text = PalavraChave;
        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            Timer += 1;
            lblTempoDecorrido.Text = $"Tempo decorrido: {Timer.ToString()}";
            if (RetornoForcaBruta != null)
                txbKey2.Text = RetornoForcaBruta;
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