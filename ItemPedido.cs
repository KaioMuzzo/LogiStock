namespace LogiStock
{
    class ItemPedido
    {
        public int idProduto { get; set; }
        public int idUnidade { get; set; }
        public int Quantidade { get; set; }
        public string NomeProduto { get; set; }
        public string siglaUnidade { get; set; }

        public override string ToString()
        {
            return $"{NomeProduto} - {Quantidade} {siglaUnidade}";
        }
    }
}
