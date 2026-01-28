using Serialization2.Helpers;
using Serialization2.Models;
using System.ComponentModel;
using Worker = Serialization2.Serializer; // worker je alias na baliček Serialization2.Serializer
internal class Program
{
    private static void Main(string[] args)
    {
        Worker.Serializer<Obed> serializer = new();
        List<Obed> Obedy = new();
        bool ContinueAdding = true;
        while (ContinueAdding)
        {
            string nazev = InputHelper.InputText("Set name of lunch");
            int id = InputHelper.InputNumber("Insert ID number");
            Obed o = new Obed { Id = id, Nazev = nazev };
            Obedy.Add(o);
            ContinueAdding = InputHelper.InputText("Would you like to add next one?[y/n]") == "y";
        }
        string decision1 = InputHelper.InputText("Would you like to serialize?[y/n]");
        if (decision1.Trim().ToLower().Equals("y"))
        {
            if (serializer.Serialize(Obedy))
            {
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine("Cannot serialize");
            }
        }
        else
        {
            Console.WriteLine("Ended without serialize");
        }
    }
}