using System;
using System.Collections.Generic;
using System.Text;

namespace PracticasPersonales_Programacion2
{
    public class Ejercicio_CuentasBancarias
    {
        public class Cuenta : ICuenta
        {
            public int Id { get; set; }
            public string Titular { get; set; }
            public double Saldo { get; set; }
            public Cuenta(int id, string titular, double saldo)
            {
                Id = id;
                Titular = titular;
                Saldo = saldo;
            }
            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"ID: {Id}, Titular: {Titular}, Saldo: {Saldo}");
            }
        }

        public class CuentaAhorro : Cuenta
        {
            public int TasaInteres { get; set; }
            public CuentaAhorro(int id, string titular, double saldo, int tasaInteres) 
                : base(id, titular, saldo)
            {
                TasaInteres = tasaInteres;
            }
            public override void MostrarInformacion()
            {
                Console.WriteLine($"ID: {Id}, Titular: {Titular}, Saldo: {Saldo}, TasaInteres: {TasaInteres}");

            }
        }
        public class CuentaCorriente  : ICuenta
        {
            public int Id { get; set; }
            public string Titular { get; set; }
            public double Saldo { get; set; }
            public int LimiteDescbierto { get; set; }
            public CuentaCorriente(int id, string titular, double saldo, int limiteDescbierto)
            {
                Id = id;
                Titular = titular;
                Saldo = saldo;
                LimiteDescbierto = limiteDescbierto;
            }
            public  void MostrarInformacion()
            {
                Console.WriteLine($"ID: {Id}, Titular: {Titular}, LimiteDescubierto: {LimiteDescbierto}");

            }
        }

    }
}
