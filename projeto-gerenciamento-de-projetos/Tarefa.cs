using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_gerenciamento_de_projetos
{
    internal class Tarefa
    {
        static int idAtual = 0;
        private int id;
        private string titulo;
        private string descricao;
        private int prioridade;
        private string status;
        private DateTime? dataCriacao;
        private DateTime? dataConclusao;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Prioridade { get => prioridade; set => prioridade = value; }
        public string Status { get => status; set => status = value; }
        public DateTime? DataCriacao { get => dataCriacao; set => dataCriacao = value; }
        public DateTime? DataConclusao { get => dataConclusao; set => dataConclusao = value; }

        public Tarefa(int id, string titulo, string descricao, int prioridade, string status, DateTime dataCriacao, DateTime dataConclusao)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Prioridade = prioridade;
            Status = status;
            DataCriacao = dataCriacao;
            DataConclusao = dataConclusao;
        }
        
        public Tarefa(string titulo, string descricao, int prioridade)
        {
            Id = idAtual++;
            Titulo = titulo;
            Descricao = descricao;
            Prioridade = prioridade;
            Status = "Aberta";
            DataCriacao = DateTime.Now;
        }

        public void concluir()
        {

        }

        public void cancelar()
        {

        }

        public void reabrir()
        {

        }
    }
}
