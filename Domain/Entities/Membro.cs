using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Membro
    {
        public string Nome { get; set; } //Deve ter um nome acessível por qualquer pessoa.
        private int Id { get; set; } = 891; //Deve ter um ID de membro que só pode ser acessado dentro da classe.

        internal string EmprestarLivro() //Deve haver um método para pegar um livro emprestado acessível apenas dentro do assembly.
        {
            return $"Eu {Id}-{Nome} emprestei um livro";
        }
        private protected string ObterMembro() // Deve haver um método protegido para obter informações detalhadas sobre o membro.
        {
            return $"Eu {Id}-{Nome} sou um membro";
        }

        public string ChamandoObterMembro()
        {
            return ObterMembro();
        }

    }
}
