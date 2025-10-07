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
            return true;
        }

        public bool remover(Projeto p)
        {
            return true;
        }

        public Projeto buscar(Projeto p)
        {
            return p;
        }

        public List<Projeto> listar()
        {
            return itens;
        }
    }
}
