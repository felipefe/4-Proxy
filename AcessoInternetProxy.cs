namespace Name
{
    //Proxy
    public class AcessoInternetProxy : IConexaoInternet
    {
        private IConexaoInternet conn = new ConexaoInternet();
        private static List<string> sites = new List<string>{"youtube.com", "google.com", "escola.gov.com.br"};

        public AcessoInternetProxy()
        {
        }
        

        public void Conexao(string host)
        {
            System.Console.WriteLine("Conectando...");
            System.Console.WriteLine("Aguarde mais um momento...");
            if(sites.Any(x => x.Equals(host)))
            {
                conn.Conexao(host);
            }
            else
            {
                System.Console.WriteLine($"Site {host} não permitido!");
            }
        }
    }
}