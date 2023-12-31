﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class ControlCalculadora
    {
        //Criando um objeto calculadora na memória
        ModelCalculadora calculadora;

        public ControlCalculadora()
        {
           this.calculadora = new ModelCalculadora();
        }//fim do construtor

        public void Coletar()
        {
            Console.WriteLine("Informe um número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());
        }//fim do coletar

        public int Menu()
        {
            Console.WriteLine("------ Menu -------"                    +
                              "\n0. Sair"                              +
                              "\n1. Somar"                             +
                              "\n2. Subtrair"                          +
                              "\n3. Dividir"                           +
                              "\n4. Multiplicar"                       +
                              "\n5. Potência"                          +
                              "\n6. Raiz"                              +
                              "\n7. Tabuada"                           +
                              "\n8. Conversão de binário para decimal" +
                              "\n9. Conversão de decimal para binário" +
                              "\n10. Hexadecimal para decimal "        +
                              "\n11. Decimal para Hexadecimal"         +
                              "\n12. Bhaskara"                         +
                              "\n13. Binário para Hexadecimal"         +
                              "\n14. Exercicio 1"                      +
                              "\n15. Exercicio 2"                      +
                              "\n16. Exercicio 3"                      +
                              "\n17. Exercicio 4"                      +
                              "\n18. Exercicio 5"                      +
                              "\n19. Exercicio 6"                      +
                              "\n20. Exercicio 7"                      +
                              "\n21. Exercicio 8"                      +
                              "\n22. Exercicio 9"                      +
                              "\n23. Exercicio 10"                     +
                              "\n24. Exercicio 11"                     +
                              "\n25. Exercicio 12"                     +
                              "\n26. Exercicio 13"                     +
                              "\n27. Exercicio 14"                     +
                              "\n28. Exercicio 15"                     +
                              "\n29. Exercicio 16"                     +
                              "\n30. Exercicio 17"                     +
                              "\n31. Exercicio 18"                     +
                              "\n32. Exercicio 19"                     +
                              "\n33. Exercicio 20"                     +
                              "\n\nEscolha uma das opções acima: "  );
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//fim do método Menu

        public void Operacao()
        {
            int opcao = 0;
            do
            { 
                opcao = Menu();
                Console.Clear();//Limpa a tela
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração: " + this.calculadora.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir!");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Multiplicar());
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Potência: " + this.calculadora.Potencia());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine(this.calculadora.Raiz());
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;
                    case 8:
                        Console.WriteLine("Informe um valor em binário: ");
                        Console.WriteLine(this.calculadora.ConverterDecimal(Console.ReadLine()));
                        break;
                    case 9:
                        Console.WriteLine("Informe um valor em decimal: ");
                        Console.WriteLine(this.calculadora.ConverterBinario(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 10:
                        Console.WriteLine("Informe um valor em Hexadecimal: ");
                        Console.WriteLine(this.calculadora.ConverterHexaDecimal(Console.ReadLine()));
                        break;
                    case 11:
                        Console.WriteLine("Informe um valor em Decimal: ");
                        Console.WriteLine(this.calculadora.ConverterDecimalHexa(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 12:
                        Console.WriteLine("Informe A: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe B: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe C: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.bhaskara(a, b, c));
                        break;
                    case 13:
                        Console.WriteLine("Informe o numero binário: ");
                        string binario = Console.ReadLine();
                        Console.WriteLine(this.calculadora.ConverterBinarioHexadecimal(binario));
                        break;

                    //1
                    case 14:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("O dobro desse número é: " + this.calculadora.Dobro(num));
                        Console.WriteLine("O triplo desse número é: " + this.calculadora.Triplo(num));
                        break;

                    //2
                    case 15:
                        Console.WriteLine("Informe seu salário: ");
                        double salario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("O salário com o aumento é: " + this.calculadora.Salario(salario));
                        break;

                    //3
                    case 16:
                        Console.WriteLine("Informe um número: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        if (this.calculadora.ImparPar(numero) == 1)
                        {
                            Console.WriteLine("O número é Par"); 
                        }
                        else
                        {
                            Console.WriteLine("O número é Impar");
                        }
                        if (this.calculadora.NegativoPositivo(numero) == 3)
                        {
                            Console.WriteLine("O número é Positivo");
                        }
                        else
                        {
                            Console.WriteLine("O número é Negativo");
                        }
                        break;

                    //4
                    case 17:
                        Console.WriteLine(this.calculadora.SomaNInteiros());
                        break;

                    //5
                    case 18:
                        Console.WriteLine("Informe o N: ");
                        int numN = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaN(numN,num1));
                        break;

                    //6
                    case 19:
                        Console.WriteLine("Informe o número Inicial: ");
                        int numI = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o número Final: ");
                        int numF = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.calculadora.NumeroINumeroF(numI,numF));
                        break;
                    
                    //7
                    case 20:
                        Console.WriteLine(this.calculadora.ImparEntre());
                        break;

                    //8
                    case 21:
                        Console.WriteLine("O resultado da soma dos números é: " + this.calculadora.Soma10Números());
                        break;

                    //9
                    case 22:
                        Console.WriteLine(this.calculadora.SomaNumeros());
                        break;

                    //10
                    case 23:
                        Console.WriteLine(this.calculadora.MediaAte0());
                        break;

                    //11
                    case 24:
                        Console.WriteLine("O maior número é: " + this.calculadora.ValoresIAte0());
                        break;

                    //12
                    case 25:
                        Console.WriteLine(this.calculadora.SomaPositivo());
                        break;

                    //13
                    case 26:
                        Console.WriteLine("Informe um número: ");
                        int numFato = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.calculadora.CalcularFatorial(numFato));
                        break;

                    //14
                    case 27:
                        Console.WriteLine(this.calculadora.MediaJogadores());
                        break; 

                    //15
                    case 28:
                        Console.WriteLine(this.calculadora.ConcursoMiss());
                        break;

                    //16
                    case 29:
                        Console.WriteLine(this.calculadora.VotosMunicipio());
                        break;


                    //17
                    case 30:
                        Console.WriteLine(this.calculadora.CustoDoCarro());
                        break;


                    //18
                    case 31:
                        Console.WriteLine(this.calculadora.TransformaEmDia());
                        break;


                    //19  
                    case 32:
                        Console.WriteLine(this.calculadora.MaiorVetor());
                        break;

                    //20  
                    case 33:
                        Console.WriteLine(this.calculadora.OrdemVetorParImpar());
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não e valida: ");
                        break;
                }//fim do switch
                
            } while(opcao != 0);//fim do Do...while
        }//fim do operacao
    }//fim da classe
}//fim do projeto
