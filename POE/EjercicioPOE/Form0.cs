using EjercicioPOE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarcularNotas
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formNotas = new Form1();
            formNotas.ShowDialog();
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#0b4291");
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
