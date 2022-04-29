using System;    //Bibliotecas do C#
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alo Fito!!!!");
    //utilizando o var a declaração de tipos será atribuída
    //de acordo com o conteúdo da variável
            var nome = "Maria da Silva";
        //nome = 10 não é possivel alterar o valor para outro tipo
        //uma vez que a váriavel foi criada com um valor "string"

      // O c# é uma linguagem fotemente tipada
      //Vamos recordar alguns tipos:
      //int     -> 215
      //float   -> 25.41
      //bool    -> true|false
      //string  -> "Fundação Instituto Tecnológico"
      //char    -> 'F'
      
      int segundaGuerraMundial = 1942;
      string corFavorita = "Azul";
      float velocidadeF1 = 296.34f;
      double pibAmericano = 5458738463.451d;
      bool teveAulaSabado = true;

      Console.Write(segundaGuerraMundial + "\n");  //Escreve na tela com quebra de linha 
      Console.WriteLine(corFavorita);  //Imprime na tela
      Console.WriteLine(velocidadeF1);
      Console.WriteLine(pibAmericano);
      Console.WriteLine(teveAulaSabado);
     
      

      Console.WriteLine(segundaGuerraMundial is int);  //Retorna valor boolean caso condição seja real

      // Utilizando o dynamic

      dynamic corFavorita2 = "Vermelho";

      //utilizando o dynamic é possivel alterar o conteudo da variável
      //com valores de outros tipos

      corFavorita2 = 12;

      Console.WriteLine(corFavorita2);
            //Console.ReadLine(); //segura a tela de debug (anterior a 6)
        }
    }
}
