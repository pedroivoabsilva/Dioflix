using System;
using System.Collections.Generic;
using System.Text;
using DioFlix.Interfaces;

namespace DioFlix.Classes
{
    class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> series = new List<Serie>();
        public void atualiza(int id, Serie serie)
        {
            series[id] = serie;
        }

        public void exclui(int id)
        {
            series[id].excluir();
        }

        public void insere(Serie serie)
        {
            series.Add(serie);
        }

        public List<Serie> Lista()
        {
            return series;
        }

        public int ProximoId()
        {
            return series.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return series[id];
        }
    }
}
