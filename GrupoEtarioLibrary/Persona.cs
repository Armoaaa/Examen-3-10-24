namespace GrupoEtarioLibrary;

public class Persona
{
    public string Nombre { get; set; }
    public double Edad { get; set; }
    public Persona (string nombre, double edad)
    {
        if (edad < 0)
            throw new ArgumentException("La edad no puede ser negativa"); 

        Nombre =  nombre;
        Edad = edad;
    }
    public string DeterminarGrupoEtario ()
    {
        if (Edad >= 0 && Edad <= 14)
            return "Inactiva";
        if (Edad >= 15 && Edad <= 64)
            return "Activa";
        if (Edad > 65)
            return "Inactiva";
        
        return "Incorrecto";
    }
}
