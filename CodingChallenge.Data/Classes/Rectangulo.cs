using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : IFormaGeometrica
    {
        public decimal lado;

        public Rectangulo(decimal lado)
        {
            this.lado = lado;
        }
        public decimal CalcularArea()
        {
            return lado * (lado/2);
        }

        public decimal CalcularPerimetro()
        {
            return (lado * 2) + lado ;
        }
        public TipoFormaGeometrica ObtenerTipo()
        {
            return TipoFormaGeometrica.Rectangulo;
        }
    }
}
