using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        public decimal lado;

        public TrianguloEquilatero(decimal lado)
        {
            this.lado = lado;
        }
        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * lado * lado;
        }

        public decimal CalcularPerimetro()
        {
            return lado * 3;
        }
        public TipoFormaGeometrica ObtenerTipo()
        {
            return TipoFormaGeometrica.TrianguloEquilatero;
        }
    }
}
