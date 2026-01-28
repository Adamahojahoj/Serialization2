using Serialization2.Helpers;
using Serialization2.Models;
using System.ComponentModel;
using Worker = Serialization2.Serializer; // worker je alias na baliček Serialization2.Serializer
internal class Program
{
    private static void Main(string[] args)
    {
        Worker.Serializer<Obed> serializer = new();
        string nazev = InputHelper.InputText("Set name of lunch");
        int id = InputHelper.InputNumber("Insert ID number");
        Obed o = new Obed { Id = id, Nazev = nazev };
        string decision1 = InputHelper.InputText("Would you like to serialize?[y/n]");
        if (decision1.Trim().ToLower().Equals("y"))
        {

        }
    }
}