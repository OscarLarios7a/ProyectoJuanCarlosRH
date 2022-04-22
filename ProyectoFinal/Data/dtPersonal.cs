using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Data
{
    public class dtPersonal
    {
        //atributos
        private int idPersona;
        private string codPersona;
        private string dni;
        private int edad;
        private string telefono;
        private string apellido;
        private string nombre;
        private string direccion;
        private string lNacimiento;
        private string ocupacion;
        private string procedencia;
        private string referido;
        private DateTime fNacimiento;

        //propiedades Getters y Setters
        public int IdPersona
        {
            get
            {
                return idPersona;
            }

            set
            {
                idPersona = value;
            }
        }

        public string CodPersona
        {
            get
            {
                return codPersona;
            }

            set
            {
                codPersona = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string LNacimiento
        {
            get
            {
                return lNacimiento;
            }

            set
            {
                lNacimiento = value;
            }
        }

        public string Ocupacion
        {
            get
            {
                return ocupacion;
            }

            set
            {
                ocupacion = value;
            }
        }

        public string Procedencia
        {
            get
            {
                return procedencia;
            }

            set
            {
                procedencia = value;
            }
        }

        public string Referido
        {
            get
            {
                return referido;
            }

            set
            {
                referido = value;
            }
        }

        public DateTime FNacimiento
        {
            get
            {
                return fNacimiento;
            }

            set
            {
                fNacimiento = value;
            }
        }

        

    }
}
