using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital2._0
{
    public partial class Form1 : Form
    {
        //Inicializamos los pacientes
        private List<Paciente> pacientes;
        public Form1()
        {
            InitializeComponent();
            pacientes = ListarPacientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cada vez que hagamos una accion en la tabla la refrescamos
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            //Mostrar la lista de pacientes en la tabla
            TableHospital.DataSource = null;
            TableHospital.DataSource = pacientes;
        }

        private List<Paciente> ListarPacientes()
        {
            //Creamos pacientes de los valores
            var list = new List<Paciente>();
            list.Add(new Paciente()
            {
                Nombre = "Manolo",
                Edad = "55",
                Adresa = "Sin calle",
                Diagnosis = "Catarro",
                DoctorAsignado = "Paco"
            });

            list.Add(new Paciente()
            {
                Nombre = "Pau",
                Edad = "25",
                Adresa = "Calle principe",
                Diagnosis = "Estornudos",
                DoctorAsignado = "Fernando"
            });
            list.Add(new Paciente()
            {
                Nombre = "Carmen",
                Edad = "42",
                Adresa = "Sin calle",
                Diagnosis = "Covid19",
                DoctorAsignado = "Sandra"
            });
            list.Add(new Paciente()
            {
                Nombre = "Franesco",
                Edad = "30",
                Adresa = "Sin calle",
                Diagnosis = "Diarrea",
                DoctorAsignado = "Sara"
            });
            list.Add(new Paciente()
            {
                Nombre = "Carlos",
                Edad = "55",
                Adresa = "Sin calle",
                Diagnosis = "Mucosidad",
                DoctorAsignado = "Carmen"

            });
            list.Add(new Paciente()
            {
                Nombre = "Carlos",
                Edad = "55",
                Adresa = "Sin calle",
                Diagnosis = "Mucosidad",
                DoctorAsignado = "Lobo"
            });

            list.Add(new Paciente()
            {
                Nombre = "Alvaro",
                Edad = "20",
                Adresa = "Calle el Rey Wintop",
                Diagnosis = "Calvicie",
                DoctorAsignado = "Alex"
            });

            list.Add(new Paciente()
            {
                Nombre = "Pascal",
                Edad = "18",
                Adresa = "Calle fundacio",
                Diagnosis = "Demasiado bueno",
                DoctorAsignado = "Wintop"
            });

            return list;
        }

        private void TableHospital_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            //Cuando clicka en el boton saldra de la aplicacion
            MeExit();
        }

        //Metodo para salir del programa 
        private void MeExit()
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirma si quieres salir", "Hospital 2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(iExit == DialogResult.Yes)
            {
                Close();
            }
        }

        //Metodo para validar los campos de los formularios
        private void button1_Click(object sender, EventArgs e)
        {
            string name = TxtNombre.Text;
            string age =TxtEdad.Text;
            string adresa = TxtAdresa.Text;
            string doctor = TxtAsignado.Text;
            string diagnosis = TxtDiagnosis.Text;
            string mensaje = "";
            bool check = true; 

            if(name == "")
            {
                mensaje = "Nombre no puede estar vacio";
                check = false;
            }
            else if(age == "")
            {
                mensaje = "Edad no puede ser menor que 0";
                check = false;
            }
            else if(adresa == "")
            {
                mensaje = "Adresa no puede estar vacio";
                check = false;
            }
            else if(doctor == "")
            {
                mensaje = "Doctor no puede estar vacio";
                check = false;
            }
            else if(diagnosis == "")
            {
                mensaje = "Diagnosis no puede estar vacio";
                check = false;
            }
            if(!check)
            {
                MessageBox.Show(mensaje, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Paciente nuevoPaciente = new Paciente(name, age, adresa, diagnosis, doctor);
                pacientes.Add(nuevoPaciente);

                RefreshGrid();
                LimpiarCeldas();
            }

        }

        //Cuando se añaden campos se limpia la celda
        private void LimpiarCeldas()
        {
            TxtNombre.Text = "";
            TxtEdad.Text = "";
            TxtAdresa.Text = "";
            TxtAsignado.Text = "";
            TxtDiagnosis.Text = "";
        }

        //Metodo para eliminar la celda selecionada
        private void Delete_Click(object sender, EventArgs e)
        {
            if (TableHospital.SelectedRows.Count > 0)
            {
                Paciente pacienteSelecionado = TableHospital.SelectedRows[0].DataBoundItem as Paciente;
                pacientes.Remove(pacienteSelecionado);
                RefreshGrid();
                LimpiarCeldas();
            }
        }

        private void seccionDoctToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Metodo para actualizar la celda selecionada
        private void Update_Click(object sender, EventArgs e)
        {
            Paciente pacienteSelecionado = TableHospital.SelectedRows[0].DataBoundItem as Paciente;

            pacienteSelecionado.Nombre = TxtNombre.Text;
            pacienteSelecionado.Edad = TxtEdad.Text;
            pacienteSelecionado.Adresa = TxtAdresa.Text;
            pacienteSelecionado.Diagnosis = TxtDiagnosis.Text;
            pacienteSelecionado.DoctorAsignado = TxtAsignado.Text;

            RefreshGrid();
            LimpiarCeldas();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Boton para abrir otro formulario
        private void viewDoctors_Click(object sender, EventArgs e)
        {
            var form2 = new txtSearch();
            form2.Show();
            this.Hide();
        }

        //Filtro de los pacientes
        private void buscarPacientes()
        {
            string filtro = txtSearch.Text.ToLower();

            var filtroPacientes = pacientes.Where(paciente => paciente.Nombre.ToLower().Contains(filtro)).ToList();

            TableHospital.DataSource = null;
            TableHospital.DataSource = filtroPacientes;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            buscarPacientes();
        }
    }
}
