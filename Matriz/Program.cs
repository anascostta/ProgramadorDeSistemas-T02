// Declarando uma matriz 3 linhas por 2 colunas
int[,] matriz = new int[3, 2] // int= tipo de dado; [,]= indica que é uma matriz de 2D; new int[3, 2] = criando uma matriz de 3 linhas e 2 colunas do tipo inteiro
{
    { 1, 2 }, // primeira linha com 2 colunas, a virgula separa as colunas
    { 3, 4 },
    { 5, 6 }
};

for (int i = 0; i<matriz.GetLength(0); i++) //loop do tipo for
//identificando o conteudo da linha, i comeca com 0, enquanto 0 for menor
// que a dimensao da matriz some +1
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    //identificando o conteudo da coluna, i comeca com 0, enquanto 0 for menor
    // que a dimensao da matriz some +1
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}