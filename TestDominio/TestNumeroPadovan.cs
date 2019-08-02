using System;
using Xunit;
using Dominio;

namespace TestDominio
{
    public class TestNumeroPadovan
    {
        [Fact]
        public void Inicializar()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(0, valorActual);
        }
        [Fact]
        public void avanzar1()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            numeroPadovan.Avanzar();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(1, valorActual);
        }
        [Fact]
        public void avanzar2()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(1, valorActual);
        }
        [Fact]
        public void avanzar3()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(1, valorActual);
        }
        [Fact]
        public void avanzar4()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(2, valorActual);
        }
        [Fact]
        public void avanzar5()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(2, valorActual);
        }
        [Fact]
        public void avanzar5Retrocede1()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Retroceder();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(2, valorActual);
        }
        [Fact]
        public void avanzar5Retrocede2()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(1, valorActual);
        }
        [Fact]
        public void avanzar5Retrocede3()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(1, valorActual);
        }
        [Fact]
        public void avanzar5Retrocede4()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(1, valorActual);
        }
        [Fact]
        public void avanzar5Retrocede5()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(0, valorActual);
        }
        [Fact]
        public void avanzar5Retrocede6()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(0, valorActual);
        }
        [Fact]
        public void avanzar5Retrocede7()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Retroceder();
            numeroPadovan.Println();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(0, valorActual);
        }
        [Fact]
        public void avanzar13()
        {
            NumeroPadovan numeroPadovan = new NumeroPadovan();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            numeroPadovan.Avanzar();
            long valorActual = numeroPadovan.getTermino();
            Assert.Equal(21, valorActual);
        }
    }
}
