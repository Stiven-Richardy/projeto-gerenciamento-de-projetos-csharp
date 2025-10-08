using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_gerenciamento_de_projetos
{
    internal class Projeto
    {
        private int id;
        private string nome;
        private List<Tarefa> tarefas = new List<Tarefa>();

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public List<Tarefa> Tarefas { get => tarefas; set => tarefas = value; }

        public Projeto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void adicionarTarefa(Tarefa t)
        {

        }

        public bool removerTarefa(Tarefa t)
        {
            return true;
        }

        public Tarefa buscarTarefa(Tarefa t)
        {
            return t;
        }

        public List<Tarefa> tarefasPorStatus(string s)
        {
            return tarefas;
        }

        public List<Tarefa> tarefasPorPrioridade(int p)
        {
            return tarefas;
        }

        public int totalAberta()
        {
            return 0;
        }

        public int totalFechadas()
        {
            return 0;
        }
    }
}
