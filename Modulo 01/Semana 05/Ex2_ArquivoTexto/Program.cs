using System;
using System.IO;

/* EXERCÍCIO 02
***Passo a passo de codificação:
1.Crie um novo projeto Console Application no Visual Studio.
2. Adicione a seguinte linha de código no início do seu arquivo para importar as bibliotecas necessárias:
using System;
using System.IO;
*/

public class Program
{
    public static void Main(string[] args)
    { //3. Crie uma variável do tipo FileInfo chamada arquivo e inicialize-a com null:  
        FileInfo arquivo = null;

        try
        {
            //4. Dentro do bloco try do método Main(), exiba uma mensagem para o usuário solicitando o nome do arquivo que deseja criar:
            Console.Write("Digite o nome do arquivo que você deseja criar: ");
            string nomeArquivo = Console.ReadLine();

            //5.Utilize o nome do arquivo digitado pelo usuário para criar um novo objeto do tipo FileInfo e atribuí-lo à variável arquivo:
            arquivo = new FileInfo(nomeArquivo);

            //6.Utilize o objeto StreamWriter para criar um novo arquivo de texto e escrever uma linha de texto dentro dele.
            //Utilize o bloco using para garantir que o objeto StreamWriter seja descartado corretamente após a gravação:
            using (StreamWriter gravadorTexto = File.AppendText(nomeArquivo))
            {
                gravadorTexto.WriteLine("Texto de dentro do arquivo.");
            }
        }

        //7.Dentro do bloco catch, exiba uma mensagem de erro genérica indicando que ocorreu um erro durante a criação ou gravação do arquivo:
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Tratando o erro especificamente: {ex}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
        //8.Dentro do bloco finally, exiba uma mensagem indicando que o programa está encerrando e defina a variável arquivo como null:
        finally
        {
            Console.WriteLine($"Encerrando o programa...\n");
            arquivo = null;
        }
    }
}
// 9. Compile e execute o programa.
// Verifique se é possível criar e escrever em um arquivo de texto com sucesso,
// E se o tratamento de exceções está funcionando corretamente em caso do usuário não digitar nada para o nome do arquivo de texto.

