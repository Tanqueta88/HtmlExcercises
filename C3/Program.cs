static void Main(string[]args)
{} 

int valor;

try
{
    Console.WriteLine("Ingrese un numero");
    valor = int.Parse(Console.ReadLine());

    Console.WriteLine(valor);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Error de tipo");
}
finally
{

}
#endregion