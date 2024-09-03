namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
        // IMPLEMENTADO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI,memoria){

        }
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando {nomeApp} pela Play Store");
        }
    }
}