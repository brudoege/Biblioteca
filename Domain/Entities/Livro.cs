using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Livro
    {
        public string Titulo { get; set; } //Deve ter um título acessível por qualquer pessoa
        protected string Autor { get; set; } = "Maria"; //O autor deve ser protegido para ser acessível apenas dentro da classe e suas subclasses
        internal int CodigoIsbn { get; set; } = 10101; //O código ISBN deve ser acessível apenas dentro do assembly.

        public string ObterResumo() //Deve haver um método para obter um resumo do livro que pode ser chamado por qualquer pessoa.
        {
            return $"Resumo do livro {CodigoIsbn}-{Titulo} do autor {Autor}";
        }
    }
}
