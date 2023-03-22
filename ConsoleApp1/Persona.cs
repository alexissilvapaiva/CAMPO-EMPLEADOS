﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Persona 
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string direccion;
        private int edad;
        protected double salario;
        private int telefono;


        public Persona(string nombre, string apellido, int dni, string direccion, int edad, double salario, int telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
            this.salario = salario;
            this.dni = dni;
            this.telefono = telefono;
            this.apellido = apellido;
        }

        public string presentarse()
        {
            return "Mi nombre es " + this.nombre + " " + this.apellido;
        }

        public virtual void incrementarSalario()
        {
            this.salario *= 1;
        }

    }
}