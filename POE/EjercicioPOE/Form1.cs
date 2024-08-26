using EjercicioPOE;

namespace EjercicioPOE
{
    public partial class Form1 : Form
    {
        Estudiante estudianteN = new Estudiante();
        Nota notaE = new Nota();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlmacenarRegistro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío y no debe contener números.", "Validación de Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double nota1, nota2, nota3, nota4;

            if (!double.TryParse(txtNota1.Text, out nota1) || !double.TryParse(txtNota2.Text, out nota2) ||
                !double.TryParse(txtNota3.Text, out nota3) || !double.TryParse(txtNota4.Text, out nota4))
            {
                MessageBox.Show("Todos los campos de Notas deben contener valores numéricos y no deben estar vacíos.", "Validación de Notas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            estudianteN.Nombre = txtNombre.Text;
            notaE.Nota1 = Convert.ToDouble(txtNota1.Text);
            notaE.Nota2 = Convert.ToDouble(txtNota2.Text);
            notaE.Nota3 = Convert.ToDouble(txtNota3.Text);
            notaE.Nota4 = Convert.ToDouble(txtNota4.Text);
            MessageBox.Show("Las notas igresada han sido guardadas");

        }

        private void CalcularNotas_Click(object sender, EventArgs e)
        {
            NotaF.Text = notaE.CalcularNotas(notaE.Nota1, notaE.Nota2, notaE.Nota3, notaE.Nota4).ToString();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            NotaF.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#0b4291");
        }

        private void salir_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
