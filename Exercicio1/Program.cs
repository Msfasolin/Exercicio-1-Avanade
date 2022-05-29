using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            do
            {
                Console.WriteLine("1 - Operadores de Comparação");
                Console.WriteLine("2 - Operadores de Aritmética");
                Console.WriteLine("3 - Sair do programa");

                int escolher = Convert.ToInt32(Console.ReadLine());


                bool voltar = true;
                do
                {
                    switch (escolher)
                    {
                        case 1:

                            Console.WriteLine("A: == Igual a");
                            Console.WriteLine("B: != Não é igual");
                            Console.WriteLine("C: > Maior do que");
                            Console.WriteLine("D: < Menos do que");
                            Console.WriteLine("E: >= Maior ou igual a");
                            Console.WriteLine("F: <= Menos ou igual a");
                            Console.WriteLine("V: Voltar");
                            String escolherOperadoresComparacao = Console.ReadLine();

                            switch (escolherOperadoresComparacao)
                            {
                                case "A":
                                case "a":
                                    Console.WriteLine("Qual numero de X");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Qual numero de Y");
                                    int y = Convert.ToInt32(Console.ReadLine());
                                    bool ar = (x == y);

                                    Console.WriteLine("Resultado: " + ar + "\n");

                                    break;

                                case "B":
                                case "b":
                                    Console.WriteLine("Qual numero de X");
                                    int n1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Qual numero de Y");
                                    int n2 = Convert.ToInt32(Console.ReadLine());
                                    bool br = (n1 != n2);

                                    Console.WriteLine("Resultado: " + br + "\n");

                                    break;
                                case "C":
                                case "c":
                                    Console.WriteLine("Qual numero de X");
                                    int n3 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Qual numero de Y");
                                    int n4 = Convert.ToInt32(Console.ReadLine());
                                    bool cr = (n3 > n4);

                                    Console.WriteLine("Resultado: " + cr + "\n");
                                    break;
                                case "D":
                                case "d":
                                    Console.WriteLine("Qual numero de X");
                                    int n5 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Qual numero de Y");
                                    int n6 = Convert.ToInt32(Console.ReadLine());
                                    bool dr = (n5 < n6);

                                    Console.WriteLine("Resultado: " + dr + "\n");

                                    break;
                                case "E":
                                case "e":
                                    Console.WriteLine("Qual numero de X");
                                    int n7 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Qual numero de Y");
                                    int n8 = Convert.ToInt32(Console.ReadLine());
                                    bool er = (n7 >= n8);

                                    Console.WriteLine("Resultado: " + er + "\n");

                                    break;
                                case "F":
                                case "f":
                                    Console.WriteLine("Qual numero de X");
                                    int n9 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Qual numero de Y");
                                    int n10 = Convert.ToInt32(Console.ReadLine());
                                    bool fr = (n9 <= n10);

                                    Console.WriteLine("Resultado: " + fr + "\n");

                                    break;
                                case "V":
                                case "v":
                                    voltar = false;
                                    break;
                                default:
                                    Console.WriteLine("Não existe opções");
                                    return;

                            } break;



                        case 2:
                            Console.WriteLine("H: + Soma dois valores");
                            Console.WriteLine("I: - Subtração");
                            Console.WriteLine("J: * Multiplicação");
                            Console.WriteLine("K: / Divisão");
                            Console.WriteLine("L: % Módulo");
                            Console.WriteLine("M: ++ Aumento");
                            Console.WriteLine("N: -- Decrescimo");
                            Console.WriteLine("X: Voltar");
                            String escolherOperadoresAritmetica = Console.ReadLine();


                            switch (escolherOperadoresAritmetica)
                            {
                                case "H":
                                case "h":
                                    Console.WriteLine("Qual numero de X");
                                    int n11 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Qual numero de Y");
                                    int n12 = Convert.ToInt32(Console.ReadLine());
                                    int ar = n11 + n12;


                                    Console.WriteLine("Resultado: " + ar + "\n");

                                    break;

                                case "I":
                                case "i":
                                    Console.WriteLine("Qual numero de X");
                                    int n13 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Qual numero de Y");
                                    int n14 = Convert.ToInt32(Console.ReadLine());
                                    int br = (n13 - n14);

                                    Console.WriteLine("Resultado: " + br + "\n");

                                    break;
                                case "J":
                                case "j":
                                    Console.WriteLine("Qual numero de X");
                                    int n15 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Qual numero de Y");
                                    int n16 = Convert.ToInt32(Console.ReadLine());
                                    int cr = (n15 * n16);

                                    Console.WriteLine("Resultado: " + cr + "\n");
                                    break;
                                case "K":
                                case "k":
                                    Console.WriteLine("Qual numero de X");
                                    int n17 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Qual numero de Y");
                                    int n18 = Convert.ToInt32(Console.ReadLine());
                                    int dr = (n17 / n18);

                                    Console.WriteLine("Resultado: " + dr + "\n");

                                    break;
                                case "L":
                                case "l":
                                    Console.WriteLine("Qual numero de X");
                                    int n19 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Qual numero de Y");
                                    int n20 = Convert.ToInt32(Console.ReadLine());
                                    int er = (n19 % n20);

                                    Console.WriteLine("Resultado: " + er + "\n");

                                    break;
                                case "M":
                                case "m":
                                    Console.WriteLine("Qual numero de X");
                                    int n21 = Convert.ToInt32(Console.ReadLine());
                                    int fr = n21++;

                                    Console.WriteLine("Resultado: " + fr + "\n");

                                    break;
                                case "N":
                                case "n":
                                    Console.WriteLine("Qual numero de X");
                                    int n22 = Convert.ToInt32(Console.ReadLine());
                                    int gr = n22--;

                                    Console.WriteLine("Resultado: " + gr + "\n");

                                    break;
                                case "X":
                                case "x":
                                    voltar = false;
                                    break;
                                default:
                                    Console.WriteLine("Não existe opções");
                                    break;

                                 

                            }break;

                        case 3:
                            continuar= false;
                            return;
                            break;
                        default:
                            Console.WriteLine("Não existe números");
                            return;
                            break;
                    }
                } while(voltar);
            } while(continuar);
        }
    }
}
