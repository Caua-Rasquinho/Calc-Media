using System;
namespace Calc_Média
{
    public class Program
    {
        public static void Main (String[] args){

                Console.WriteLine("################");
                Console.WriteLine("Bem Vindo meu patrão");
                Console.WriteLine("################");

                float SomaMedia = 0;
                int cont = 0;

            while(true)
            {
                Console.WriteLine($"Digite a nota {cont + 1}: ");
                float n = float.Parse(Console.ReadLine());
                SomaMedia += n; 
                cont++;

                string sair =" ";

                while(sair != "S" || sair != "N")
                {
                    Console.WriteLine("Vocé quer sair do programa? [S/N]");
                    sair = Console.ReadLine().ToUpper();

                    if(sair == "S")
                    {
                        break;
                    }
                    else if(sair == "N")
                    {
                        break;
                    } else {
                        Console.WriteLine("Digite uma opção válida!!");
                    }
                }

                if(sair == "S")
                {
                    break;
                }


                
            }

            float r = SomaMedia/cont;
            if(SomaMedia >= 6)
            {
                Console.WriteLine($"Sua média foi: {r}, você foi aprovado");
            } else{
                Console.WriteLine($"Sua média foi: {r}, você foi reprovado");
            }
        }
    }
}