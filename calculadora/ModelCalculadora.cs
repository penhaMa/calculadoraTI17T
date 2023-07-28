using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class ModelCalculadora
    {
        //Declarando variáveis
        private double num1;
        private double num2;

        public ModelCalculadora()
        {
            GetSetNum1 = 0;
            GetSetNum2 = 0;
        }//fim do construtor

        //Métodos Gets e Sets
        public double GetSetNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }//fim do GetSetNum1

        public double GetSetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }//fim do GetSetNum2

        //Métodos
        public double Somar()
        {
            return GetSetNum1 + GetSetNum2;
        }//fim do método somar

        public double Subtrair()
        {
            return GetSetNum1 - GetSetNum2;
        }//fim do método subtrair

        public double Dividir()
        {
            if (GetSetNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return GetSetNum1 / GetSetNum2;
            }   
        }//fim do método dividir

        public double Multiplicar()
        {
            return GetSetNum1 * GetSetNum2;
        }//fim do método multiplicar

        public double Potencia()
        {
            return Math.Pow(GetSetNum1, GetSetNum2);
        }//fim da potência

        public string Raiz()
        {
            string msg = "Raiz do primeiro número: "  + Math.Sqrt(GetSetNum1) +
                         "\nRaiz do segundo número: " + Math.Sqrt(GetSetNum2);
            return msg;
        }//fim do método raiz

        public string TabuadaNum1()
        {
            string resultado = "";

            for(int i = 0;i <= 10; i++)
            {
                resultado += "\n" + GetSetNum1 + " * " + i + " = " + (GetSetNum1 * i);
            }//fim do for

            return resultado;
        }//fim do método

        public string TabuadaNum2()
        {
            string resultado = "";

            //Início;Fim;Contagem
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum2 + " * " + i + " = " + (GetSetNum2 * i);
            }//fim do for

            return resultado;
        }//fim do método

        public int ConverterDecimal(string binario)
        {
            int dec = 0;
            string caract = "";
            int tamanho = binario.Length;
            int pote = tamanho;
            for(int i=0; i < tamanho; i++)
            {
                pote--;
                caract = binario.Substring(i, 1);
                if (caract == "1")
                {
                    dec += Convert.ToInt32(Math.Pow(2, pote));
                }
            }//fim do for
            return dec;
        }//fim do método converter decimal

        public string ConverterBinario(int dec)
        {
            string binario = "";
            int resto = 0;
            do
            {
                resto = dec % 2;
                binario += resto;
                dec = dec / 2;
            } while(dec != 0);
            return new String(binario.Reverse().ToArray());
        }//fim do método

        public double ConverterHexaDecimal(string hexadecimal)
        {
            double dec = 0;
            string caract = "";
            int num = 0;
            int tamanho = hexadecimal.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = hexadecimal.Substring(i, 1);
                switch (caract)
                {
                    case "A":
                        num = 10;
                        break;
                    case "B":
                        num = 11;
                        break;
                    case "C":
                        num = 12;
                        break;
                    case "D":
                        num = 13;
                        break;
                    case "E":
                        num = 14;
                        break;
                    case "F":
                        num = 15;
                        break;
                    default:
                        num = Convert.ToInt32(caract);
                        break;
                }//fim do switch
                dec += num * Math.Pow(16, pote);
            }//fim do for
            return dec;
        }//fim do método converter decimal

        public string ConverterDecimalHexa(int dec)
        {
            int resto = 0;
            string hexadecimal = "";

            do
            {
                resto = dec % 16;
                switch (resto)
                {
                    case 10:
                        hexadecimal += "A";
                        break;
                    case 11:
                        hexadecimal += "B";
                        break;
                    case 12: 
                        hexadecimal += "C";
                        break;
                    case 13: 
                        hexadecimal += "D";
                        break;
                    case 14:
                        hexadecimal += "E";
                        break;
                    case 15:
                        hexadecimal += "F";
                        break;
                    default:
                        hexadecimal += resto;
                        break;
                }//fim do switch
                dec = dec / 16;
            } while(dec != 0);
            return new string(hexadecimal.Reverse().ToArray());
        }//fim do converter

        public string bhaskara(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta <= 0)
            {
                return "Impossível calcular X1 e X2, Delta: " + delta;
            }
            else
            {
                double X1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double X2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return "Delta: " + delta + "\nX1: " + X1 + "\nX2: " + X2; 
            }
        }//fim do bhaskara

        public string ConverterBinarioHexadecimal(string binario)
        {
            int dec = ConverterDecimal(binario);
            string hex = ConverterDecimalHexa(dec);
            return hex;
        }//Fim do metodo ConverterBinarioHexadecimal


        //----------------------------------------------------------------
        //EXERCICIOS


        //1
        public int Dobro(int num)
        {
            num = num * 2;
            return num;
        }//Fim do método Dobro

        public int Triplo(int num)
        {
            num = num * 3;
            return num;
        }//Fim do método Triplo


        //2
        public double Salario(double salario)
        {
            salario = salario * 0.3 + salario;
            return salario;
        }//Fim do método Salário


        //3
        public int ImparPar(int numero)
        {
            if (numero %2 == 0)
            {
                numero = 1;
            }
            else
            {
                numero = 2;
            }
            return numero;
        }//Fim do método Impar Par

        public int NegativoPositivo(int numero)
        {
            if (numero >= 0)
            {
                numero = 3;
            }
            else
            {
                numero = 4;
            }
            return numero;
        }//Fim do método Negativo Positivo


        //4
        public int SomaNInteiros()
        {
            int resultado = 1;
            for (int i = 1; i <= 100; i++)
            {
                resultado += i;
            }//fim do for

            return resultado;
        }//Fim do método Soma Número Inteiro


        //5
        public string TabuadaN(int numN, int num1)
        {
            string resultado = "";

            //Início;Fim;Contagem
            for (int i = 1; i <= numN; i++)
            {
                resultado += "\n" + i + " * " + num1 + " = " + (num1 * i);
            }//fim do for

            return resultado;
        }//Fim do método Soma Número Inteiro


        //6
        public string NumeroINumeroF(int numI,int numF)
        {
            string resultado = "";

            //Início;Fim;Contagem
            for (int i = numI; i <= numF; i++)
            {
                resultado += "\n" + i;
            }//fim do for

            return resultado;
        }//Fim do método Número Inicial Número Final


        //7
        public string ImparEntre()
        {
            string resultado = "";

            //Início;Fim;Contagem
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 == 1)
                {
                    resultado += "\n" + i;
                }
            }//fim do for
            
            return resultado;
        }//Fim do método Impar Entre


        //8
        public int Soma10Números()
        {
           
            int contador = 0;
            int numS;

            //Início;Fim;Contagem
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Informe um número: ");
                numS = Convert.ToInt32(Console.ReadLine());
                
                contador += numS;
            }//fim do for

            return contador;
        }//Fim do método Soma de 10 Números


        //9
        public int SomaNumeros()
        {
            int contador = 0;
            int numS;

            do
            //Início;Fim;Contagem
            {
                Console.WriteLine("Informe um número: ");
                numS = Convert.ToInt32(Console.ReadLine());

                contador += numS;
            }
            while (numS != 0);

            return contador;
        }//Fim do método Soma Números


        //10
        public int MediaAte0()
        {
            int numM;
            int cont = 0;
            int acu = 0;
            do
            {
                Console.WriteLine("Informe um número: ");
                numM = Convert.ToInt32(Console.ReadLine());
                if (numM % 2 == 0)
                {
                    acu += numM;
                    cont++;
                }
            } while (numM != 0);
            return acu / (cont - 1);

        }//Fim do método Média Até 0

        //11
        public string ValoresIAte0()
        {
            int maior = 0;
            int menor = 0;
            Boolean flag = false;
            int numeroAte = 0;
            string msg = "";

            do
            {
                Console.WriteLine("Informe um número: ");
                numeroAte = Convert.ToInt32(Console.ReadLine());
                if (flag == false)
                {
                    maior = numeroAte;
                    menor = numeroAte;
                    flag = true;
                }

                if (numeroAte != 0)
                {
                    if (numeroAte > maior)
                    {
                        maior = numeroAte;
                    }
                    if (numeroAte < menor)
                    {
                        menor = numeroAte;
                    }

                }

                msg = ("O maior número é: " + maior + " e o menor número é: " + menor);

            } while (numeroAte != 0); 
            return msg;
        }


        //12
        public string SomaPositivo()
        {
            int soma = 0;
            int cont = 0;
            int i = 0;
            string msg = "";
            int numP = 0;
            //Início;Fim;Contagem
            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine(i + "º Número: ");
                numP = Convert.ToInt32(Console.ReadLine());

                if (numP >= 0)
                {
                    soma += numP;
                }
                else
                {
                    cont += 1;
                }
            }//fim do for
            msg = "Soma dos positivos: " + numP + "\nContagem dos negativos: " + cont;
            return msg;

        }//Fim do método Soma Positivo


        //13
        public int CalcularFatorial(int numFato)
        {
            if (numFato == 0 || numFato == 1)
                return 1;
            else
                return numFato * CalcularFatorial(numFato - 1);
        }//Fim do método Fatorial


        //14
        public string MediaJogadores()
        {
            int numeroJ = 0;
            double altu;
            double cont = 0;
            string msg = "";
            double media = 0;

            Console.WriteLine("Informe o número de jogadores: ");
            numeroJ = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numeroJ; i++)
            {
                Console.WriteLine("Informe a altura do " + i + "º Jogador: ");
                altu = Convert.ToDouble(Console.ReadLine());

                cont += altu;
                media = cont / numeroJ;
            }
            msg = "Á média dos jogadores é: " + media;
            return msg;
        }//Fim do método Média dos Jogadores


        //15
        public string ConcursoMiss()
        {
            string nome = "";
            int nota = 0;
            int maiorNota = 0;
            string ganhadora = "";
            Boolean flag = false;


            for (int i = 1; i <= 3; i++)
            {
               
                Console.WriteLine("Informe o nome da " + i + "º Candidata: ");
                nome = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Informe a nota da " + i + "º Candidata: ");
                nota = Convert.ToInt32(Console.ReadLine());


                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("Insira um valor entre 0 e 10! ");
                    nota = 0;
                    nome = "";
                    i = i - 1;
                }

                if (flag == false)
                {
                    maiorNota = nota;
                    flag = true;
                    ganhadora = nome;
                }
                if (nota > maiorNota)
                {
                    maiorNota = nota;
                    ganhadora = nome;
                }
            }
            return "A maior nota é: " + maiorNota + "\nO nome da ganhadora é:" + ganhadora;
        }//Fim do método Concurso de Miss


        //16
        public string VotosMunicipio()
        {
            double numeroTotal = 0;
            double numeroVB = 0;
            double numeroVN = 0;
            double numeroVV = 0;
            string msg = "";
            double contaVB = 0;
            double contaVN = 0;
            double contaVV = 0;
            double soma = 0;


            Console.WriteLine("Informe o número total de eleitores: ");
            numeroTotal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o número de votos em branco: ");
            numeroVB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o número de votos nulos: ");
            numeroVN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o número de votos válidos: ");
            numeroVV = Convert.ToInt32(Console.ReadLine());

            soma = numeroVB + numeroVN + numeroVV;
            do
            {
                if (soma > numeroTotal)
                {
                    Console.WriteLine("Informe um número menor de votos do que o número de eleitores");
                }
                    
            } while (soma != numeroTotal);

            contaVB = (numeroVB * 100) / numeroTotal;
            contaVN = (numeroVN * 100) / numeroTotal;
            contaVV = (numeroVV * 100) / numeroTotal;

            msg = "O percentual de votos em Branco é de: " + contaVB + "%" +
                  "\nO percentual de votos Nulos é de: " + contaVN + "%" +
                  "\nO percentual de votos Válidos é de: " + contaVV + "%";
            return msg;
        }//Fim do método Votos Município


        //17
        public string CustoDoCarro()
        {
            double percenDoDistri = 0.28;
            double imposto = 0.45;
            double custoFabri = 0;
            string msg = "";
            double conta = 0;


            Console.WriteLine("Informe o custo de fábrica do carro: ");
            custoFabri = Convert.ToInt32(Console.ReadLine());

            conta = ((custoFabri * percenDoDistri) + custoFabri) + ((custoFabri * imposto) + custoFabri);
            

            msg = "O custo final para o consumidor é de: " + "R$" + conta + ",00" + "reais";
            return msg;
        }//Fim do método Custo do Carro


        //18
        public string TransformaEmDia()
        {
            int ano = 0;
            int mes = 0;
            int dia = 0;
            int idade = 0; 
            string msg = "";
            int contaAno = 0;
            int contaMes = 0;

            Console.WriteLine("Escreva sua idade em anos: ");
            ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva sua idade em mêses: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva sua idade em dias: ");
            dia = Convert.ToInt32(Console.ReadLine());

            contaAno = ano * 365;
            contaMes = mes * 30;

            idade = contaAno + contaMes + dia;

            msg = "Sua idade em dias: " + idade;
            return msg;
        }//Fim do método Transforma em dias


        //19
        public int MaiorVetor()
        {
            int maior = 0;

            int[] vet = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + "º Número");
                vet[i] = Convert.ToInt32(Console.ReadLine());
                if (vet[i] > maior)
                { 
                    maior = vet[i];
                }
            }
            return maior;
        }//Fim do método Maior Vetor


        //20
        public string OrdemVetorParImpar()
        {
            int acuPar = 0;
            int acuImpar = 0;
            string msg = "";

            int[] vet = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i + "º Número");
                vet[i] = Convert.ToInt32(Console.ReadLine());
                if (vet[i] % 2 == 0)
                {
                    acuPar += vet[i];
                }
                else
                {
                    acuImpar += vet[i];
                }
            }
            msg = "Pares: " + acuPar + "\nImpares: " + acuImpar;
            return msg;
        }//Fim do método Ordem Vetor 

    }//fim da classe
}//fim do projeto
