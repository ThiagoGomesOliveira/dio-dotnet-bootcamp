using Dio.Series.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaRepositorio = new List<Serie>();
        public void Atualizar(int id, Serie entidade)
        {
            ListaRepositorio[id] = entidade;
        }
        public void Excluir(int id)
        {
            ListaRepositorio[id].Excluir();
        }
        public void Inserir(Serie entidade)
        {
            ListaRepositorio.Add(entidade);
        }

        public List<Serie> Listar()
        {
            return ListaRepositorio;
        }
        public int ProximoId()
        {
            return ListaRepositorio.Count;
        }

        public Serie RetornarPorId(int id)
        {
            return ListaRepositorio[id];
        }

    }
}
