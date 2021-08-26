using DioFlix.Classes;
using System;
using DioFlix.Enumeravel;
using System.Collections.Generic;
using System.Text;

namespace DioFlix
{
    public class Tela
    {
        static SerieRepositorio repositorioSeries = new SerieRepositorio();
        static FilmeRepositorio repositorioFilmes = new FilmeRepositorio();
        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DioFlix ao seu dispor!");
            Console.WriteLine("Infomer a opção desejada:");

            Console.WriteLine("1- Filme");
            Console.WriteLine("2- Série");
            Console.WriteLine("X - Sair");
            
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        public static string MenuSerie()
        {
            Console.WriteLine("Infomer a opção desejada:");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova séries");
            Console.WriteLine("3- Atualizar séries");
            Console.WriteLine("4- Excluir séries");
            Console.WriteLine("5- Visualizar séries");
            Console.WriteLine("X- Menu Principal");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }

        public static string MenuFilme()
        {
            Console.WriteLine("Infomer a opção desejada:");

            Console.WriteLine("1- Listar filmes");
            Console.WriteLine("2- Inserir novo filmes");
            Console.WriteLine("3- Atualizar filmes");
            Console.WriteLine("4- Excluir filmes");
            Console.WriteLine("5- Visualizar filmes");
            Console.WriteLine("X- Menu Principal");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        public static void ListaSeries()
        {
            Console.WriteLine("Listar séries");
            var lista = repositorioSeries.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma séries encontrada");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.getExcluido();
                Console.WriteLine($"#ID {serie.getId()} - {serie.getTitulo()}  {(excluido ? "Excluido" : "")}");
            }

        }
        public static void ListaFimes()
        {
            Console.WriteLine("Listar filmes");
            var lista = repositorioFilmes.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme encontrado");
                return;
            }
            foreach (var filme in lista)
            {
                var excluido = filme.getExcluido();
                Console.WriteLine($"#ID {filme.getId()} - {filme.getTitulo()}  {(excluido ? "Excluido" : "")}");
            }

        }
        public static Serie CriaSerie()
        {

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o numero do gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            if (entradaGenero < 1 || entradaGenero > 13)
                throw new ModelException("Genero não encontrado");

            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a tempotada: ");
            int entradaTemporada = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da séries: ");
            string entradaDescricao = Console.ReadLine();

            Serie serieCriada = new Serie(id: repositorioSeries.ProximoId(),
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                descricao: entradaDescricao,
                ano: entradaAno,
                temporada: entradaTemporada);
            return serieCriada;

        }
        public static Filme CriaFilme()
        {

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o numero do gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            if (entradaGenero < 1 || entradaGenero > 13)
                throw new ModelException("Genero não encontrado");

            Console.Write("Digite o título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de início do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme filmeCriado = new Filme(id: repositorioFilmes.ProximoId(),
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                descricao: entradaDescricao,
                ano: entradaAno);
            return filmeCriado;

        }
        public static void InserirSerie()
        {
            try
            {
                Console.WriteLine("Inserir nova série");
                Serie novaSerie = CriaSerie();
                repositorioSeries.insere(novaSerie);
            }
            catch (Exception e)
            {

                Console.WriteLine("Erro ao criar a séries: " + e.Message);
            }


        }
        public static void InserirFilme()
        {
            try
            {
                Console.WriteLine("Inserir nova série");
                Filme novoFilme = CriaFilme();
                repositorioFilmes.insere(novoFilme);
            }
            catch (Exception e)
            {

                Console.WriteLine("Erro ao criar o filme: " + e.Message);
            }


        }
        public static void AtualizarSerie()
        {
            try
            {
                Console.Write("Digite o Id da série que deseja atualizar: ");
                int entradaId = int.Parse(Console.ReadLine());
                Serie serieAtualizada = CriaSerie();


                repositorioSeries.atualiza(entradaId, serieAtualizada);
            }
            catch (Exception)
            {

                Console.WriteLine("Id não encontrado"); ;
            }


        }
        public static void AtualizarFilme()
        {
            try
            {
                Console.Write("Digite o Id do filme que deseja atualizar: ");
                int entradaId = int.Parse(Console.ReadLine());
                Filme FilmeAtualizado = CriaFilme();


                repositorioFilmes.atualiza(entradaId, FilmeAtualizado);
            }
            catch (Exception)
            {

                Console.WriteLine("Id não encontrado"); ;
            }


        }
        public static void ExcluiSerie()
        {
            try
            {
                Console.Write("Digite o Id da série que deseja excluir: ");
                int entradaId = int.Parse(Console.ReadLine());
                repositorioSeries.exclui(entradaId);
            }
            catch (Exception)
            {

                Console.WriteLine("Id não encontrado");
            }


        }
        public static void ExcluiFilme()
        {
            try
            {
                Console.Write("Digite o Id do filme que deseja excluir: ");
                int entradaId = int.Parse(Console.ReadLine());
                repositorioFilmes.exclui(entradaId);
            }
            catch (Exception)
            {

                Console.WriteLine("Id não encontrado");
            }


        }
        public static void VisualizarSerie()
        {
            try
            {
                Console.Write("Digite o Id da série que deseja vizualizar: ");
                int entradaId = int.Parse(Console.ReadLine());
                Console.WriteLine(repositorioSeries.RetornaPorId(entradaId));
            }
            catch (Exception)
            {

                Console.WriteLine("Id não encontrado");
            }

        }
        public static void VisualizarFilme()
        {
            try
            {
                Console.Write("Digite o Id da filme que deseja vizualizar: ");
                int entradaId = int.Parse(Console.ReadLine());
                Console.WriteLine(repositorioFilmes.RetornaPorId(entradaId));
            }
            catch (Exception)
            {

                Console.WriteLine("Id não encontrado");
            }

        }
    }
}
