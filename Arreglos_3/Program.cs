using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_3
{
    class Program
    {
        //Declarar los dos vectores
        private string[] nombre;
        private float[] cal_quimica, cal_fisica;
        private float promedioquimica, promediofisica;
       
        //Realizar metodo para cargar calificaciones
        public void ingresardatos()
        {
            string lineaCaptura;
            cal_quimica = new float[5]; 
            cal_fisica = new float[5];
            nombre = new string[5];

            Console.WriteLine("Regristro de calificaciones para Alumnos\n");
            for (int i = 0; i<= 4; i++)
            {
                Console.WriteLine("Ingrese nombre del alumno No.  " + (i + 1) + ": ");
                nombre[i] = Console.ReadLine();

                Console.WriteLine("\nIngrese calificacion de Quimica: ");
                lineaCaptura = Console.ReadLine();

                cal_quimica[i] = float.Parse(lineaCaptura);
                Console.WriteLine("\nIngrese calificacion de Fisica: ");
                lineaCaptura = Console.ReadLine();
                cal_fisica[i] = float.Parse(lineaCaptura);
            }
        }

        //Metodo para calcular el promedio
        public void calcularpromedio()
        {
            float total =0;
            for (int i = 0; i <= 4; i++)
            {
                total = total + cal_quimica[i];
            }
            promedioquimica = total / 5;
            total = 0;
            for (int i = 0; i <= 4; i++)
            {
                total = total + cal_fisica[i];
            }
            promediofisica = total / 5;

            Console.WriteLine("La materia que tuvo el mayor promedio general fue ");
            if (promedioquimica > promediofisica)
            {
                Console.WriteLine("Quimica con " + promedioquimica);
            }
            else
            {
                Console.WriteLine("Fisica con " + promediofisica);
            }
            Console.ReadKey();
        }

       
        static void Main(string[] args)
        //Imprimir los metodos
        {
            Program calificaciones = new Program();
            calificaciones.ingresardatos();
            calificaciones.calcularpromedio();
            
            
        }
    }
}
