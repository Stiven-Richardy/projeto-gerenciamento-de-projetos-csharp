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
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
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
    }
}
