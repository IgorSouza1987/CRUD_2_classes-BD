using System;
using ProjetoEmpresa01.Controllers;
using ProjetoEmpresa01.Entities; 
using ProjetoEmpresa01.Repositories; 
namespace ProjetoEmpresa01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*** CONTROLE DE FUNCIONARIOS E DEPENDENTES * **\n");
        
try
            {
                Console.WriteLine("(1) Cadastrar Funcionário");
                Console.WriteLine("(2) Atualizar Funcionário");
                Console.WriteLine("(3) Excluir Funcionário");
                Console.WriteLine("(4) Consultar Funcionários");
                Console.WriteLine("-");
                Console.WriteLine("(5) Cadastrar Dependente");
                Console.WriteLine("(6) Atualizar Dependente");
                Console.WriteLine("(7) Excluir Dependente");
                Console.WriteLine("(8) Consultar Dependentes");
                Console.Write("\nInforme a opção desejada: ");
                int opcao = int.Parse(Console.ReadLine());
                //criando os objetos
                var funcionarioController = new FuncionarioController();
                var dependenteController = new DependenteController();
                switch (opcao)
                {
                    case 1:
                        funcionarioController.CadastrarFuncionario();

                        break;
                    case 2:
                        funcionarioController.AtualizarFuncionario();

                        break;
                    case 3:
                        funcionarioController.ExcluirFuncionario();

                        break;
                    case 4:
                        funcionarioController.ConsultarFuncionarios();

                        break;
                    case 5:
                        dependenteController.CadastrarDependente();

                        break;
                    case 6:
                        dependenteController.AtualizarDependente();

                        break;
                    case 7:
                        dependenteController.ExcluirDependente();

                        break;
                    case 8:
                        dependenteController.ConsultarDependentes();

                        break;
                    default:
                        Console.WriteLine("\nOpção inválida.");
                        break;
                }
            }
            catch (Exception e)
            {
                //imprimindo mensagem de erro
                Console.WriteLine("Erro: " + e.Message);
            }

            finally
            {
                Console.WriteLine("\nFim do Programa!");
            }
            Console.ReadKey(); //pausar a execução
        }
    }
}