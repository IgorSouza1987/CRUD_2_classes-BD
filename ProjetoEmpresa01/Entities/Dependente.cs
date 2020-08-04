using System;
using System.Collections.Generic;
using System.Text;
using ProjetoEmpresa01.Entities;
namespace ProjetoEmpresa01.Entities
{
    public class Dependente
    {
        //prop + 2x[tab]
        public int IdDependente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int IdFuncionario { get; set; }
        //Relacionamento de Associação (TER-1)
        public Funcionario Funcionario { get; set; }
    }
}