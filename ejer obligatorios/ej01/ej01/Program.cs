using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta();
            string linea;
            double montoIngresar,montoRetirar;

            Console.WriteLine("Información inicial de la cuenta:");
            Console.WriteLine("Titular:" + cuenta.titular);
            Console.WriteLine("Cantidad:" + cuenta.cantidad);


            Console.Write("Ingrese monto a ingresar:");
            linea = Console.ReadLine();
            montoIngresar = int.Parse(linea);
            cuenta.ingresar(montoIngresar);
            Console.WriteLine("Nuevo saldo después del ingreso: " + cuenta.cantidad);

            Console.WriteLine("Ingrese monto a retirar:");
            linea = Console.ReadLine();
            montoRetirar = int.Parse(linea);
            cuenta.retirar(montoRetirar);
            Console.WriteLine("Nuevo saldo después del retiro: " + cuenta.cantidad);

        }

        class Cuenta
        {
            public Cuenta()
            {
                titular = "Juan Ojeda";
                cantidad = 1000;
            }

            public void ingresar(double monto)
            {
                if (monto > 0)
                {
                    cantidad += monto;
                }
            }

            public void retirar(double monto)
            {
                if (monto >= 0)
                {
                    cantidad -= monto;
                    if (cantidad < 0)
                    {
                        cantidad = 0;
                    }
                }
            }

            public string titular;
            public double cantidad;
        }
    }
}