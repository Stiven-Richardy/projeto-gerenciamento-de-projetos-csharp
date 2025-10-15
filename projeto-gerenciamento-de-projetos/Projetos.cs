using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_gerenciamento_de_projetos
{
    internal class Projetos
    {
        private List<Projeto> itens = new List<Projeto>();

        public List<Projeto> Itens { get => itens; set => itens = value; }

        public Projetos() { }

        public bool adicionar(Projeto p)
        {
            itens.Add(p);
            bool projetoAdicionado = true;
            return projetoAdicionado;
        }

        public bool remover(Projeto p)
        {
            bool projetoRemovido = false;
            if (buscar(p.Nome) != null)
            {
                itens.Remove(p);
                projetoRemovido = true;
            }
            return projetoRemovido;
        }

        public Projeto buscar(string nome)
        {
            Projeto projetoAchado = itens.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            return projetoAchado;
        }

        public List<Projeto> listar()
        {
            return itens;
        }
    }
}
