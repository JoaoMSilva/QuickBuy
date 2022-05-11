using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Utilizador
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public ICollection<ItemPedido> Pedidos { get; set; }
    }
}
