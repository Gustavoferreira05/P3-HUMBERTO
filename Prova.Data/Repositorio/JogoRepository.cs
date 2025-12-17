using Prova2Bim.Data.Context;
using Prova2Bim.Dominio.Entidades;
using Prova2Bim.Dominio.Interfaces;
using System;

namespace Prova2Bim.Data.Repositorio
{
    public class JogoRepository : IJogoRepository
    {
        private readonly AppDbContext _context;

        public JogoRepository(AppDbContext context)
        {
            _context = context;
        }

        public void RegistrarJogo(Jogo jogo)
        {
            _context.Jogos.Add(jogo);
            _context.SaveChanges();
        }

        public IEnumerable<Jogo> ListarTodosJogos()
        {
            return _context.Jogos.ToList();
        }
    }
}
