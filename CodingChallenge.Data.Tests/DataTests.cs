using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Interface;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometricaService.Imprimir(new List<IFormaGeometrica>(), Idioma.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometricaService.Imprimir(new List<IFormaGeometrica>(), Idioma.Ingles));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometricaService.Imprimir(cuadrados, Idioma.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometricaService.Imprimir(cuadrados, Idioma.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero (4),
                new Cuadrado(2),
                new TrianguloEquilatero (9),
                new Circulo(2.75m),
                new TrianguloEquilatero (4.2m)
            };

            var resumen = FormaGeometricaService.Imprimir(formas, Idioma.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Cuadrado (2),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m)
            };

            var resumen = FormaGeometricaService.Imprimir(formas, Idioma.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnPortugues()
        {
            Assert.AreEqual("<h1>Lista vazia de formas!</h1>",
                FormaGeometricaService.Imprimir(new List<IFormaGeometrica>(), Idioma.Portugues));
        }

        [TestCase]
        public void TestResumenListaConMasRectangulosEnPortugues()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo (8),
                new Rectangulo (4),
                new Rectangulo (9),
            };

            var resumen = FormaGeometricaService.Imprimir(formas, Idioma.Portugues);

            Assert.AreEqual("<h1>Relatório de formas</h1>3 Retângulos | Area 80,5 | Perimetro 63 <br/>TOTAL:<br/>3 formas Perimetro 63 Area 80,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapeciosEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Trapecio(6),
                new Trapecio(3)
            };

            var resumen = FormaGeometricaService.Imprimir(formas, Idioma.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Trapecios | Area 33,75 | Perimetro 41 <br/>TOTAL:<br/>2 formas Perimetro 41 Area 33,75", resumen);
        }
    }
}
