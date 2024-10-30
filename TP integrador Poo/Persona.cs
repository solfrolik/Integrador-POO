using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_integrador_Poo
{
   public class Persona
   {
      //Constructor 
      public Persona(string Nombre, string Apellido, string DNI, DateTime FechaAlta)
      {
         this.Nombre = Nombre;
         this.Apellido = Apellido;
         this.DNI = DNI;
         this.FechaAlta = FechaAlta;

      }
        
        //Atributos de la clase persona
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DateTime FechaAlta { get; set; } 

      //Metodo para calcular la antiguedad

      public string CalcularAntiguedad()
      {
         DateTime hoy = DateTime.Now;
         int años = hoy.Year - this.FechaAlta.Year;
         int meses = hoy.Month - this.FechaAlta.Month;
         int días = hoy.Day - this.FechaAlta.Day;  

         if(días < 0)
         {
            meses--;
            días += DateTime.DaysInMonth(this.FechaAlta.Year, this.FechaAlta.Month);
         }
         if(meses < 0)
         {
            años--;
            meses += 12;
         }

         return $"{años} años, {meses} meses, {días} días";
      }
      public override string ToString()
      {
         return $"{this.Nombre} - {this.Apellido} - {this.DNI}";
      }

   }
}
