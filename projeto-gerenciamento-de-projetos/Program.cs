/*
| Instituto Federal de São Paulo - Campus Cubatão
| Nome: Guilherme Mendes de Sousa - CB3030857
| Nome: Stiven Richardy Silva Rodrigues - CB3030202
| Turma: ADS 471
| 
| Opções no seletor:
| 0. Sair
| 1. Adicionar projeto
| 2. Pesquisar projeto (mostrar tarefas por status e totais)
| 3. Remover projeto (apenas se sem tarefas)
| 4. Adicionar tarefa em projeto
| 5. Concluir tarefa
| 6. Cancelar tarefa
| 7. Reabrir tarefa
| 8. Listar tarefas de um projeto
| 9. Filtrar tarefas por status ou prioridade em um projeto
| 10. Filtrar tarefas por status ou prioridade em todos os projetos
| 11. Resumo geral: qtde de projetos, tarefas abertas/fechadas/canceladas, % concluídas em relação às abertas
*/

namespace projeto_gerenciamento_de_projetos
{
    internal class Program
    {
        public static Projetos itens = new Projetos();
        static void Main(string[] args)
        {
            int seletor = -1;
            while (seletor != 0)
            {
                Console.Clear();
                Utils.Titulo("PAINEL PRINCIPAL");
                Console.WriteLine(" 0 - Sair\n" +
                    " 1 - Adicionar Projeto\n" +
                    " 2 - Pesquisar Projeto\n" +
                    " 3 - Remover Projeto\n" +
                    " 4 - Adicionar Tarefa em Projeto\n" +
                    " 5 - Concluir Tarefa\n" +
                    " 6 - Cancelar Tarefa\n" +
                    " 7 - Reabrir Tarefa\n" +
                    " 8 - Listar Tarefas de um Projeto\n" +
                    " 9 - Filtrar Tarefas por Status ou Prioridade em um Projeto\n" +
                    " 10 - Filtrar Tarefas por status ou Prioridade em Todos os Projetos\n" +
                    " 11 - Resumo Geral");
                Console.WriteLine(new string('-', 70));
                Console.Write(" Escolha uma opção: ");
                seletor = Utils.lerInt(Console.ReadLine(), 0, " Entrada inválida!\n Informe outro número: ");

                switch (seletor)
                {
                    case 0:
                        Console.WriteLine(" Programa finalizado!");
                        break;
                    case 1:
                        adicionarProjeto();
                        break;
                    case 2:
                        pesquisarProjeto();
                        break;
                    case 3:
                        removerProjeto();
                        break;
                    case 4:
                        adicionarTarefa();
                        break;
                    case 5:
                        concluirTarefa();
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        listarTarefas();
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    default:
                        Utils.MensagemErro("Digite um número de 0-11!");
                        break;
                }
            }
        }

        static void adicionarProjeto()
        {
            Utils.Titulo("ADICIONAR PROJETO");
            Console.Write(" Digite o Nome do Projeto: ");
            string nome = Console.ReadLine();
            Projeto novoProjeto = new Projeto(nome);
            if(itens.adicionar(novoProjeto))
                Utils.MensagemSucesso("Projeto adicionado!");
            else
                Utils.MensagemErro("O projeto já existe.");
        }
        static void adicionarTarefa()
        {
            Utils.Titulo("ADICIONAR TAREFA");
            Console.Write("Informe o nome do projeto: ");
            string nome = Console.ReadLine();
            Projeto projeto = itens.buscar(new Projeto(nome));
            if ( projeto != null)
            {
                Console.Write("Informe o título da tarefa: ");
                string titulo = Console.ReadLine();
                Console.Write("Digite a descrição da tarefa: ");
                string desc = Console.ReadLine();
                Console.Write("Digite a prioridade  (1- Alta, 2- Média, 3- Baixa): ");
                int prioridade = Utils.lerMinMax(Console.ReadLine(), 1, 3, "Prioridade inválida. Digite a prioridade: ");
                Tarefa tarefa = new Tarefa(titulo, desc, prioridade);
                projeto.adicionarTarefa(tarefa);
                
            }
            else
                Utils.MensagemErro("Projeto não encontrado.");
        }

        static void concluirTarefa()
        {
            Utils.Titulo("CONCLUIR TAREFA");
            Console.Write("Informe o nome do projeto: ");
            string nome = Console.ReadLine();
            Projeto projeto = itens.buscar(new Projeto(nome));
            if (projeto != null)
            {
                Console.Write("Informe o título da tarefa: ");
                string titulo = Console.ReadLine();
                Tarefa tarefa = projeto.buscarTarefa(new Tarefa(titulo));
                if (tarefa != null)
                {
                    tarefa.concluir();
                }
                else
                    Utils.MensagemErro("Tarefa não enontrada");
            }
            else
                Utils.MensagemErro("Projeto não encontrado.");

        }

        static void listarTarefas()
        {
            Utils.Titulo("LISTAR TAREFAS");
            Console.Write("Informe o nome do projeto: ");
            string nome = Console.ReadLine();
            Projeto projeto = itens.buscar(new Projeto(nome));
            if (projeto != null)
            {
                int qtdTarefas = projeto.totalAberta() + projeto.totalFechadas();
                if (qtdTarefas > 0)
                {
                    Console.WriteLine($"Tarefas de {projeto.Nome}\n");
                    foreach (Tarefa trf in projeto.Tarefas)
                    {
                        if (trf.Status != "Cancelada")
                        {
                            string prioridade = trf.Prioridade == 1 ? "Alta" : trf.Prioridade == 2 ? "Média" : "Baixa";
                            Console.WriteLine($"Titulo: {trf.Titulo}\n" +
                                $"Descrição: {trf.Descricao}\n" +
                                $"Prioridade: {prioridade}\n" +
                                $"Status: {trf.Status} \n" +
                                $"Inicio: {trf.DataCriacao}\n");
                            if (trf.DataConclusao != null)
                            {
                                Console.WriteLine($"Finalizado: {trf.DataConclusao}");
                            }
                        }
                    }
                    Utils.MensagemSucesso(" Listando tarefas abertas e concluidas...");
                }
                else
                {
                    Utils.MensagemErro("Nenhuma tarefa no projeto");
                }

            }
            else
                Utils.MensagemErro("Projeto não encontrado");
        }
        static void pesquisarProjeto()
        {
            Utils.Titulo("PESQUISAR PROJETO (1/2)");
            Console.Write(" Digite o Nome do Projeto: ");
            string nome = Console.ReadLine();
            Projeto pesquisaProjeto = new Projeto(nome);
            if (itens.buscar(pesquisaProjeto) != null)
            {
                Utils.Titulo("PESQUISAR PROJETO (2/2)");
                Console.WriteLine(" DADOS DO PROJETO: \n" +
                    $" Id: {pesquisaProjeto.Id}\n" +
                    $" Nome: {pesquisaProjeto.Nome}\n" +
                    $"\n TAREFAS DO PROJETO: ");
                foreach (Tarefa t in pesquisaProjeto.Tarefas)
                {
                    Console.WriteLine($"Tarefa: {t.Descricao}\n" +
                        $"Status: {t.Status}\n");
                }
                Console.WriteLine($"\n Total de Tarefas Abertas: {pesquisaProjeto.totalAberta()}\n" +
                    $" Total de Tarefas Fechadas: {pesquisaProjeto.totalFechadas()}");
                Utils.MensagemSucesso("Projeto encontrado!");
            }
            else
                Utils.MensagemErro("Projeto não encontrado.");
        }

        static void removerProjeto()
        {
            Utils.Titulo("REMOVER PROJETO (1/2)");
            Console.Write(" Digite o Nome do Projeto: ");
            string nome = Console.ReadLine();
            Projeto removeProjeto = new Projeto(nome);
            if (itens.remover(removeProjeto) && removeProjeto.Tarefas.Count() == 0)
                Utils.MensagemSucesso("Projeto removido!");
            else
                Utils.MensagemErro("Projeto não encontrado.");
        }
    }
}
