using Ex_2;

void CompararFilas(FilaNumero f1, FilaNumero f2)
{
    if (f1.getTamanho() == f2.getTamanho())
    {
        Console.WriteLine("As Filas são iguais");
    }
    else if (f1.getTamanho() > f2.getTamanho())
    {
        Console.WriteLine("Fila 1 maior");
    }
    else
    {
        Console.WriteLine("Fila 2 maior");
    }
}
void MaiorMenorMedia(FilaNumero f)
{
    Console.WriteLine("Maior:" + f.getMaior());
    Console.WriteLine("Menor:" + f.getMenor());
    Console.WriteLine("Media:" + f.getMedia());
}

void ImprimirNovaFila(FilaNumero f)
{
    FilaNumero filaNova = f.CopiarFila();

    filaNova.ImprimirFila();
}
void ParesImpares(FilaNumero f)
{
    Console.Write("Pares: ");
    f.ImprimirPares();

    Console.Write("Impares: ");
    f.ImprimirImpares();
}
FilaNumero MontarFila()
{
    FilaNumero novaFila = new FilaNumero();
    int tamanho = new Random().Next(1, 30);
    for (int i = 0; i < tamanho; i++)
    {
        novaFila.Push(new Numero(new Random().Next(1, 200)));
    }
    return novaFila;
}


FilaNumero f1 = MontarFila();
FilaNumero f2 = MontarFila();
int opcao;

while (true)
{

    Console.WriteLine("\n\nSelecione uma opção");

    Console.WriteLine("1 - Imprimir Fila 1");
    Console.WriteLine("2 - Imprimir Fila 2");
    Console.WriteLine("3 - Retirar item da Fila 1");
    Console.WriteLine("4 - Retirar item da Fila 2");
    Console.WriteLine("5 - Comparar Filas");
    Console.WriteLine("6 - Ver Menor, Maior e Média das Filas");
    Console.WriteLine("7 - Ver Pare e Impares de cada Fila");
    Console.WriteLine("8 - Copiar Fila 1");
    Console.WriteLine("9 - Copiar Fila 2");
    Console.Write("Opção: < >\b\b");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");
    switch (opcao)
    {
        case 1:
            f1.ImprimirFila();
            break;
        case 2:
            f2.ImprimirFila();
            break;
        case 3:
            f1.Pop();
            Console.WriteLine("1 item removido...");
            break;
        case 4:
            f2.Pop();
            Console.WriteLine("1 item removido...");
            break;
        case 5:
            CompararFilas(f1, f2);
            break;
        case 6:
            Console.WriteLine("\nFila 1");
            MaiorMenorMedia(f1);

            Console.WriteLine("\nFila 2");
            MaiorMenorMedia(f2);
            break;
        case 7:
            Console.WriteLine("\n\nFila 1");
            ParesImpares(f1);
            Console.WriteLine("\n\nFila 2");
            ParesImpares(f2);
            break;
        case 8:
            Console.WriteLine("Copia da Fila 1");
            ImprimirNovaFila(f1);
            break;
        case 9:
            Console.WriteLine("Copia da Fila 2");
            ImprimirNovaFila(f2);
            break;
        case 0:
            Console.WriteLine("Saindo...");
            Console.ReadLine();
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida...");
            break;
    }

    Console.WriteLine("\nPressione Enter para continuar...");
    Console.ReadLine();
    Console.Clear();
}
