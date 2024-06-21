using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Funcionario
    {
        protected internal int Id { get; set; } = 456; //Deve ter um ID de funcionário acessível dentro do assembly e em subclasses.

        protected string AdicionarLivro() //Deve haver um método para adicionar um livro à biblioteca, acessível apenas dentro da classe e suas subclasses.
        {
            return $"Eu sou o funcionário {Id} e adicionei um livro";
        }

        private protected string RemoverLivro() //Deve haver um método para remover um livro da biblioteca, acessível apenas dentro da classe e suas subclasses dentro do mesmo assembly.
        {
            return $"Eu sou o funcionário {Id} e removi um livro";
        }
        public string NovoFuncionario() //Deve haver um método público para registrar um novo funcionário.
        {
            return $"Eu sou um novo funcionário com Id {Id}";
        }

        public string ChamandoAdicionar()
        {
            return AdicionarLivro();
        }
        public string ChamandoRemover()
        {
            return RemoverLivro();
        }
    }
}
