using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoEmprestimo
{
    public class Pessoa
    {
        public string nome { get; set; } //a mudar
        public string documento { get; set; } //a mudar

        public virtual void ContaBancaria()
        {
            Console.WriteLine("pessoas costumam tem contas no banco");
        }
        public virtual void Emprestimo()
        {
            Console.WriteLine("pessoas costumam pedir emprestimos");
        }
    }
    public class Fisica : Pessoa
    {
        public override void ContaBancaria()
        {
            Console.WriteLine("PF costumam ter contas cadastradas no CPF");
        }
        public override void Emprestimo()
        {
            Console.WriteLine("PF costumam pedir emprestimos menores");
        }
    }
    public class Juridica : Pessoa
    {
        public override void ContaBancaria()
        {
            Console.WriteLine("PJ costumam ter contas cadastradas no CNPJ");
        }
        public override void Emprestimo()
        {
            Console.WriteLine("PJ costumam pedir emprestimos maiores");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Você é uma Pessoa Física ou Jurídica?");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "física" || resposta == "fisica")
            {
                Console.WriteLine("Você gostaria de realizar um empréstimo?");
                string respPf = Console.ReadLine().ToLower();

                if (respPf == "sim")
                {
                    Console.WriteLine("Qual o valor do empréstimo?");
                    double valorPF = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Qual a quantidade de parcelas?");
                    Console.WriteLine("Você pode parcelar em até 12x");
                    int parcelasPF = Convert.ToInt32(Console.ReadLine());

                    double empJuros;
                    double valorParc;

                    empJuros = valorPF * 0.05;
                    valorParc = (valorPF + empJuros) / parcelasPF;

                    Console.Clear();
                    Console.WriteLine("o empréstimo com 5% de juros ficou no valor de {0}, em {1} parcelas de {2}", (empJuros + valorPF), parcelasPF, valorParc);
                    Console.WriteLine("");

                    Console.WriteLine("Qual o valor do saque?");
                    double saque = Convert.ToDouble(Console.ReadLine());

                    if (saque < (empJuros + valorPF))
                    {
                        Console.Clear();   
                        Console.WriteLine("Saque de {0} reais realizado com sucesso", saque);
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente");
                    }


                }
                else
                {
                    Console.WriteLine("Obrigado por nos consultar");
                }
            }

            else if (resposta == "jurídica" || resposta == "juridica")
            {
                Console.WriteLine("Você gostaria de realizar um empréstimo?");
                string respPj = Console.ReadLine().ToLower();

                if (respPj == "sim")
                {
                    Console.WriteLine("Qual o valor do empréstimo?");
                    double valorPJ = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Qual a quantidade de parcelas?");
                    Console.WriteLine("Você pode parcelar em até 24x");
                    int parcelasPJ = Convert.ToInt32(Console.ReadLine());

                    double empJurosPJ;
                    double valorParcPJ;

                    empJurosPJ = valorPJ * 0.10;
                    valorParcPJ = (valorPJ + empJurosPJ) / parcelasPJ;

                    Console.Clear();
                    Console.WriteLine("o empréstimo com 10% de juros ficou no valor de {0}, em {1} parcelas de {2}", (empJurosPJ + valorPJ), parcelasPJ, valorParcPJ);
                    Console.WriteLine("");

                    Console.WriteLine("Qual o valor do saque?");
                    double saquePJ = Convert.ToDouble(Console.ReadLine());

                    if (saquePJ < (empJurosPJ + valorPJ))
                    {
                        Console.Clear();
                        Console.WriteLine("Saque de {0} reais realizado com sucesso", saquePJ);
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente");
                    }
                   
                }

                else
                {
                    Console.WriteLine("Obrigado por nos consultar");
                }

            }
            else
            {
                Console.WriteLine("Resposta inválida");
            }
        }

    }

}
                
