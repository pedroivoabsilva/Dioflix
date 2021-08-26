using System;
using System.Collections.Generic;
using System.Text;
using DioFlix.Enumeravel;
using DioFlix.Interfaces;

namespace DioFlix.Classes
{
    public class Filme : EntidadeBase, IStreaming
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        public Filme(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }
        public override string ToString()
        {
            return $"Gênero: {Genero}\n" +
                    $"Titulo:{Titulo}\n" +
                    $"Descrição: {Descricao}\n" +
                    $"Ano de início: {Ano}\n" +
                    $"Excluído: {Excluido}";
        }
        public string getTitulo()
        {
            return Titulo;
        }
        public int getId()
        {
            return Id;
        }
        public void excluir()
        {
            Excluido = true;
        }
        public bool getExcluido()
        {
            return Excluido;
        }

    }
}
