using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace projeto_gerenciamento_de_projetos
{
    internal class Projeto
    {
        static int idAtual = 0;
        private int id;
        private string nome;
        private List<Tarefa> tarefas = new List<Tarefa>();

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public List<Tarefa> Tarefas { get => tarefas; set => tarefas = value; }

        public Projeto(string nome)
        {
            Id = idAtual++;
            Nome = nome;
        }

        public void adicionarTarefa(Tarefa t)
        {
            if (buscarTarefa(t) == null)
            {
                Tarefas.Add(t);
                Utils.MensagemSucesso("Tarefa adicionada");
            }
            else
                Utils.MensagemErro("Tarefa já existe no projeto");

        }

        public bool removerTarefa(Tarefa t)
        {
            return true;
        }

        public Tarefa buscarTarefa(Tarefa t)
        {
            return Tarefas.Find(tr => tr.Titulo == t.Titulo);
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
