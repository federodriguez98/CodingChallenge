/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using Castle.Core.Resource;
using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interface;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometricaService
    {
        private static ResourceManager _resourceManager;
        public static string Imprimir(List<IFormaGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            _resourceManager = new ResourceManager("CodingChallenge.Data.Resources.Palabras", Assembly.GetExecutingAssembly());
            var a = IdiomaManager.GetDisplayName(idioma);
            if (_resourceManager != null)
            {
                if (!formas.Any())
                {
                    sb.Append(_resourceManager.GetString("ListaVacia", new CultureInfo(IdiomaManager.GetDisplayName(idioma))));

                }
                else
                {
                    // Hay por lo menos una forma
                    // HEADER
                    sb.Append(_resourceManager.GetString("TituloReporte", new CultureInfo(IdiomaManager.GetDisplayName(idioma))));

                    List<TipoFormaGeometrica> tiposFormasGeometricas = formas.Select(x => x.ObtenerTipo()).Distinct().ToList();

                    foreach (var tipo in tiposFormasGeometricas)
                    {
                        var numeroCuadrados = formas.FindAll(x => x.ObtenerTipo() == tipo).Count;
                        var areaCuadrados = formas.FindAll(x => x.ObtenerTipo() == tipo).ToList().Sum(x => x.CalcularArea());
                        var perimetroCuadrados = formas.FindAll(x => x.ObtenerTipo() == tipo).ToList().Sum(x => x.CalcularPerimetro());
                        sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, tipo, IdiomaManager.GetDisplayName(idioma)));

                    }

                    var totalFormas = formas.Count;
                    var totalArea = formas.Sum(x => x.CalcularArea());
                    var totalPerimetro = formas.Sum(x => x.CalcularPerimetro());
                    //// FOOTER
                    sb.Append("TOTAL:<br/>");
                    sb.Append(totalFormas + " " + _resourceManager.GetString("Formas", new CultureInfo(IdiomaManager.GetDisplayName(idioma))) + " ");
                    sb.Append(_resourceManager.GetString("Perimetro", new CultureInfo(IdiomaManager.GetDisplayName(idioma))) + " " + totalPerimetro.ToString("#.##") + " ");
                    sb.Append(_resourceManager.GetString("Area", new CultureInfo(IdiomaManager.GetDisplayName(idioma))) + " " + totalArea.ToString("#.##"));
                }

                return sb.ToString();
            }
            else
            {
                return "No existe el idioma";
            }
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, TipoFormaGeometrica tipo, string idioma)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | {_resourceManager.GetString("Area",new CultureInfo(idioma))} {area:#.##} | {_resourceManager.GetString("Perimetro", new CultureInfo(idioma))} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        private static string TraducirForma(TipoFormaGeometrica tipo, int cantidad, string idioma)
        {
            if(cantidad > 1)
            {
                return _resourceManager.GetString(TipoFormaGeometricaManager.GetDisplayName(tipo) + "Plural", new CultureInfo(idioma));
            }
            else
            {
                return _resourceManager.GetString(TipoFormaGeometricaManager.GetDisplayName(tipo), new CultureInfo(idioma));
            }
        }
    }
}

