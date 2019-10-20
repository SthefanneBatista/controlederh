using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    class Program
    {
         class Funcionario
        {
            private string v;
            private string nome;
            private int salario;

            public Funcionario(string nome, int salario)
            {
                this.nome = nome;
                this.salario = salario;

                Console.WriteLine("O nome do funcionário é " + nome + " e recebe " + salario + " reais");


            }

            public Funcionario(string v, string nome, int salario)
            {
                this.v = v;
                this.nome = nome;
                this.salario = salario;
            }
            static void Main(string[] args)
            {
                string nome;
                int salario;

                Console.WriteLine("Digite o nome do funcionário: "); nome = Console.ReadLine();
                Console.WriteLine("Digite o salário do funcionário: "); salario = int.Parse(Console.ReadLine());

                Funcionario fun = new Funcionario(nome, salario);

                Console.ReadKey();
            }
        }
    }
}
