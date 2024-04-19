namespace Ex04ProblemaRestaurante
{
    public class Mesa
    {
        public int Numero { get; set; }
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();

    }
}
