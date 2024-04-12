namespace fazDiamante
{
    internal class Program
    {
        static char[,] InicializaMatriz(int tamanhoMatriz)
        {
            char[,] matriz = new char[tamanhoMatriz, tamanhoMatriz];
            //Inicializando a matriz com espaços em branco, usando o tamanho recebido no parametro

            for (int i = 0; i < tamanhoMatriz; i++)
            {
                for (int j = 0; j < tamanhoMatriz; j++)
                {
                    matriz[i, j] = ' ';
                }
            }

            // retorna matriz
            return matriz;
        }

        //função para imprimir matriz
        static void ImprimeMatriz(char[,] matriz)
        {
            //achar tamanho da matriz
            int tamanho = Convert.ToInt32(Math.Sqrt(matriz.Length));
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine("");
            }
        }

        static void CriaDiamante(int tamanhoDiamante)
        {
            decimal metade = tamanhoDiamante / 2;
            int metadeDiamante = Convert.ToInt32(Math.Floor(metade)) ;
            
            bool menosMetade = true;
            int contador = 0;

            //Inicializando a matriz com espaços em branco
            char[,] matrizDiamante = InicializaMatriz(tamanhoDiamante);

            for (int i = 0; i < tamanhoDiamante; i++)
            {
                //cria variaveis para saber o tamanho que precisa imprimir da esquerda e da direita do centro
                int tamanhoLadoEsq = metadeDiamante - contador;
                int tamanhoLadoDir = metadeDiamante + contador;
                //verifica se está imprimindo a metade de cima ou de baixo do diamanta
                //true = cima
                //false = baixo
                if (menosMetade)
                {        
                    for (int j = tamanhoLadoEsq; j < metadeDiamante; j++)
                    {
                        matrizDiamante[i, j] = 'x';
                    }

                    for (int j = tamanhoLadoDir; j >= metadeDiamante; j--)
                    {
                        matrizDiamante[i, j] = 'x';
                    }

                    contador++;

                    //verifica se o contador está do tamanho da metade da matriz, para começar a diminuir o dimante
                    if (contador == metadeDiamante)
                    {
                        //altera a variavel para false, alterando a condição do if
                        menosMetade = false;
                    }
                } else
                {
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
            }
            //chama função para imprimir a matriz na tela
            ImprimeMatriz(matrizDiamante);
        }
        static void Main(string[] args)
        {
            //chama função para criar o dimante, passando o tamanho dele como parametro
            CriaDiamante(7);

        }
    }
}
