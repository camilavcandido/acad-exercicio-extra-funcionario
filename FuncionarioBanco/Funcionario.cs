using System;
namespace FuncionarioBanco
{
    public class Funcionario
    {
        public string nome;
        public string departamento;
        public double salario;
        public string dataAdmissao;
        public string rg;
        public bool status;

        public void Bonifica(double valor)
        {
            salario += valor;
        }

        public void Demite()
        {
            status = false;
        }

        public void ExibirDadosFuncionario()
        {
            Console.WriteLine("\nNome: {0}" +
                "\nDepartamento: {1}" +
                "\nSalário: {2}" +
                "\nData Admissão: {3}" +
                "\nRG: {4}" +
                "\nFuncionário Atual: {5}", nome, departamento, salario, dataAdmissao, rg, status);
        }

    }
}

