using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Data
{
    public class dtAntecedentes
    {
        //atributos
        private int codAntecedentes;
        private int codPersona;
        private string diabetico;
        private string hipertenso;
        private string cardiaco;
        private string lagrimeo;
        private string otros;
        private string alergicoA;
        private string medicamento;
        private string anestesico;
        private string medicamentoU;


        // metodos getters y setters
        public int CodAntecedentes
        {
            get
            {
                return codAntecedentes;
            }

            set
            {
                codAntecedentes = value;
            }
        }

        public int CodPersona
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

        public string Diabetico
        {
            get
            {
                return diabetico;
            }

            set
            {
                diabetico = value;
            }
        }

        public string Hipertenso
        {
            get
            {
                return hipertenso;
            }

            set
            {
                hipertenso = value;
            }
        }

        public string Cardiaco
        {
            get
            {
                return cardiaco;
            }

            set
            {
                cardiaco = value;
            }
        }

        public string Lagrimeo
        {
            get
            {
                return lagrimeo;
            }

            set
            {
                lagrimeo = value;
            }
        }

        public string Otros
        {
            get
            {
                return otros;
            }

            set
            {
                otros = value;
            }
        }

        public string AlergicoA
        {
            get
            {
                return alergicoA;
            }

            set
            {
                alergicoA = value;
            }
        }

        public string Medicamento
        {
            get
            {
                return medicamento;
            }

            set
            {
                medicamento = value;
            }
        }

        public string Anestesico
        {
            get
            {
                return anestesico;
            }

            set
            {
                anestesico = value;
            }
        }

        public string MedicamentoU
        {
            get
            {
                return medicamentoU;
            }

            set
            {
                medicamentoU = value;
            }
        }
    }
}
