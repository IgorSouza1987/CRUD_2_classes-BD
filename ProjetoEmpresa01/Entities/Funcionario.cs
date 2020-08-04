using ProjetoEmpresa01.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace ProjetoEmpresa01.Entities
{
    public class Funcionario
    {
        //prop + 2x[tab]
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        //Relacionamento de Associação (TER-MUITOS)
        public List<Dependente> Dependentes { get; set; }
    }
}