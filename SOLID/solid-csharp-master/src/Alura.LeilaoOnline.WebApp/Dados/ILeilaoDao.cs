﻿using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        public IEnumerable<Categoria> BuscarCategirias();

        public IEnumerable<Leilao> BuscarLeiloes();

        public Leilao BuscarPorId(int id);

        public void Incluir(Leilao leilao);

        public void Alterar(Leilao leilao);

        public void Excluir(Leilao leilao);
    }
}
