using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Auto
    {
        private string matricula;
        private string marca;
        private string modelo;

        public Auto(string matricula, string marca, string modelo)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
        }

        public string getDatosAuto()
        {
            return this.marca + " " + this.modelo + ". Matrícula: " + this.matricula;
        }
    }
}
