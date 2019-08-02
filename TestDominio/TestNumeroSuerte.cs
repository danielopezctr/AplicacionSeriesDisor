using System;
using Xunit;
using Dominio;

namespace TestDominio
{
    public class TestNumeroSuerte
    {
        [Fact]
        public void Avanzar1()
        {
            NumeroSuerte numeroSuerte = new NumeroSuerte();
            numeroSuerte.Avanzar();
            long valorActual = numeroSuerte.getTermino();
            Assert.Equal(1,valorActual);
        }

        [Fact]
        public void Avanzar2()
        {
            NumeroSuerte numeroSuerte = new NumeroSuerte();
            numeroSuerte.Avanzar();
            numeroSuerte.Avanzar();
            long valorActual = numeroSuerte.getTermino();
            Assert.Equal(3, valorActual);
        }
        [Fact]
        public void Avanzar3()
        {
            NumeroSuerte numeroSuerte = new NumeroSuerte();
            numeroSuerte.Avanzar();
            numeroSuerte.Avanzar();
            numeroSuerte.Avanzar();
            long valorActual = numeroSuerte.getTermino();
            Assert.Equal(7, valorActual);
        }

        [Fact]
        public void Avanzar3Retroceder1()
        {
            NumeroSuerte numeroSuerte = new NumeroSuerte();
            numeroSuerte.Avanzar();
            numeroSuerte.Avanzar();
            numeroSuerte.Avanzar();
            numeroSuerte.Retroceder();
            long valorActual = numeroSuerte.getTermino();
            Assert.Equal(3, valorActual);
        }
        [Fact]
        public void Avanzar3Retroceder2()
        {
            NumeroSuerte numeroSuerte = new NumeroSuerte();
            numeroSuerte.Avanzar();
            numeroSuerte.Avanzar();
            numeroSuerte.Avanzar();
            numeroSuerte.Retroceder();
            numeroSuerte.Retroceder();
            long valorActual = numeroSuerte.getTermino();
            Assert.Equal(1, valorActual);
        }
        [Fact]
        public void Avanzar3Retroceder3()
        {
            NumeroSuerte numeroSuerte = new NumeroSuerte();
            numeroSuerte.Avanzar();
            numeroSuerte.Avanzar();
            numeroSuerte.Avanzar();
            numeroSuerte.Retroceder();
            numeroSuerte.Retroceder();
            numeroSuerte.Retroceder();
            long valorActual = numeroSuerte.getTermino();
            Assert.Equal(0, valorActual);
        }
        [Fact]
        public void Avanzar3Retroceder4()
        {
            NumeroSuerte numeroSuerte = new NumeroSuerte();
            numeroSuerte.Avanzar();
            numeroSuerte.Avanzar();
            numeroSuerte.Avanzar();
            numeroSuerte.Retroceder();
            numeroSuerte.Retroceder();
            numeroSuerte.Retroceder();
            long valorActual = numeroSuerte.getTermino();
            Assert.Equal(0, valorActual);
        }
    }
}
