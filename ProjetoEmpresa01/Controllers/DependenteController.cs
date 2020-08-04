using Projeto04.Repositories;
using ProjetoEmpresa01.Contracts;
using ProjetoEmpresa01.Entities;
using ProjetoEmpresa01.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEmpresa01.Controllers
{
    public class DependenteController
    {
        
        private IDependenteRepository dependenteRepository;
        private IFuncionarioRepository funcionarioRepository;
        
        public DependenteController()
        {
        
            dependenteRepository = new DependenteRepository();
            funcionarioRepository = new FuncionarioRepository();
        }
        //método para realizar o cadastro do dependente
        public void CadastrarDependente()
        {
            var dependente = new Dependente();
            try
            {
                Console.WriteLine("\nCADASTRO DE DEPENDENTE:\n");
                Console.Write("Nome do Dependente..............: ");
                dependente.Nome = Console.ReadLine();
                Console.Write("Data de Nascimento..............: ");
                dependente.DataNascimento = DateTime.Parse(Console.ReadLine());
                Console.Write("Id do Funcionário...............: ");
                dependente.IdFuncionario = int.Parse(Console.ReadLine());
                //verificando se o funcionario informado existe

                //no banco de dados..

                if (funcionarioRepository.GetById
                (dependente.IdFuncionario) != null)

                {
                    dependenteRepository.Create(dependente);

                    Console.WriteLine("\nDependente cadastrado com sucesso!");

                }
                else
                {
                    Console.WriteLine("\nNão foi possível realizar o cadastro do dependente.");
                Console.WriteLine("O Funcionário informado não foi encontrado!");
                
}

            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }
        //método para realizar o atualizar o dependente
        public void AtualizarDependente()
        {
            try
            {
                Console.WriteLine("\nATUALIZAÇÃO DE DEPENDENTE:\n");
                Console.Write("Id do Dependente................: ");
                var idDependente = int.Parse(Console.ReadLine());
                //buscar o dependente no banco de dados pelo id..
                var dependente = dependenteRepository.GetById(idDependente);
                //verificar se o dependente foi encontrado
                if (dependente != null)
                {
                    Console.Write("Altere o Nome do Dependente.....: ");
                    dependente.Nome = Console.ReadLine();
                    Console.Write("Altere a Data de Nascimento.....: ");

                    dependente.DataNascimento = DateTime.Parse
                    (Console.ReadLine());
                    Console.Write("Altere o Id do Funcionário......: ");
                    dependente.IdFuncionario = int.Parse(Console.ReadLine());
                    //verificando se o funcionario informado

                    //existe no banco de dados..
                    if (funcionarioRepository.GetById(dependente.IdFuncionario) != null)

                    {
                        dependenteRepository.Update(dependente);
                        Console.WriteLine("\nDependente atualizado com sucesso!");
                    
}
                    else
                    {

                        Console.WriteLine("\nNão foi possível realizar a atualização do dependente.");
                    Console.WriteLine("O Funcionário informado não foi encontrado!");
                    
}
                }
                else
                {
                    Console.WriteLine("\nDependente não foi encontrado.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }
        public void ExcluirDependente()
        {
            try
            {
                Console.WriteLine("\nEXCLUSÃO DE DEPENDENTE:\n");
                Console.Write("Id do Dependente................: ");
                var idDependente = int.Parse(Console.ReadLine());
                //buscar o dependente no banco de dados pelo id..
                var dependente = dependenteRepository.GetById(idDependente);
                //verificar se o dependente foi encontrado
                if (dependente != null)
                {
                    dependenteRepository.Delete(dependente);

                    Console.WriteLine("\nDependente excluído com sucesso!");

                }
                else
                {
                    Console.WriteLine("\nDependente não foi encontrado.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }

        public void ConsultarDependentes()
        {
            try
            {
                Console.WriteLine("\nCONSULTA DE DEPENDENTES\n");
                var dependentes = dependenteRepository.GetAll();
                foreach (var item in dependentes)
                {
                    Console.WriteLine("Id do Dependente......: " + item.IdDependente);

                    Console.WriteLine("Nome..................: "+ item.Nome);

                    Console.WriteLine("Data de Nascimento....: "+ item.DataNascimento.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Id do Funcionário.....: "+ item.IdFuncionario);
                    Console.WriteLine("----");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }
    }
}
