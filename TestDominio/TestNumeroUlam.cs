using Xunit;
using Dominio;

namespace TestDominio
{
    public class TestNumeroUlam
    {
        [Fact]
        public void Inicializacion()
        {
            NumeroUlam numeroUlam = new NumeroUlam();
            long ValorActual = numeroUlam.getTermino();
            Assert.Equal(0,ValorActual);
        }
        [Fact]
        public void Avanzar1()
        {
            NumeroUlam numeroUlam = new NumeroUlam();
            numeroUlam.Avanzar();
            long ValorActual = numeroUlam.getTermino();
            Assert.Equal(1, ValorActual);
        }
        [Fact]
        public void Avanzar2()
        {
            NumeroUlam numeroUlam = new NumeroUlam();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            long ValorActual = numeroUlam.getTermino();
            Assert.Equal(2, ValorActual);
        }
        [Fact]
        public void Avanzar3()
        {
            NumeroUlam numeroUlam = new NumeroUlam();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            long ValorActual = numeroUlam.getTermino();
            Assert.Equal(3, ValorActual);
        }
        [Fact]
        public void Avanzar4()
        {
            NumeroUlam numeroUlam = new NumeroUlam();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            long ValorActual = numeroUlam.getTermino();
            Assert.Equal(4, ValorActual);
        }
        [Fact]
        public void Avanzar11()
        {
            NumeroUlam numeroUlam = new NumeroUlam();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            long ValorActual = numeroUlam.getTermino();
            Assert.Equal(26, ValorActual);
        }
        [Fact]
        public void Avanzar4Retroceder1()
        {
            NumeroUlam numeroUlam = new NumeroUlam();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Retroceder();
            long ValorActual = numeroUlam.getTermino();
            Assert.Equal(3, ValorActual);
        }
        [Fact]
        public void Avanzar4Retroceder4()
        {
            NumeroUlam numeroUlam = new NumeroUlam();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Retroceder();
            numeroUlam.Retroceder();
            numeroUlam.Retroceder();
            numeroUlam.Retroceder();
            long ValorActual = numeroUlam.getTermino();
            Assert.Equal(0, ValorActual);
        }
        [Fact]
        public void Avanzar4Retroceder5()
        {
            NumeroUlam numeroUlam = new NumeroUlam();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Avanzar();
            numeroUlam.Retroceder();
            numeroUlam.Retroceder();
            numeroUlam.Retroceder();
            numeroUlam.Retroceder();
            numeroUlam.Retroceder();
            long ValorActual = numeroUlam.getTermino();
            Assert.Equal(0, ValorActual);
        }

       

    }
}
