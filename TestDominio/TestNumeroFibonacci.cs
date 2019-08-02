using System;
using Xunit;
using Dominio;

namespace TestDominio
{
    public class TestNumeroFibonacci
    {
        [Fact]
        public void Inicializar()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(0, valorActual);
        }
        [Fact]
        public void Avanzar4()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(3, valorActual);
        }
        [Fact]
        public void Avanzar4Retrocede2()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(1, valorActual);
        }
        [Fact]
        public void Avanzar4Retrocede2Avanza2()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(3, valorActual);
        }
        [Fact]
        public void Avanzar7()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(13, valorActual);
        }
        [Fact]
        public void Avanzar10Retrocede2Avanza2()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(55, valorActual);
        }
        [Fact]
        public void Avanzar20()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(10946, valorActual);
        }
        [Fact]
        public void Avanzar20Retrocede10Avanza10()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(10946, valorActual);
        }
        [Fact]
        public void Avanzar50()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(20365011074, valorActual);
        }
        [Fact]
        public void Retroceder7()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(0, valorActual);
        }
        [Fact]
        public void Retroceder7Avanzar1()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Avanzar();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(1, valorActual);
        }
        [Fact]
        public void Retroceder7Avanzar3()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(2, valorActual);
        }
        [Fact]
        public void Retroceder7Avanzar7()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(13, valorActual);
        }
        [Fact]
        public void Avanzar1()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(1, valorActual);
        }
        [Fact]
        public void Avanzar1Retroceder1()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(0, valorActual);
        }
        [Fact]
        public void Avanzar1Retroceder2()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(0, valorActual);
        }
        [Fact]
        public void Avanzar1Retroceder7()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(0, valorActual);
        }
        [Fact]
        public void Avanzar3Retroceder7()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(0, valorActual);
        }
        [Fact]
        public void Avanzar4Retroceder2()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(1, valorActual);
        }
        [Fact]
        public void Avanzar7Retroceder2()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(5, valorActual);
        }
        [Fact]
        public void Avanzar14Retroceder2()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(144, valorActual);
        }
        [Fact]
        public void Avanzar4Retroceder4()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(0, valorActual);
        }
        [Fact]
        public void Avanzar4Retroceder5()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(0, valorActual);
        }
        [Fact]
        public void Avanzar4Retroceder3()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(1, valorActual);
        }
        [Fact]
        public void Avanzar4Retroceder2Avanzar3()
        {
            NumeroFibonacci numeroFibonacci = new NumeroFibonacci();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Retroceder();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            numeroFibonacci.Avanzar();
            long valorActual = numeroFibonacci.getTermino();
            Assert.Equal(5, valorActual);
        }
    }
}
