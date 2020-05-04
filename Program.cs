using System;

namespace Projeto_Wagner_Corona_Vírus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            double valorSalario, valorCotacaoDolar = 0.0, maiorSalario = 0, menorSalario = 0;
            int idade = 0, grauDeInstrucao = 0, PInferior = 0, PSegundoGrau = 0, PSuperior = 0, verificador = 0, idadePSegundoGrau = 0;
            int pCursoSuperiorM500 = 0, pessoa = 1;
            do
            {
                idade = 0;
                valorCotacaoDolar = 0.0;
                nome = "";
                valorSalario = 0.0;
                grauDeInstrucao = 0;
                Console.WriteLine("Responda o Formulário a seguir ( " + pessoa + "):");

                Console.WriteLine("Digite seu Nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite seu salário:");
                valorSalario = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a sua idade:");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da cotação do dolar: ");
                valorCotacaoDolar = double.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite o número correspondente ao seu grau de instrução: - Grau de Instrução (1)\n " +
                    "- primário, (2) - Segundo Grau e (3) – Superior ");
                    grauDeInstrucao = int.Parse(Console.ReadLine());

                } while (grauDeInstrucao != 1 && grauDeInstrucao != 2 && grauDeInstrucao != 3);

                do
                {
                    Console.WriteLine("Deseja Inserir dados de mais uma pessoa? Digite [1] para Sim ou Digite [2] para não");
                    verificador = int.Parse(Console.ReadLine());
                    if (verificador == 1 || verificador == 2 || verificador == 3)
                        break;
                } while (1 == 1);
                verificador = 0;
                //Classificando os grupos por tanana
                switch (grauDeInstrucao)
                {
                    case 1:
                        PInferior++;
                        break;
                    case 2:
                        idadePSegundoGrau += idade;
                        PSegundoGrau++;
                        break;
                    case 3:
                        PSuperior++;
                        //Resolucão a
                        if (valorSalario > 500)
                            pCursoSuperiorM500++;
                        break;
                    default:
                        break;

                }
                //Menor e Maior Salario
                if (valorSalario > maiorSalario)
                    maiorSalario = valorSalario;
                if (valorSalario < menorSalario)
                    maiorSalario = valorSalario;
                    
                pessoa++;
                Console.Clear();
            } while (1 == 1);

        }
    }
}
