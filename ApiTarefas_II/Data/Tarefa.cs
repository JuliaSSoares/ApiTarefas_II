using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTarefas_II.Data;

[Table("Tarefas")]
public record Tarefa(int Id, string Atividade, string Status);

