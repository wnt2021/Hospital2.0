using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Hospital2._0
{
    public class Paciente
    {
        private string _nombre;
        private string _edad;
        private string _adresa;
        private string _diagnosis;
        private string _DoctorAsignado;


        //Getters y setters
        public string DoctorAsignado
        {
            get
            {
                return _DoctorAsignado;
            }
            set
            {
                _DoctorAsignado = value;
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set 
            { 
                _nombre = value;
            }
        }

        public string Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
            }
        }

        public string Adresa
        {
            get
            {
                return _adresa;
            }
            set
            {
                _adresa = value;
            }
        }

        public string Diagnosis
        {
            get
            {
                return _diagnosis;
            }
            set
            {
                _diagnosis = value;
            }
        }

        //Constructores
        public Paciente(string nombre, string edad, string adresa, string diagnosis,string DoctorAsignado)
        {
            _nombre = nombre;
            _edad = edad;
            _adresa = adresa;
            _diagnosis = diagnosis;
            _DoctorAsignado = DoctorAsignado;
        }

        public Paciente()
        {
        }
    }
}
