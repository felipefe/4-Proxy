namespace Name
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var proxy = new AcessoInternetProxy();
            proxy.Conexao("google.com");
            
        }
    }
}