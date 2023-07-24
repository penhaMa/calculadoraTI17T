using System;
using System.Collections.Generic;
using System.Linq;
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
        public string Soma10Números(int numS)
        {
            string resultado = "";

            //Início;Fim;Contagem
            for (int i = 1; i <= 10; i++)
            {
                i += numS;
                resultado += "\n" + (numS + i);
            }//fim do for

            return resultado;
        }//Fim do método Soma de 10 Números


        //9
        public string SomaNúmeros(int numS)
        {
            string resultado = "";

            //Início;Fim;Contagem
            for (int i = 1; i <= 10; i++)
            {
                i += numS;
                resultado += "\n" + (numS + i);
            }//fim do for

            return resultado;
        }//Fim do método Soma Números


        //10
        public int MediaAte0(int numM)
        {
            do
            {
                int acu = 0;
                if (numM % 2 == 0)
                {
                    acu += numM;
                }
                else
                {
                    numM = -1;
                }
                return acu / numM;
            } while (numM == 0);
            
        }//Fim do método Média Até 0

    }//fim da classe
}//fim do projeto
