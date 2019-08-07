using System;
using System.Collections.Generic;
using System.Text;

namespace Entrelazo
{
    class Proyecto
    {
        #region Atributos

        #endregion

        #region Propiedades

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
        public double Salario { get; set; }
        public double Aumento { get; set; }
        public double Total { get; set; }

        #endregion

        #region Constructotes

        #endregion

        #region Metodos
        public void IngresarProyecto()
        {
            Console.WriteLine("Ingrese el Nombre del Empleado");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el Salario");
            Salario = double.Parse(Console.ReadLine());
        }

        public void ImprimirProyecto()
        {
            Console.WriteLine($"El Nombre es: {Nombre}");
            Console.WriteLine($"El Apellido es: {Apellido}");
            Console.WriteLine($"El salario es de: {Salario}");
        }
        public void AumentoS()
        {
            Aumento = (Salario * 0.1);
            Total = Aumento + Salario;
            Console.WriteLine($"El Aumento es de: {Aumento}");
            Console.WriteLine($"El el salario total es de: {Total}");
        }
        #endregion


    }
}
    

