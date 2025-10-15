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
            Id = ++idAtual;
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
            bool tarefaRemovida = false;
            if (buscarTarefa(t) != null)
            {
                Tarefas.Remove(t);
                tarefaRemovida = true;
            }
            return tarefaRemovida;
        }

        public Tarefa buscarTarefa(Tarefa t)
        {
            return Tarefas.Find(tr => tr.Titulo == t.Titulo);
        }

        public List<Tarefa> tarefasPorStatus(string s)
        {
            return Tarefas.FindAll(tr => tr.Status == s);
        }

        public List<Tarefa> tarefasPorPrioridade(int p)
        {
            return Tarefas.FindAll(tr => tr.Prioridade == p);
        }

        public int totalAberta()
        {
            return Tarefas.Count(t => t.Status == "Aberta");
        }

        public int totalFechadas()
        {
            return Tarefas.Count(t => t.Status == "Fechada");
        }
    }
}
