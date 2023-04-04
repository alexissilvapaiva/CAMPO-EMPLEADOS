using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Persona 
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        private string direccion;
        protected int edad;
        protected double salario;
        private int telefono;
        protected int aniosDeAntiguedad;


        public Persona(int aniosDeAntiguedad, string nombre, string apellido, int dni, string direccion, int edad, double salario, int telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
            this.salario = salario;
            this.dni = dni;
            this.telefono = telefono;
            this.apellido = apellido;
            this.aniosDeAntiguedad = aniosDeAntiguedad;
        }

        public string presentarse()
        {
            return "Mi nombre es " + this.nombre + " " + this.apellido;
        }

        public string getNombre()
        {
            return this.nombre + " " + this.apellido;
        }

        public double getSalario()
        {
            return this.salario;
        }

        public int getDni()
        {
            return this.dni;
        }

        public virtual void incrementarSalario()
        {
            this.salario *= 1;
        }

        public string mensajeAumentoDeSalario(string nombre, string apellido, double salarioAnterior, double salarioActual, double aumento)
        {
            return "El salario de " + nombre + " " + apellido + " se aumentó un " + Math.Round(aumento) + "%. Salario anterior: $" + salarioAnterior + ". Nuevo salario: $" + String.Format("{0:.##}", salarioActual);
        }

    }
}
