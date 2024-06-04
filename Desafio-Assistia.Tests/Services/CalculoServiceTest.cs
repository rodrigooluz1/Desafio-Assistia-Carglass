using Desafio_Assistia.API.Application.Services;
using Desafio_Assistia.API.Dto;
using Desafio_Assistia.API.Util.Constantes;
using Xunit;

namespace Desafio_Assistia.Tests.Services
{
	public class CalculoServiceTest
	{
        CalculoService _calculoService;

        NumerosDivisoresDto divisoresResponse = new NumerosDivisoresDto()
        {
            status = true, message = Mensagens.CalculoSuccess, entrada = 45,
            divisores = new List<int> { 1, 3, 5, 9, 15, 45 }.ToArray(), primos = new List<int> { 1, 3, 5 }.ToArray()
        };


        public CalculoServiceTest()
		{
		}

        [Fact]
        public async Task CalculaDivisores_Success_Test()
        {
            var numero = 45;

            _calculoService = new CalculoService();

            var retorno = await _calculoService.CalculaDivisores(numero);

            Assert.True(retorno.status);
            Assert.Equal(retorno.message, Mensagens.CalculoSuccess);
            Assert.Equal(retorno.divisores, divisoresResponse.divisores);
            Assert.Equal(retorno.primos, divisoresResponse.primos);
            Assert.Equal(retorno.entrada, numero);
        }


        [Fact]
        public async Task CalculaDivisores_EntradaZero_Test()
        {
            var numero = 0;

            _calculoService = new CalculoService();

            var retorno = await _calculoService.CalculaDivisores(numero);

            Assert.False(retorno.status);
            Assert.Equal(retorno.message, Mensagens.CalculoNumeroZero);
            Assert.Null(retorno.divisores);
            Assert.Null(retorno.primos);
            Assert.Equal(retorno.entrada, numero);
        }

    }
}

