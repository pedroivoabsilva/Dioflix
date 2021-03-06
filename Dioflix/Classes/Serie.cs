using DioFlix.Enumeravel;
using DioFlix.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DioFlix.Classes
{
    public class Serie : EntidadeBase, IStreaming
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        public int Temporada { get; set; }
        private int Ano { get; set; }
        
        public Serie(int id,Genero genero, string titulo, string descricao, int ano, int temporada)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Temporada = temporada;
            Excluido = false;
        }

        public override string ToString()
        {
            return $"Gênero: {Genero}\n" +
                    $"Titulo:{Titulo}\n" +
                    $"Descrição: {Descricao}\n" +
                    $"Ano de início: {Ano}\n" +
                    $"Temporada: {Temporada}\n" +
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

