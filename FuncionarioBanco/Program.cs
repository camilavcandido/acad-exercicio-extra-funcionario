using System;

namespace FuncionarioBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.nome = "Camila";
            f1.departamento = "Desenvolvimento";
            f1.salario = 5000;
            f1.dataAdmissao = "28/03/2022";
            f1.rg = "494370427";
            f1.status = true;

            Funcionario f2 = new Funcionario();
            f2.nome = "João";
            f2.departamento = "Marketing";
            f2.salario = 3000;
            f2.dataAdmissao = "03/02/2019";
            f2.rg = "324718111";
            f2.status = true;


            Funcionario f3 = f1;

            f1.Bonifica(500);
            f1.ExibirDadosFuncionario();

            f2.Demite();
            f2.ExibirDadosFuncionario();

            if (f1 == f2)
                Console.WriteLine("Iguais");
            else
                Console.WriteLine("Diferentes");


            if (f1 == f3)
                Console.WriteLine("Iguais");
            else
                Console.WriteLine("Diferentes");

          
        }
    }
}

