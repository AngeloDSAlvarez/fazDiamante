namespace fazDiamante
{
    internal class Program
    {

        static void criaDiamante(int tamanhoDiamante)
        {
            decimal metade = tamanhoDiamante / 2;
            int metadeDiamante = Convert.ToInt32(Math.Floor(metade)) ;
            var matrizDiamante = new char[tamanhoDiamante, tamanhoDiamante];
            bool menosMetade = true;
            int contador = 0;

            for (int i = 0; i < tamanhoDiamante; i++)
            {
                for (int j = 0; j < tamanhoDiamante; j++)
                {
                    matrizDiamante[i, j] = ' ';
                }
            }

            for (int i = 0; i < tamanhoDiamante; i++)
            {
                if (i == 0)
                {
                    matrizDiamante[i, metadeDiamante] = 'x';
                    contador++;
                } else if (menosMetade)
                {
                    int tamanhoLadoEsq = metadeDiamante - contador;
                    int tamanhoLadoDir = metadeDiamante + contador;
                            
                    for (int j = tamanhoLadoEsq; j < metadeDiamante; j++)
                    {
                        matrizDiamante[i, j] = 'x';
                    }

                    for (int j = tamanhoLadoDir; j >= metadeDiamante; j--)
                    {
                        matrizDiamante[i, j] = 'x';
                    }

                    contador++;
                } else
                {
                    int tamanhoLadoEsq = metadeDiamante - contador;
                    int tamanhoLadoDir = metadeDiamante + contador;

                    for (int j = tamanhoLadoEsq; j < metadeDiamante; j++)
                    {
                        matrizDiamante[i, j] = 'x';
                    }


                    for (int j = tamanhoLadoDir; j >= metadeDiamante; j--)
                    {
                        matrizDiamante[i, j] = 'x';
                    }

                    contador--;
                }

                if (contador == metadeDiamante)
                {
                    menosMetade = false;
                }

              


            }

            for (int i = 0;i < tamanhoDiamante;i++)
            {
                for (int j = 0; j < tamanhoDiamante; j++)
                {
                    Console.Write(matrizDiamante[i, j]);
                }
                Console.WriteLine("");
            }

        }
        static void Main(string[] args)
        {

            criaDiamante(7);

        }
    }
}
