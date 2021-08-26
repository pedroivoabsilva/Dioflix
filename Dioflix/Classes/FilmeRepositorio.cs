using System;
using System.Collections.Generic;
using System.Text;
using DioFlix.Interfaces;

namespace DioFlix.Classes
{
    class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> filmes = new List<Filme>();
        public void atualiza(int id, Filme filme)
        {
            filmes[id] = filme;
        }

        public void exclui(int id)
        {
            filmes[id].excluir();
        }

        public void insere(Filme filme)
        {
            filmes.Add(filme);
        }

        public List<Filme> Lista()
        {
            return filmes;
        }

        public int ProximoId()
        {
            return filmes.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return filmes[id];
        }
    }
}
