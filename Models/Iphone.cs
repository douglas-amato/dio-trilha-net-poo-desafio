namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o {nomeApp} no Iphone...");
        }    

        // Sobrescreve o método "ExibirDadosDoAparelho"
        public override void ExibirDadosDoAparelho()
        {
           Console.WriteLine($"Iphone -> Modelo: {Modelo} | IMEI: {Imei} | Memória: {Memoria}");
        }    
    }
}