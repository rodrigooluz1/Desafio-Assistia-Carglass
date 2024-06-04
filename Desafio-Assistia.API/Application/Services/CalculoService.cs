using Desafio_Assistia.API.Domain.Interfaces.Services;
using Desafio_Assistia.API.Dto;
using Desafio_Assistia.API.Util;
using Desafio_Assistia.API.Util.Constantes;

namespace Desafio_Assistia.API.Application.Services
{
	public class CalculoService: ICalculoService
	{
		public CalculoService()
		{
		}

        public async Task<NumerosDivisoresDto> CalculaDivisores(int numero)
        {
			try
			{
                if (numero <= 0)
                    throw (new Exception(Mensagens.CalculoNumeroZero));

                var numerosDivisores = Calculos.RetornaNumerosDivisores(numero);
                var numerosPrimos = Calculos.RetornaNumerosPrimos(numerosDivisores);

                return new NumerosDivisoresDto
                {
                    status = true,
                    message = Mensagens.CalculoSuccess,
                    entrada = numero,
                    divisores = numerosDivisores,
                    primos = numerosPrimos
                };
            }
			catch (Exception ex)
			{
                return new NumerosDivisoresDto
                {
                    status = false,
                    message = ex.Message,
                    entrada = numero,
                };
            }
        }

       
    }
}

