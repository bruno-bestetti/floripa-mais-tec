List<string> listaDeFrutas = new List<string>(); // Lista de frutas vazia

bool continuar = true; 
while (continuar)
{ // variável booleano continuar é true, se a condição do if for verdadeira ele adiciona na lista, se for false não adiciona.
    if (listaDeFrutas.Count() == 15) // Lista com no máximo 15 itens
    {
        continuar = false;
    }

    Console.Write("Digite o nome de uma fruta: ");
    listaDeFrutas.Add(Console.ReadLine()); // .Add adiciona a fruta na lista

    Console.Write("Deseja continuar? Responda [s] para sim ou [n] para não: ");

    string resposta = Console.ReadLine();
    if (resposta == "n" || resposta == "nao") // Se o usuário digitar "n" ou "nao" para variável resposta, então para o laço while.
    {
        continuar = false;
    }
}

listaDeFrutas.Sort(); // coloca a lista em ordem alfabética
foreach (string fruta in listaDeFrutas) // Método foreach transforma cada item da lista em uma string.
{
    Console.WriteLine(fruta);
}