using Prova2Bim.Dominio.Entidades;
using System.Collections.Generic;

namespace Prova2Bim.Dominio.Interfaces
{
    public interface IJogoRepository
    {
        void RegistrarJogo(Jogo jogo);
        IEnumerable<Jogo> ListarTodosJogos();
    }
}
