using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Empleado : Persona
    {
        private Supervisor supervisor;
       

        public Empleado(Supervisor supervisor, string nombre,int aniosDeAntiguedad, string apellido, int dni, string direccion, int edad, double salario, int telefono) : base(aniosDeAntiguedad, nombre, apellido, dni, direccion,  edad,  salario,  telefono)

        {
            this.supervisor = supervisor;
            this.supervisor.agregarEmpleado(this);
           
        }

        public override void incrementarSalario()
        {
            double salarioAnterior = this.salario;
            double aumentoPorAntiguedad = 0.01 * this.aniosDeAntiguedad;
            double aumentoTotal = (1.1 + aumentoPorAntiguedad) * this.salario;
            double aumentoExtra = (1.1 + aumentoPorAntiguedad + 0.05) * this.salario;
            double aumentoTotalPorcentaje = ((1.1 + aumentoPorAntiguedad) * 100) - 100;
            double aumentoExtraPorcentaje = ((1.1 + aumentoPorAntiguedad + 0.05) * 100) - 100;
            int anioActual = Int32.Parse(DateTime.Now.Year.ToString());
            int anioDeNacimiento = anioActual - this.edad;
            if (this.aniosDeAntiguedad == 0 && anioDeNacimiento < 1964)
            {
                this.salario *= 1.15;
                Console.WriteLine(this.mensajeAumentoDeSalario(this.nombre, this.apellido, salarioAnterior, this.salario, 15));
            }
            else if(this.aniosDeAntiguedad == 0)
            {
                this.salario *= 1.1;
                Console.WriteLine(this.mensajeAumentoDeSalario(this.nombre, this.apellido, salarioAnterior, this.salario, 10));
            }
            else if (anioDeNacimiento < 1964)
            {
                this.salario = aumentoExtra;
                Console.WriteLine(this.mensajeAumentoDeSalario(this.nombre, this.apellido, salarioAnterior, this.salario, aumentoExtraPorcentaje));
            }
            else
            {
                this.salario = aumentoTotal;
                Console.WriteLine(this.mensajeAumentoDeSalario(this.nombre, this.apellido, salarioAnterior, this.salario, aumentoTotalPorcentaje));
            }            
        }

        public void cambiarSupervisor(Supervisor supervisor)
        {
            if(this.supervisor != supervisor)
            {
                Supervisor supervisorAnterior = this.supervisor;
                this.supervisor = supervisor;
                Console.WriteLine(this.nombre + " " + this.apellido + " cambió de supervisor. Supervisor anterior: " + supervisorAnterior.getNombre() + ". Nuevo supervisor: " + this.supervisor.getNombre() + ".");
                supervisorAnterior.quitarEmpleadoDeLista(this);
                this.supervisor.agregarEmpleado(this);
            }
            else
            {
                Console.WriteLine("El empleado " + this.getNombre() + " no puede cambiar de supervisor porque ya se encuentra bajo el cargo de " + this.supervisor.getNombre());
            }
        }

        public string mostrarSupervisor()
        {
             return "Mi supervisor es: " + this.supervisor.getNombre();
        }
    }
}
