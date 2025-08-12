namespace TallerPractico_FC250417
{
    public partial class Estudiantes : Form
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();
        private int edit_indice = -1;




        private void actualizarGrid()
        {
            dgbestudiantes.DataSource = null;
            dgbestudiantes.DataSource = estudiantes;
        }

        private void limpiar()
        {
            txtnombape.Clear();
            txtcarrera.Clear();
            txtmateria.Clear();
            txtnota.Clear();
        }
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            dgbestudiantes.DataSource = null;
            dgbestudiantes.DataSource = estudiantes;
        }

        private void txtcarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {

        }

        private void dgbestudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                DataGridViewRow seleccion = dgbestudiantes.SelectedRows[0];
                int not = dgbestudiantes.Rows.IndexOf(seleccion);
                edit_indice = not;

                Estudiante est = estudiantes[not];

                txtnombape.Text = est.NomApe;
                txtcarrera.Text = est.Carrera;
                txtmateria.Text = est.Materia;
                txtnota.Text = est.Promedio.ToString();             
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombape.Text;
            string carrera = txtcarrera.Text;
            string materia = txtmateria.Text;
            Double promedio;
            if (Double.TryParse(txtnota.Text, out promedio))
            {
                Estudiante nuevos = new Estudiante(nombre, carrera, materia, promedio);
                estudiantes.Add(nuevos);
                MessageBox.Show("Registro Exitoso");
                limpiar();
            }
            else
            {
                MessageBox.Show("Promedio no valido");
            }
        
        }

        private void btnpromgen_Click(object sender, EventArgs e)
        {
            Double suma = 0;
            int cantidad = estudiantes.Count;
            for (int i = 0; i < cantidad; i++)
            {
                suma += estudiantes[i].Promedio;
            }
            if (cantidad > 0)
            {
                Double promedio = suma / cantidad;
                lblpromedio.Text = " " + promedio.ToString("F2");
            }
            else
            {
                lblpromedio.Text = "No hay estudiantes registrados.";
            }
        }

        private void btndest_Click(object sender, EventArgs e)
        {
            List<Estudiante> destacadous = new List<Estudiante>();
            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].EsDestacado() == true)
                {
                    destacadous.Add(estudiantes[i]);
                }
            }
            dgbestudiantes.DataSource = null;
            dgbestudiantes.DataSource = destacadous;
        }
    }
}