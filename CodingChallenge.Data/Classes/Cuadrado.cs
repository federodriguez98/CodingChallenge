using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : IFormaGeometrica
    {
        public decimal lado;

        public Cuadrado (decimal lado)
        {
            this.lado = lado;
        }
        public decimal CalcularArea()
        {
            return lado * lado;
        }

        public decimal CalcularPerimetro()
        {
            return lado * 4;
        }
        public TipoFormaGeometrica ObtenerTipo()
        {
            return TipoFormaGeometrica.Cuadrado;
        }
    }
}
