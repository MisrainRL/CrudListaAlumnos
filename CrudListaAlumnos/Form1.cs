using System.Windows.Forms;

namespace CrudListaAlumnos
{
    public partial class FrmAlumnos : Form
    {
        List<Alumnos> LAlumnos = new List<Alumnos>();
        public FrmAlumnos()
        {
            InitializeComponent();
            btnBorrar.Enabled = false;
            btnActualizar.Enabled = false;
        }



        private void FrmAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validadores de Datos 
            if (Validardatos() == false)
            {
                return;
            }
            if (ValidarCorreo() == false)
            {
                return;
            }
            if (ValidarEdad() == false)
            {
                return;
            }
            //Comenzr a guardar datos
            Alumnos alumnos = new Alumnos();
            alumnos.Nombre = textNombre.Text;
            alumnos.Correo = textCorreo.Text;
            alumnos.Edad = int.Parse(textEdad.Text);
            LAlumnos.Add(alumnos);
            LimpiarCajas();
        }

        //Metodo para evitar datos vacios

        private bool ValidarCorreo()
        {
            if (string.IsNullOrEmpty(textCorreo.Text))
            {
                erpError.SetError(textCorreo, "Debe ingresar un dato");
                textCorreo.Focus();
                return false;
            }
            else
            {
                erpError.SetError(textEdad, "");
                return true;
            }
        }

        private bool ValidarEdad()
        {
            int Edad;
            if (!int.TryParse(textEdad.Text, out Edad) || textEdad.Text == "")
            {
                erpError.SetError(textEdad, "Debe ingresar un dato numerico");
                textEdad.Clear();
                textEdad.Focus();
                return false;

            }
            else
            {
                erpError.SetError(textEdad, "");
                return true;
            }


        }
        private bool Validardatos()
        {
            if (string.IsNullOrEmpty(textNombre.Text))
            {
                erpError.SetError(textNombre, "No puede quedar el dato vacio");
                textNombre.Focus();
                return false;
            }
            else
            {
                erpError.SetError(textNombre, "");
                return true;
            }
        }
        //Limpiar las cajas de texto
        private void LimpiarCajas()
        {
            textEdad.Clear();
            textCorreo.Clear();
            textNombre.Clear();
            textNombre.Focus();

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = LAlumnos;
        }
        //Detectar el registro que se selecciona en la tabla de datos

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dgvDatos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                object valorCelda = cell.Value;

                // Mostrar los valores de la fila seleccionada en las cajas de texto
                DataGridViewRow filaSeleccionada = dgvDatos.Rows[e.RowIndex];
                textNombre.Text = filaSeleccionada.Cells[0].Value.ToString();
                textCorreo.Text = filaSeleccionada.Cells[1].Value.ToString();
                textEdad.Text = filaSeleccionada.Cells[2].Value.ToString();
                //Activar la opción de borrar
                btnBorrar.Enabled = true;
                btnActualizar.Enabled = true;
                btnGuardar.Enabled = false;
            }
        } 
        /*

            private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int rowIndex = e.RowIndex; // Obtener el índice de la fila seleccionada
            int columnIndex = e.ColumnIndex; // Obtener el índice de la columna seleccionada

            if (rowIndex >= 0 && columnIndex >= 0) // Verificar que se ha seleccionado una celda válida
            {
                // Mostrar los valores de la fila seleccionada en las cajas de texto
                DataGridViewRow filaSeleccionada = dgvDatos.Rows[e.RowIndex];
                textNombre.Text = filaSeleccionada.Cells[0].Value.ToString();
                textCorreo.Text = filaSeleccionada.Cells[1].Value.ToString();
                textEdad.Text = filaSeleccionada.Cells[2].Value.ToString();
                //Activar la opción de borrar
                btnBorrar.Enabled = true;
                btnActualizar.Enabled = true;
                btnGuardar.Enabled = false;
            }

        }*/

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Obtener los datos actualizados de las cajas de texto
            int edad = int.Parse(textEdad.Text);
            string nombre = textNombre.Text;
            string correo = textCorreo.Text;
            // Buscar el objeto correspondiente en la lista y actualizar sus propiedades
            Alumnos alumnos = LAlumnos.Find(a => a.Nombre == nombre);
            alumnos.Correo = correo;
            alumnos.Edad = edad;
            //Indicamos que se realizo la tarea y desactivamos botones
            MessageBox.Show("Registro actualizado correctamente.");
            LimpiarCajas();
            btnActualizar.Enabled = false;
            btnGuardar.Enabled = true;
            btnBorrar.Enabled = false;
        }
        // Eliminamos un registro seleccionado
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Paremetro de bsuqueda que se queire borrar
            string nombre = textNombre.Text;
            // Buscar el objeto correspondiente en la lista y actualizar sus propiedades
            Alumnos alumnos = LAlumnos.Find(a => a.Nombre == nombre);
            LAlumnos.Remove(alumnos);

            //Indicamos que se realizo la tarea y desactivamos botones
            MessageBox.Show("Se elimino el registros");
            LimpiarCajas();
            btnActualizar.Enabled = false;
            btnGuardar.Enabled = true;
            btnBorrar.Enabled = false;
        }
    }
}