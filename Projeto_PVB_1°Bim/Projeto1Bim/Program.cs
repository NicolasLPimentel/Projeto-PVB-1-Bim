/* ***********************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 26/03/2024
* Autores do Projeto: Nicolas Lorena Pimentel
* 
* Turma: 2H
* Atividade Proposta em aula
* Observação:
* 
* problema_aula.cs
* *********************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float maior_sal = 0, menor_sal = 0, acresc = 0, mediaidade = 0, mediasup = 0, mediaprim = 0, somasal = 0;
            string maior_sal_grau = "não definido", menor_sal_grau = "não definido";
            int maior_sal_idade = 0, menor_sal_idade = 0;
            string maior_sal_nome = "não definido", menor_sal_nome = "não definido", teste, nome = "não    definido", acrescprint = "não aplicado";
            int contador = 0, supsal = 0, qtd25mais = 0, qtd25menos = 0, difidade = 0;


            do
            {
                float sal = 0;
                string grau = "não definido";
                float cot = 0;
                int idade = 0;


                contador += 1;
                Console.WriteLine("Digite o nome da pessoa: ");
                nome = Console.ReadLine();


                Console.WriteLine("Digite o salario da pessoa em dólares: ");
                sal = float.Parse(Console.ReadLine());
                while (sal < 0)
                {
                    Console.WriteLine("Digite um número válido: ");
                    sal = float.Parse(Console.ReadLine());
                }
                somasal += sal;
                if (contador == 1)
                {
                    maior_sal = sal;
                    menor_sal = sal;
                }


                Console.WriteLine("Digite a idade da pessoa: ");  /* não sabemos como colocar o teste de conversão */
                idade = int.Parse(Console.ReadLine());
                while (idade <= 0)
                {
                    Console.WriteLine("Digite um número válido: ");
                    idade = int.Parse(Console.ReadLine());
                }


                Console.WriteLine("Digite a cotação do dólar: ");
                cot = float.Parse(Console.ReadLine());
                while (cot <= 0)
                {
                    Console.WriteLine("Digite um número válido: ");
                    cot = float.Parse(Console.ReadLine());
                }
                somasal -= sal;
                sal *= cot;
                somasal += sal;


                Console.WriteLine("Digite o  Grau de Instrução [ (1) - Primário, (2) - Segundo Grau e (3) – Superior ] :");
                grau = Console.ReadLine();
                while (grau != "1" && grau != "2" && grau != "3")
                {
                    Console.WriteLine("Digite um grau válido: ");
                    grau = Console.ReadLine();
                }


                if (grau == "3")
                {
                    mediasup += 1;
                    if (sal > 500)
                        supsal += 1;
                }


                if (grau == "1")
                    mediaprim += 1;


                if (idade > 25)
                    qtd25mais += 1;
                else if (idade < 25)
                    qtd25menos += 1;


                if (grau == "2")
                    mediaidade += idade;


                if (contador == 1)
                {
                    maior_sal = sal;
                    menor_sal = sal;
                    maior_sal_grau = grau;
                    menor_sal_grau = grau;
                    maior_sal_idade = idade;
                    menor_sal_idade = idade;
                    maior_sal_nome = nome;
                    menor_sal_nome = nome;
                }
                else
                {
                    if (sal >= maior_sal)
                    {
                        maior_sal = sal;
                        maior_sal_nome = nome;
                        maior_sal_grau = grau;
                        maior_sal_idade = idade;


                    }
                    else
                    {
                        menor_sal = sal;
                        menor_sal_grau = grau;
                        menor_sal_idade = idade;
                        menor_sal_nome = nome;


                    }
                }


                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("Gostaria de adicionar mais uma pessoa?(s/n)");
                teste = Console.ReadLine();
                while (teste != "s" && teste != "n")
                {
                    Console.WriteLine("Digite uma resposta válida: ");
                    teste = Console.ReadLine();
                }


            } while (teste != "n");


            if (somasal > 20000f)
            {
                acresc = (20f / 100f) * somasal;
                somasal += acresc;
                acrescprint = "20%";
            }


            if (somasal > 35000f)
            {
                acresc = (10f / 100f) * somasal;
                somasal += acresc;
                acrescprint = "10%";
            }


            if (somasal > 45000f)
            {
                acresc = (5f / 100f) * somasal;
                somasal += acresc;
                acrescprint = "5%";
            }


            if (somasal > 50000f)
            {
                acresc = (3f / 100f) * somasal;
                somasal += acresc;
                acrescprint = "3%";
            }


            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("RESULTADOS:");
            Console.WriteLine();
            Console.WriteLine("Número de pessoas que possuem curso superior e ganham mais do que R$ 500,00 reais: " + supsal);
            Console.WriteLine("-----------------------------------------------------------------------------------");
            difidade = qtd25mais - qtd25menos;


            if (difidade < 0)
                difidade *= -1;


            Console.WriteLine("A diferença entre a quantidade de pessoas com mais de 25 anos menos de 25 anos: " + (difidade));
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("A idade média das pessoas que possuem 2o grau: " + (mediaidade / contador));
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Percentual de pessoas que possuem o curso Primário: " + ((mediaprim / contador) * 100) + "%");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Percentual de pessoas com curso superior: " + ((mediasup / contador) * 100) + "%");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();


            string strmaior = maior_sal.ToString("0.00");
            string strmenor = menor_sal.ToString("0.00");
            string strsoma = somasal.ToString("0.00");


            Console.WriteLine("pessoa com o maior salário: ");
            Console.WriteLine();
            Console.WriteLine("- Nome: " + maior_sal_nome);
            Console.WriteLine("- Grau de instrução: " + maior_sal_grau);
            Console.WriteLine("- Idade: " + maior_sal_idade);
            Console.WriteLine("- Salário: R$" + strmaior);
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("pessoa com o menor salário: ");
            Console.WriteLine();
            Console.WriteLine("- Nome: " + menor_sal_nome);
            Console.WriteLine("- Grau de instrução: " + menor_sal_grau);
            Console.WriteLine("- Idade: " + menor_sal_idade);
            Console.WriteLine("- Salário: R$" + strmenor);
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("O acrescimo dos salarios foi de: " + acrescprint);
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("A somatória dos salarios é: R$" + strsoma);
            Console.WriteLine("-----------------------------------------------------------------------------------");
        }
    }
}