using Microsoft.VisualBasic;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }


        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número
            if (!char.IsDigit(e.KeyChar))
            {
                // Si no es un número, cancelar la entrada
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra
            if (!char.IsLetter(e.KeyChar))
            {
                // Si no es una letra, cancelar la entrada
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra
            if (!char.IsLetter(e.KeyChar))
            {
                // Si no es una letra, cancelar la entrada
                e.Handled = true;
            }
        }

        private void TGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está incompleto
            if (string.IsNullOrEmpty(TDni.Text) || string.IsNullOrEmpty(TApellido.Text) || string.IsNullOrEmpty(TNombre.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar un mensaje de consulta
            MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // Verificar si el usuario seleccionó "Sí"
            if (ask == MsgBoxResult.Yes)
            {
                // Insertar un nuevo cliente
                // ...
            }

            // Obtener los valores de los campos TNombre y TApellido
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;

            // Actualizar el contenido del label Lmodificar con el nombre y apellido del usuario
            LModificar.Text = nombre + " " + apellido;

            // Mostrar un mensaje de información con el nombre del cliente
            MessageBox.Show("El Cliente: " + nombre + " " + apellido + " se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TEliminar_Click(object sender, EventArgs e)
        {

            // Obtener los valores de los campos TNombre y TApellido
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;

            // Mostrar un mensaje de advertencia
            MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Está apunto de eliminar el Cliente: " + nombre + " " + apellido, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            // Verificar si el usuario seleccionó "Sí"
            if (ask == MsgBoxResult.Yes)
            {
                MessageBox.Show("El Cliente: " + nombre + " " + apellido + "se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar los campos
                TDni.Clear();
                TNombre.Clear();
                TApellido.Clear();
                LModificar.Text = "";
            }
        }


    }
}