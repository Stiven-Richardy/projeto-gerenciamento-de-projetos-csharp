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
            bool projetoAdicionado = false;
            if (buscar(p) == null)
            {
                itens.Add(p);
                projetoAdicionado = true;
            }
            return projetoAdicionado;
        }

        public bool remover(Projeto p)
        {
            bool projetoRemovido = false;
            if (buscar(p) != null)
            {
                itens.Remove(p);
                projetoRemovido = true;
            }
            return projetoRemovido;
        }

        public Projeto buscar(Projeto p)
        {
            Projeto projetoAchado = itens.Find(pp => pp.Nome == p.Nome);
            return projetoAchado;
        }

        public List<Projeto> listar()
        {
            return itens;
        }
    }
}
