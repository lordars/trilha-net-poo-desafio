namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine( $"Instalando o app {nomeApp} no cell Iphone");
        }

        public void CambioDeNumero(string novonumero){
           base.Numero = novonumero;
                  Console.WriteLine($"Seu novo numero é: {base.Numero} em Iphone");
        }


    }
}