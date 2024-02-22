using System.Formats.Asn1;

namespace MeuApp
{
    //Classe principal do programa
    internal class Program
    {
        // Função principal do programa
        static void Main(string[] args)
        {
            //int num1 = 25;
            //float num2 = 25.2f;
            //var num3 = 50.65;
            //decimal num4 = 2.5m;

            //// Conversão Implícita
            //float valor = 35.2f;
            //int outroValor = 35;
            //valor = outroValor;

            ///Conversão Explícita
            //int inteiro = 100;
            //uint inteiroSemSinal = (uint)inteiro;

            //parse
            //string qnt = "100";
            //int inteiro2 = int.Parse(qnt);

            //Convert
            //string qnt = "100";
            //int inteiro = Convert.ToInt32(qnt);

            //Operadores de atribuição
            //int x = 0; //Atribuicao
            //x += 5;    // x = x + 5
            //x -= 1;    // x = x - 1
            //x *= 10;   // x = x + 10
            //x /= 2;    // x = x / 2


            //Swich case
            //int? valor = 44;
            //switch(valor)
            //{
            //    case 1: Console.WriteLine("1"); break;
            //    case 2: Console.WriteLine("2"); break;
            //    case 3: Console.WriteLine("3"); break;
            //    default: Console.WriteLine("4"); break;
            //}

            bool? valor = null;
            switch(valor)
            {
                case true:  Console.WriteLine(" é true, mano"); break;
                case false: Console.WriteLine("caô"); break;
                case null: Console.WriteLine("null"); break;
            }


        }
    }
}