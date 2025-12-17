using Prova2Bim.Application.Interfaces;
using Prova2Bim.Dominio.Entidades;
using Prova2Bim.Dominio.Interfaces;

namespace Prova2Bim.Application.Services
{
    public class JogoService : IJogoService
    {
        private readonly IJogoRepository _repository;

        public JogoService(IJogoRepository repository)
        {
            _repository = repository;
        }

        public void RegistrarJogo(Jogo jogo)
        {
            jogo.DataJogo = DateTime.Now;
            _repository.RegistrarJogo(jogo);
        }

        public IEnumerable<Jogo> ListarTodosJogos()
        {
            return _repository.ListarTodosJogos();
        }
    }
}
