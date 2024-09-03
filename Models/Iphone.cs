namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        // IMPLEMENTADO: Sobrescrever o método "InstalarAplicativo"

        public Iphone (string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI,memoria){}
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando {nomeApp} pela App Store");
        }
    }
}