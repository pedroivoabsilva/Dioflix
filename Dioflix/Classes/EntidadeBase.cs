using System;
using System.Collections.Generic;
using System.Text;

namespace DioFlix.Classes
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }
        protected bool Excluido { get; set; }
    }
}
