﻿using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum StatusTask
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluído")]
        Concluido = 3,
    }
}
