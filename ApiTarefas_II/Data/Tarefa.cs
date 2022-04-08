using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTarefas_II.Data;

[Table("Tarefas")]//mapeia para Tarefa
public record Tarefa(int Id, string Atividade, string Status);

//Definindo modelo de dominio record(somente leitura) ini com construcutor; params correspndem as colunas no db;