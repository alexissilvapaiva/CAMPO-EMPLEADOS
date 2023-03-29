using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Secretario : Persona
    {
        public Secretario(int aniosDeAntiguedad,  string nombre, string apellido, int dni, string direccion, int edad, double salario, int telefono) : base(aniosDeAntiguedad, nombre, apellido, dni, direccion, edad, salario, telefono)
        {

        }
        
    }
}
