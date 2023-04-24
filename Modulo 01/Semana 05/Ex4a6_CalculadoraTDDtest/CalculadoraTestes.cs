using Ex4a6_CalculadoraTDD.Classes;

namespace Ex4a6_CalculadoraTDDtest
{
    public class CalculadoraTestes
    {
        private const double V = 11.08;

        [Fact]
        public void TesteSomarNumerosInteiros()
        {
            // receber o resultado
            int resultado = Calculadora.Somar(5, 5);

            // resultado a ser comparado
            int esperado = 10;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteSubtrairNumerosInteiros()
        {
            // receber o resultado
            int resultado = Calculadora.Subtrair(5, 5);

            // resultado a ser comparado
            int esperado = 0;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteMultiplicarNumerosInteiros()
        {
            // receber o resultado
            int resultado = Calculadora.Multiplicar(5, 5);

            // resultado a ser comparado
            int esperado = 25;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteDividirNumerosInteiros()
        {
            // receber o resultado
            int resultado = Calculadora.Dividir(5, 5);

            // resultado a ser comparado
            int esperado = 1;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        //Testes métodos decimal

        [Fact]
        public void TesteSomarNumerosDecimais()
        {
            // receber o resultado
            decimal resultado = Calculadora.Somar(5.78M, 5.3M);

            // resultado a ser comparado
            decimal esperado = 11.08M;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteSubtrairNumerosDecimais()
        {
            // receber o resultado
            decimal resultado = Calculadora.Subtrair(5.78M, 5.3M);

            // resultado a ser comparado
            decimal esperado = 0.48M;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteMultiplicarNumerosDecimais()
        {
            // receber o resultado
            decimal resultado = Calculadora.Multiplicar(5.78M, 5.3M);

            // resultado a ser comparado
            decimal esperado = 30.634M;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteDividirNumerosDecimais()
        {
            // receber o resultado
            decimal resultado = Calculadora.Dividir(5.5M, 5.5M);

            // resultado a ser comparado
            decimal esperado = 1M;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        //Testes métodos double

        [Fact]
        public void TesteSomarNumerosDouble()
        {
            // receber o resultado
            double resultado = Calculadora.Somar(5.78, 5.3);

            // resultado a ser comparado
            double esperado = 11.08;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteSubtrairNumerosDouble()
        {
            // receber o resultado
            double resultado = Calculadora.Subtrair(5.5, 5.5);

            // resultado a ser comparado
            double esperado = 0;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteMultiplicarNumerosDouble()
        {
            // receber o resultado
            double resultado = Calculadora.Multiplicar(5.78, 5.3);

            // resultado a ser comparado
            double esperado = 30.634;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteDividirNumerosDouble()
        {
            // receber o resultado
            double resultado = Calculadora.Dividir(5.5, 5.5);

            // resultado a ser comparado
            double esperado = 1;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        //Testes métodos float

        [Fact]
        public void TesteSomarNumerosFloat()
        {
            // receber o resultado
            float resultado = Calculadora.Somar(5.78f, 5.3f);

            // resultado a ser comparado
            float esperado = 11.08f;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteSubtrairNumerosFloat()
        {
            // receber o resultado
            float resultado = Calculadora.Subtrair(5.5f, 5.5f);

            // resultado a ser comparado
            float esperado = 0f;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteMultiplicarNumerosFloat()
        {
            // receber o resultado
            float resultado = Calculadora.Multiplicar(5f, 5f);

            // resultado a ser comparado
            float esperado = 25f;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteDividirNumerosFloat()
        {
            // receber o resultado
            float resultado = Calculadora.Dividir(5f, 5f);

            // resultado a ser comparado
            float esperado = 1f;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        //Testes métodos long

        [Fact]
        public void TesteSomarNumerosLong()
        {
            // receber o resultado
            long resultado = Calculadora.Somar(5L, 5L);

            // resultado a ser comparado
            long esperado = 10L;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteSubtrairNumerosLong()
        {
            // receber o resultado
            long resultado = Calculadora.Subtrair(5L, 5L);

            // resultado a ser comparado
            long esperado = 0L;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteMultiplicarNumerosLong()
        {
            // receber o resultado
            long resultado = Calculadora.Multiplicar(5L, 5L);

            // resultado a ser comparado
            long esperado = 25L;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteDividirNumerosLong()
        {
            // receber o resultado
            long resultado = Calculadora.Dividir(5L, 5L);

            // resultado a ser comparado
            long esperado = 1L;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }
    }
}
