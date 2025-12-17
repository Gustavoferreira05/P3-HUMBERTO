using Prova2Bim.Dominio.Entidades;
using System.Collections.Generic;

namespace Prova2Bim.Application.Interfaces
{
    public interface IJogoService
    {
        void RegistrarJogo(Jogo jogo);
        IEnumerable<Jogo> ListarTodosJogos();
    }
}
