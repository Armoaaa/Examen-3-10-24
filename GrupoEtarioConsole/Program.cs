using GrupoEtarioLibrary;

class Program
{
    static void Main (string[] args)
    {
        try
        {
            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad:");
            if (double.TryParse(Console.ReadLine(), out double edad) && edad >=0)
            {
                Persona persona = new Persona (nombre, edad);
                Console.WriteLine($"{nombre} esta en el grupo:{persona.DeterminarGrupoEtario()}");
            }
            else{
                Console.WriteLine("Valor incorrecto");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine (ex.Message);
        }
    }
}