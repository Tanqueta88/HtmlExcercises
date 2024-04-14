// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var cuenta1=new Cuenta(11111, "Franco Buenaventura");
Console.WriteLine(cuenta1.Titular);
cuenta1.Saldo=10000;
System.Console.WriteLine(cuenta1.Saldo);


public class Cuenta{
    //CONSTRUCTOR 1 = CONSTRUCTOR POR DEFAULT
    public Cuenta(){

    }
    //CONSTRUCTOR 2 = CONSTRUCTOR CON PARAMETROS
    public Cuenta(int nrocta, string nomtit){
        Nro=nrocta;
        Titular=nomtit;
    }

    public string Titular { get; set; }
    public int Nro { get; set; }
    public double Saldo { get; set; }
    public void Depositar() { 

     }

     public void Extraer(){

     }

}