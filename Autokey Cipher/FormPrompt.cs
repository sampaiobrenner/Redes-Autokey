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
    public partial class FormPrompt : Form
    {
        public FormPrompt(string mensagem, string defaultValue = null)
        {
            InitializeComponent();

            lblMensagem.Text = mensagem;
            txbMensagem.Text = defaultValue ?? string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FormPrompt_Load(object sender, EventArgs e)
        {
            txbMensagem.Focus();
        }
    }
}