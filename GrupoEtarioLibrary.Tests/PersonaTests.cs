using GrupoEtarioLibrary;

[TestClass]
public class PersonaTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void EdadNegativa()
    {
        var persona = new Persona("Cheng", -11);
    }
    [TestMethod]
    public void Edadimposible()
    {
        var persona = new Persona ("Miguel", 0);
        Assert.AreEqual ("Inactiva", persona.DeterminarGrupoEtario ());
    }
    [TestMethod]
    public void EdadActova()
    {
        var persona = new Persona("luis", 15);
        Assert.AreEqual("Activa", persona.DeterminarGrupoEtario());
    }
    [TestMethod]
    public void EdadInactiva()
    {
        var persona = new Persona("Josu", 70);
        Assert.AreEqual("Inactiva", persona.DeterminarGrupoEtario());
    }
    [TestMethod]
    public void EdadDecimal()
    {
        var persona = new Persona("carlos", 40.5);
        Assert.AreEqual("Activa", persona.DeterminarGrupoEtario());
    }
}