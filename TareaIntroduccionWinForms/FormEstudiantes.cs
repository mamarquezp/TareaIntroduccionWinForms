namespace TareaIntroduccionWinForms
{
    public partial class FormEstudiantes : Form
    {
        private List<string> listaEstudiantes = new List<string>();
        private const string Encabezado = "Nombre\t\tCarnet\t\tCarrera\n";
        private const string Separador = "-------------------------------------------------------------\n";

        public FormEstudiantes()
        {
            InitializeComponent();
            InicializaFormulario();
        }

        private void InicializaFormulario()
        {
            labelListado.Text = Encabezado + Separador;
            this.AcceptButton = btnAgregar;
            this.CancelButton = btnLimpiar;
        }

            private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxNombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vac�o", "Error de Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtBoxCarnet.Text.Length != 7)
            {
                MessageBox.Show("El campo Carnet debe tener exactamente 7 caracteres", "Error de Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbBoxCarrera.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Carrera.", "Error de Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nuevoEstudiante = $"{txtBoxNombre.Text}\t\t{txtBoxCarnet.Text}\t{cmbBoxCarrera.SelectedItem.ToString()}";

            listaEstudiantes.Add(nuevoEstudiante);

            ActualizarListado();

            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtBoxNombre.Clear();
            txtBoxCarnet.Clear();
            cmbBoxCarrera.SelectedIndex = -1;
            txtBoxNombre.Focus();
        }

        private void ActualizarListado()
        {
            labelListado.Text = Encabezado + Separador;

            foreach (string estudiante in listaEstudiantes)
            {
                labelListado.Text += estudiante + "\n";
            }
        }
    }
}
