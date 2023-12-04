using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Cuenta
    {
        protected String numCuenta;
        protected String nombre;
        protected double saldo;
        protected double tipoInteres;

        //Constructores
        public Cuenta()
        {
            setNumCuenta("");
            setNombre("");
            setSaldo(0);
            setTipoInteres(0);
        }

        public Cuenta(string numCuenta, string nombre, double saldo, double tipoInteres)
        {
            setNumCuenta(numCuenta);
            setNombre(nombre);
            setSaldo(saldo);
            setTipoInteres(tipoInteres);
        }

        //Sets y gets
        public void setNumCuenta(String numCuenta)
        {
            this.numCuenta = numCuenta;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public void setTipoInteres(double tipoInteres)
        {
            this.tipoInteres = tipoInteres;
        }

        public String getNumCuenta()
        {
            return numCuenta;
        }

        public String getNombre()
        {
            return nombre;
        }   

        public double getSaldo()
        {
            return saldo;
        }

        public double getTipoInteres()
        {
            return tipoInteres;
        }

        //Métodos
        public void printEstado()
        {
            System.Console.WriteLine("Número de cuenta: \t" + numCuenta);
            System.Console.WriteLine("Nombre: \t\t" + nombre);
            System.Console.WriteLine("Saldo: \t\t\t" + saldo + " Euros");
            System.Console.WriteLine("Tipo de interés: \t" + tipoInteres + "%");
        }
    }
}
