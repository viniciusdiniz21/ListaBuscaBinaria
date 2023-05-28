using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;


// atividade 1
// A) a complexidade da busca binaria depende da situação, mas nos piores dos casos é O(Log n ).
// Agora  a busca linear no seu pior caso seria O(n)
//
// B) O melhor caso em que a busca linear é mais interessante que a busca binaria,
// é quando o valor pesquisado está na primeira posição que neste caso seria O(1)
//
// C) O vetor está ordenado é fundamental para a busca binaria, porque ele se torna muito mais eficiente quando 
// o vetor está ordernado, alem de eliminar grande parte da busca desejada!


// atividade 2
string[] vetor_palavras = new string[4];

int inicio = 0;
int fim = vetor_palavras.Length-1;
int meio;
string busca;
for (int i = 0; i <= vetor_palavras.Length-1; i++)
{
    Console.WriteLine("Escreva uma palavra : ");
   vetor_palavras[i] = Console.ReadLine();
}

var vetor_palavras_Ord = vetor_palavras.OrderBy(x => x).ToArray();
Console.WriteLine("");
foreach (var nomes in vetor_palavras_Ord)
{
    Console.WriteLine(nomes);
}

Console.WriteLine("");

Console.WriteLine("Qual nome você deseja buscar ?");
busca= Console.ReadLine();
bool verificacao=false;

while (inicio <= fim )
{
   meio = (inicio + fim ) / 2;
   if (string.Compare(busca, vetor_palavras_Ord[meio]) == 0 )
   {
      verificacao = true;
        break;
   }
  else
    {
       if (string.Compare(busca, vetor_palavras_Ord[meio]) == 1)
        {
               inicio = meio + 1;
        }
        {
           fim = meio - 1;
        }

    }
}
if (verificacao == true)
{
    Console.Write("Valor encontrado ");
}
else
{
    Console.Write("Valor não encontrado ");
}


//atividade 3
// A) Primeira posição, no caso posição 0
// B) O valor tem de ser inserido na posição 0, para dar possibilidade de fazer a busca


