using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Auto
    {
        private int matricula;
        private string marca;
        private string modelo;

        public Auto(int matricula, string marca, string modelo)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
        }

        public string mostrarModelo()
        {
            return this.modelo;
        }
    }
}
