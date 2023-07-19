using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital2._0
{
    public class Doctor
    {
        private string _nombre;
        private string _apellido;
        private string _especialidad;
        private string _edad;

        //Getters y setters
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

        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }
        public string Especialidad
        {
            get
            {
                return _especialidad;
            }
            set
            {
                _especialidad = value;
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

        // Constructores
        public Doctor(string nombre, string apellido, string especialidad, string edad)
        {
            _nombre = nombre;
            _apellido = apellido;
            _especialidad = especialidad;
            _edad = edad;
        }

        public Doctor()
        {

        }
    }

}
