using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : IFormaGeometrica
    {
        public decimal lado;

        public Circulo(decimal lado)
        {
            this.lado = lado;
        }
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (lado / 2) * (lado / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * lado;
        }
        public TipoFormaGeometrica ObtenerTipo()
        {
            return TipoFormaGeometrica.Circulo;
        }
    }
}
