namespace Desafio_Assistia.API.Dto
{
	public class NumerosDivisoresDto : BaseDto
	{
        public int entrada { get; set; }
        public int[]? divisores { get; set; }
        public int[]? primos { get; set; }
    }
}

