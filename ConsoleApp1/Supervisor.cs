using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Supervisor : Persona
    {
        private string despacho;
        private Secretario secretario;
        private Auto auto;

        public Supervisor(string despacho, Auto auto, Secretario secretario, string nombre, string apellido, int dni, string direccion, int edad, double salario, int telefono) : base(nombre, apellido, dni, direccion, edad, salario, telefono)

        {
            this.secretario = secretario;
            this.auto = auto;
            this.despacho = despacho;
        }

        public override void incrementarSalario()
        {
            this.salario *= 1.2;
        }

        public double mostrarSalario()
        {
            return this.salario;
        }

        public void cambiarAuto(Auto auto)
        {
            this.auto = auto;
        }

        public string mostrarMiAuto()
        {
            return this.auto.mostrarModelo();
        }

        public void cambiarSecretario(Secretario secretario)
        {
            this.secretario = secretario;
        }
    }
}

