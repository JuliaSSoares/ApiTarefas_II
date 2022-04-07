using System.Data;

namespace ApiTarefas_II.Data;

public class TarefaContext
{
    public delegate Task<IDbConnection> GetConnection();
}

//papel de classe de contexto;