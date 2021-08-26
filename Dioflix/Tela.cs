using DioFlix.Classes;
using System;
using DioFlix.Enumeravel;
using System.Collections.Generic;
using System.Text;

namespace DioFlix
{
    public class Tela
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DioFlix ao seu dispor!");
            Console.WriteLine("Infomer a opção desejada:");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova séries");
            Console.WriteLine("3- Atualizar séries");
            Console.WriteLine("4- Excluir séries");
            Console.WriteLine("5- Visualizar séries");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        public static void ListaSeries()
        {
            Console.WriteLine("Listar séries");
            var lista = repositorio.Lista();
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

            Console.Write("Digite a descrição da séries: ");
            string entradaDescricao = Console.ReadLine();

            Serie serieCriada = new Serie(id: repositorio.ProximoId(),
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                descricao: entradaDescricao,
                ano: entradaAno);
            return serieCriada;

        }
        public static void InserirSerie()
        {
            try
            {
                Console.WriteLine("Inserir nova série");
                Serie novaSerie = CriaSerie();
                repositorio.insere(novaSerie);
            }
            catch (Exception e)
            {

                Console.WriteLine("Erro ao criar a séries: " + e.Message);
            }


        }
        public static void AtualizarSerie()
        {
            try
            {
                Console.Write("Digite o Id da série que deseja atualizar: ");
                int entradaId = int.Parse(Console.ReadLine());
                Serie serieAtualizada = CriaSerie();


                repositorio.atualiza(entradaId, serieAtualizada);
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
                repositorio.exclui(entradaId);
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
                Console.WriteLine(repositorio.RetornaPorId(entradaId));
            }
            catch (Exception)
            {

                Console.WriteLine("Id não encontrado");
            }

        }
    }
}
