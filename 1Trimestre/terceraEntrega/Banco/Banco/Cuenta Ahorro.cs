using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Cuenta_Ahorro : Cuenta
    {
        protected double cuotaMantenimiento;

        //Constructores
        public Cuenta_Ahorro() : base()
        {
            setCuotaMantenimiento(0);
        }

        public Cuenta_Ahorro(string numCuenta, string nombre, double saldo, double tipoInteres, double cuotaMantenimiento) : base(numCuenta, nombre, saldo, tipoInteres)
        {
            setCuotaMantenimiento(cuotaMantenimiento);
        }

        //Sets y gets
        public void setCuotaMantenimiento(double cuotaMantenimiento)
        {
            this.cuotaMantenimiento = cuotaMantenimiento;
        }

        public double getCuotaMantenimiento()
        {
            return cuotaMantenimiento;
        }

        //Métodos
        public new void printEstado()
        {
            base.printEstado();
            Console.WriteLine("Cuota de mantenimiento: " + getCuotaMantenimiento());
        }
    }
}
