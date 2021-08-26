using System;
using System.Collections.Generic;
using System.Text;

namespace DioFlix.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void insere(T entidade);
        void exclui(int id);
        void atualiza(int id, T entidade);
        int ProximoId();
    }
}
