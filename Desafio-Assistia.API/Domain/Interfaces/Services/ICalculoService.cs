using Desafio_Assistia.API.Dto;

namespace Desafio_Assistia.API.Domain.Interfaces.Services
{
	public interface ICalculoService
	{
		Task<NumerosDivisoresDto> CalculaDivisores(int numero);
	}
}

