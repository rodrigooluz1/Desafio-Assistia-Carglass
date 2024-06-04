namespace Desafio_Assistia.API.Util
{
	public static class Calculos
	{
		public static int[] RetornaNumerosDivisores(int numero)
		{
            var listaNumeros = new List<int>();

            for (int i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                    listaNumeros.Add(i);
            }

            return listaNumeros.ToArray();
        }

        public static int[] RetornaNumerosPrimos(int[] numeros)
        {
            var listaNumeros = new List<int>();
            

            foreach(var numero in numeros)
            {
                var primo = true;

                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                        primo = false;
                }

                if(primo)
                    listaNumeros.Add(numero);
            }

            return listaNumeros.ToArray();
        }

    }
}

