using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Administrador
    {
        private int Id { get; set; } = 123; //Deve ter um ID de administrador acessível apenas dentro da classe.

        internal string GerenciarBiblioteca() //Deve haver um método para gerenciar a biblioteca acessível apenas dentro do assembly.
        {
            return $"Eu sou o administrador {Id} e estou gerenciando a biblioteca";
        }

        private protected string ObterAdministrador() //Deve haver um método protegido para obter informações detalhadas sobre o administrador.
        {
            return $"Eu sou o administrador {Id}";
        }

        public string ChamandoObterAdministrador()
        {
            return ObterAdministrador();
        }
    }
}
