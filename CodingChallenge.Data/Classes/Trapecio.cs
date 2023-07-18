using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : IFormaGeometrica
    {
        public decimal lado;

        public Trapecio(decimal lado)
        {
            this.lado = lado;
        }
        public decimal CalcularArea()
        {
            return ((lado + lado*2)*(lado/2))/2;
        }

        public decimal CalcularPerimetro()
        {
            return lado + lado *2 + (lado-1)*2;
        }
        public TipoFormaGeometrica ObtenerTipo()
        {
            return TipoFormaGeometrica.Trapecio;
        }
    }
}
