using System;
using System.Collections.Generic;
using System.Text;

namespace DioFlix.Interfaces
{
    public interface IStreaming
    {
        public string getTitulo();

        public int getId();

        public void excluir();

        public bool getExcluido();
        
    }
}
