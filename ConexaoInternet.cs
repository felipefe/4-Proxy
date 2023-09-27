namespace Name
{
    //Real subject
    public class ConexaoInternet : IConexaoInternet
    {
        public string site { get; set;}
        public void Conexao(string host)
        {
            System.Console.WriteLine("Conexão com a internet estabelecida com sucesso!");
            System.Console.WriteLine(host);
        }
    }
}