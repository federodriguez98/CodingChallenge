using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodingChallenge.Data.Enums
{
    public class TipoFormaGeometricaManager : BaseEnumManager<TipoFormaGeometrica> { }
    public enum TipoFormaGeometrica
    {
        [Display(Name = "Cuadrado")]
        Cuadrado = 1,
        [Display(Name = "TrianguloEquilatero")]
        TrianguloEquilatero = 2,
        [Display(Name = "Circulo")]
        Circulo = 3,
        [Display(Name = "Trapecio")]
        Trapecio = 4,
        [Display(Name = "Rectangulo")]
        Rectangulo = 5
    }
}
