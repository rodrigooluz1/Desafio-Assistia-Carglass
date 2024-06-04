using Desafio_Assistia.API.Dto;
using Desafio_Assistia.API.Util.Constantes;
using Xunit;
namespace Desafio_Assistia.Tests.Dto
{
	public class NumeroDivisoresDtoTest
	{
		public NumeroDivisoresDtoTest()
		{
		}

        [Fact]
        public void NumerosDivisores_Test()
        {
             // Arrange
            int entrada = 45;
            var numerosDivisores = new List<int> { 1, 3, 5, 9, 15, 45 };
            var numerosPrimos = new List<int> { 1, 3, 5 };

            // Act
            var divisoresDto = new NumerosDivisoresDto()
            {
                status = true,
                message = Mensagens.CalculoSuccess,
                entrada = 45,
                divisores = numerosDivisores.ToArray(),
                primos = numerosPrimos.ToArray()
            };

            // Assert
            Assert.True(divisoresDto.status);
            Assert.Equal(Mensagens.CalculoSuccess, divisoresDto.message);
            Assert.Equal(numerosDivisores.ToArray(), divisoresDto.divisores);
            Assert.Equal(numerosPrimos.ToArray(), divisoresDto.primos);
            Assert.Equal(entrada, divisoresDto.entrada);
        }
    }
}

