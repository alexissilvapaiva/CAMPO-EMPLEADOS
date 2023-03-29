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
        private List<Empleado> listaDeEmpleado = new List<Empleado>();

        public Supervisor(int aniosDeAntiguedad, string despacho, Auto auto, Secretario secretario, string nombre, string apellido, int dni, string direccion, int edad, double salario, int telefono) : base(aniosDeAntiguedad, nombre, apellido, dni, direccion, edad, salario, telefono)

        {
            this.secretario = secretario;
            this.auto = auto;
            this.despacho = despacho;
        }

        //Para evitar el código duplicado podríamos pasarle por parámetro el porcentaje de aumento en el método de
        //la clase padre, esto nos daría un poco más de libertad en caso de que los valores de aumento cambien.
        //Como los aumentos son fijos también se podrían agregar como atributos de las clases. 
        public override void incrementarSalario()
        {
            double salarioAnterior = this.salario;
            this.salario *= 1.2;
            Console.WriteLine("El salario de " + this.nombre + " " + this.apellido + " se aumentó un 20%. Salario anterior: $" + salarioAnterior + ". Nuevo salario: $" + this.salario + ".");
        }

        public double mostrarSalario()
        {
            return this.salario;
        }

       /* public int contarEmpleados()
        {
            int cantidadDeEmpleados = 
        }*/

        public void agregarEmpleado(Empleado empleado)
        {
            this.listaDeEmpleado.Add(empleado);
            Console.WriteLine("Se agregó el empleado: " + empleado.getNombre);
        }

        public void cambiarAuto(Auto auto)
        {
            Auto autoAnterior = this.auto;
            this.auto = auto;
            Console.WriteLine("Se realizó un cambio en el auto de " + this.nombre + " " + this.apellido + ". Auto anterior: " + autoAnterior.getDatosAuto() + ". Nuevo auto: " + this.auto.getDatosAuto() + ".");
        }

        public string mostrarMiAuto()
        {
            return this.auto.getDatosAuto();
        }

        public void cambiarSecretario(Secretario secretario)
        {
            Secretario secretarioAnterior = this.secretario;
            this.secretario = secretario;
            Console.WriteLine(this.nombre + " " + this.apellido + " cambió de secretario. Secretario anterior: " + secretarioAnterior.getNombre() + ". Nuevo secretario: " + this.secretario.getNombre() + ".");
        }
    }
}

