using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuentaSinParametros;
            Cuenta cuentaConParametros;
            Cuenta_Ahorro cuentaAhorroSinParametros;
            Cuenta_Ahorro cuentaAhorroConParametros;

            cuentaSinParametros = new Cuenta();
            cuentaSinParametros.setNumCuenta("ES98 5674 7654 7439 7658492433");
            cuentaSinParametros.setNombre("Juan");
            cuentaSinParametros.setSaldo(90000);
            cuentaSinParametros.setTipoInteres(2.5);

            cuentaConParametros = new Cuenta("ES98 5674 7654 7439 7658492432", "Pepe", 1000, 1.5);

            cuentaAhorroSinParametros = new Cuenta_Ahorro();
            cuentaAhorroSinParametros.setNumCuenta("ES90 5674 7654 7439 7658497899");
            cuentaAhorroSinParametros.setNombre("Ana");
            cuentaAhorroSinParametros.setSaldo(11111111);
            cuentaAhorroSinParametros.setTipoInteres(3);
            cuentaAhorroSinParametros.setCuotaMantenimiento(0.90);

            System.Console.WriteLine("\nCuenta de ahorro creada con constructor con parámetros:");
            cuentaAhorroConParametros = new Cuenta_Ahorro("ES90 5674 7654 7439 7658492452", "Julia", 10, 2, 0.45);

            System.Console.WriteLine("\nCuenta creada con constructor sin parámetros, introduciendo datos con sets:");
            cuentaSinParametros.printEstado();

            System.Console.WriteLine("\nCuenta creada con constructor con parámetros:");
            cuentaConParametros.printEstado();

            System.Console.WriteLine("\nCuenta de ahorro creada con constructor sin parámetros, introduciendo datos con sets:");
            cuentaAhorroSinParametros.printEstado();

            System.Console.WriteLine("\nCuenta de ahorro creada con constructor con parámetros:");
            cuentaAhorroConParametros.printEstado();
        }
    }
}
