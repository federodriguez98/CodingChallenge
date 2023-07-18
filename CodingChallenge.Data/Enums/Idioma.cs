using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodingChallenge.Data.Enums
{
    public class IdiomaManager : BaseEnumManager<Idioma> { }
    public enum Idioma
    {
        [Display(Name = "ca")]
        Castellano = 1,
        [Display(Name = "en")]
        Ingles = 2,
        [Display(Name = "pt")]
        Portugues = 3
    }
}
