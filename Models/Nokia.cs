namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        
        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o {nomeApp} no Nokia...");
        }

        // Sobrescreve o método "ExibirDadosDoAparelho"
        public override void ExibirDadosDoAparelho()
        {
           Console.WriteLine($"Nokia -> Modelo: {Modelo} | IMEI: {Imei} | Memória: {Memoria}");
        }
    }
}