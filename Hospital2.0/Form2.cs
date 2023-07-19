using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Hospital2._0
{
    public partial class txtSearch : Form
    {
        //Inicializamos los doctores
        private List<Doctor> doctores;
        public txtSearch()
        {
            InitializeComponent();
            doctores = ListarDoctores();
        }

        //Cada vez que hagamos una accion en la tabla la refrescamos
        private void Form2_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            //Mostrar la lista de pacientes en la tabla
            TableDoctor.DataSource = null;
            TableDoctor.DataSource = doctores;
        }

        //Creamos pacientes de los valores
        private List<Doctor> ListarDoctores()
        {
            var list = new List<Doctor>();
            list.Add(new Doctor()
            {
                Nombre = "Fernando",
                Apellido = "Costa",
                Especialidad = "Cardiologia",
                Edad = "55",
            });

            list.Add(new Doctor()
            {
                Nombre = "Sara",
                Apellido = "Ruiz",
                Especialidad = "Hemoterapia",
                Edad = "28",
            });

            list.Add(new Doctor()
            {
                Nombre = "Sandra",
                Apellido = "Herreras",
                Especialidad = "Geriatria",
                Edad = "42",
            });

            list.Add(new Doctor()
            {
                Nombre = "Wintop",
                Apellido = "El mejore",
                Especialidad = "Todas las especialidades",
                Edad = "21",
            });

            return list;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            //Cuando clicka en el boton saldra de la aplicacion
            meExit();
        }

        //Metodo para salir del programa 
        private void meExit()
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirma si quieres salir", "Hospital 2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Close();
            }
        }

        //Metodo para validar los campos de los formularios
        private void add_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string especialidad = TxtEspecialidad.Text;
            string edad = TxtEdad.Text;
            string mensaje = "";
            bool check = true;

            if (nombre == "")
            {
                mensaje = "Nombre no puede estar vacio";
                check = false;
            }
            else if (apellido == "")
            {
                mensaje = "Edad no puede ser menor que 0";
                check = false;
            }
            else if (especialidad == "")
            {
                mensaje = "Adresa no puede estar vacio";
                check = false;
            }
            else if (edad == "")
            {
                mensaje = "Doctor no puede estar vacio";
                check = false;
            }
            if (!check)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Doctor nuevoDoctor = new Doctor(nombre, apellido, especialidad, edad);
                doctores.Add(nuevoDoctor);

                RefreshGrid();
                LimpiarCeldas();
            }
        }

        //Cuando se añaden campos se limpia la celda
        private void LimpiarCeldas()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtEspecialidad.Text = "";
            TxtEdad.Text = "";
        }


        private void viewDoctors_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        //Metodo para eliminar la celda selecionada
        private void Delete_Click_1(object sender, EventArgs e)
        {
            if (TableDoctor.SelectedRows.Count > 0)
            {
                Doctor doctorSelecionado = TableDoctor.SelectedRows[0].DataBoundItem as Doctor;
                doctores.Remove(doctorSelecionado);
                RefreshGrid();
                LimpiarCeldas();
            }
        }

        //Metodo para actualizar datos del doctor

        private void Update_Click_1(object sender, EventArgs e)
        {
            Doctor doctorSelecionado = TableDoctor.SelectedRows[0].DataBoundItem as Doctor;

            doctorSelecionado.Nombre = TxtNombre.Text;
            doctorSelecionado.Apellido = TxtApellido.Text;
            doctorSelecionado.Especialidad = TxtEspecialidad.Text;
            doctorSelecionado.Edad = TxtEdad.Text;

            RefreshGrid();
            LimpiarCeldas();
        }

        //Metodo para buscar doctor
        private void buscarDoctor()
        {
            string filtro = textSearch.Text.ToLower();

            var filtroDoctores = doctores.Where(doctor => doctor.Nombre.ToLower().Contains(filtro)).ToList();

            TableDoctor.DataSource = null;
            TableDoctor.DataSource = filtroDoctores;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buscarDoctor();
        }
    }
}
