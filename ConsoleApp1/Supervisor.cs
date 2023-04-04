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
        private List<Empleado> listaDeEmpleados = new List<Empleado>();

        public Supervisor(int aniosDeAntiguedad, string despacho, Auto auto, Secretario secretario, string nombre, string apellido, int dni, string direccion, int edad, double salario, int telefono) : base(aniosDeAntiguedad, nombre, apellido, dni, direccion, edad, salario, telefono)
        {
            this.secretario = secretario;
            this.auto = auto;
            this.despacho = despacho;
        }

        public override void incrementarSalario()
        {
            double salarioAnterior = this.salario;
            double cantidadDeEmpleados = this.listaDeEmpleados.Count();
            double aumentoPorAntiguedad = 0.01 * this.aniosDeAntiguedad;
            double aumentoExtra = (1.2 + aumentoPorAntiguedad) * this.salario;
            double aumentoExtraFormat = ((1.2 + aumentoPorAntiguedad) * 100) - 100;
            if (cantidadDeEmpleados == 0 && this.aniosDeAntiguedad == 0){
                this.salario *= 1.2;
                Console.WriteLine(this.mensajeAumentoDeSalario(this.nombre, this.apellido, salarioAnterior, this.salario, 20));
            } else if (cantidadDeEmpleados == 0){
                this.salario = aumentoExtra;
                Console.WriteLine(this.mensajeAumentoDeSalario(this.nombre, this.apellido, salarioAnterior, this.salario, aumentoExtraFormat));
            } else {
                double cantidadDeEmpleadosDouble = Convert.ToDouble(this.listaDeEmpleados.Count()) / 100;
                double aumentoPorEmpleados = (1.2 + aumentoPorAntiguedad + cantidadDeEmpleadosDouble) * this.salario;
                double aumentoPorEmpleadosPorcentaje = ((1.2 + aumentoPorAntiguedad + cantidadDeEmpleadosDouble) * 100) - 100;
                this.salario = aumentoPorEmpleados;
                Console.WriteLine(this.mensajeAumentoDeSalario(this.nombre, this.apellido, salarioAnterior, this.salario, aumentoPorEmpleadosPorcentaje));
            }
        }

        public double mostrarSalario()
        {
            return this.salario;
        }

        public void agregarEmpleado(Empleado empleado)
        {
            Empleado findedEmployee = this.listaDeEmpleados.Find(e => e.getDni() == empleado.getDni());
            if (findedEmployee == null){
                this.listaDeEmpleados.Add(empleado);
                Console.WriteLine("Se agregó el empleado " + empleado.getNombre() + " bajo el cargo del supervisor " + this.getNombre() + ".");
            } else {
                Console.WriteLine("No se puede agregar el empleado " + empleado.getNombre() + " a la lista porque ya se encuentra en ella.");
            }     
        }

        public void cambiarAuto(Auto auto)
        {
            if(this.auto.getMatricula() != auto.getMatricula()) { 
                Auto autoAnterior = this.auto;
                this.auto = auto;
                Console.WriteLine("Se realizó un cambio en el auto de " + this.nombre + " " + this.apellido + ". Auto anterior: " + autoAnterior.getDatosAuto() + ". Nuevo auto: " + this.auto.getDatosAuto() + ".");
            } else{
                Console.WriteLine("No se puede cambiar el auto de " + this.getNombre() + " porque ya lo tiene asignado.");
            }
            
        }

        /*public string mostrarMiAuto()
        {
            return this.auto.getDatosAuto();
        }*/
        public void mostrarEmpleados()
        {
            if(this.listaDeEmpleados.Count() != 0)
            {
                Console.WriteLine("Empleados de " + this.getNombre() + ":");
                this.listaDeEmpleados.ForEach(empleado => {
                    Console.WriteLine("-" + empleado.getNombre());
                });
            }
            else { 
                Console.WriteLine("El supervisor " + this.getNombre() + " no tiene empleados a su cargo"); 
            }
        }

        public void quitarEmpleadoDeLista(Empleado empleado)
        {
            try {
                Empleado findedEmployee = this.listaDeEmpleados.Find(e => e.getDni() == empleado.getDni());
                if (findedEmployee == null)
                {
                    throw new ArgumentNullException("ERROR - No se puede quitar a " + empleado.getNombre() + " de la lista ya que no se encuentra bajo el cargo de " + this.getNombre());
                }
                this.listaDeEmpleados.Remove(findedEmployee);
                Console.WriteLine(this.getNombre() + " ya no es el supervisor de " + findedEmployee.getNombre() + ". Éxitos con tu nuevo supervisor!");
            } catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
            
        }

        public void cambiarSecretario(Secretario secretario)
        {
            if(this.secretario.getDni() != secretario.getDni()) {
                Secretario secretarioAnterior = this.secretario;
                this.secretario = secretario;
                Console.WriteLine(this.nombre + " " + this.apellido + " cambió de secretario. Secretario anterior: " + secretarioAnterior.getNombre() + ". Nuevo secretario: " + this.secretario.getNombre() + "."); 
            } else {
                Console.WriteLine("El supervisor " + this.getNombre() + " no puede cambiar de secretario porque ya lo tiene a su cargo.");
            }
        }

        public void sumatoriaSueldoEmpleados()
        {
            double sumatoriaSueldoEmpleados = this.listaDeEmpleados.Sum(empleado => empleado.getSalario());
            Console.WriteLine("La suma de los sueldos de los empleados de " + this.getNombre() + " es: $" + String.Format("{0:.##}", sumatoriaSueldoEmpleados));
        }
    }
}

