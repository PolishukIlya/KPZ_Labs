using System;

namespace VirusFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            var grandParentVirus = new Virus(1.5, 10, "GrandParentVirus", "SpeciesA");
            var parentVirus1 = new Virus(0.8, 5, "ParentVirus1", "SpeciesA");
            var parentVirus2 = new Virus(0.9, 6, "ParentVirus2", "SpeciesA");
            var childVirus1 = new Virus(0.5, 2, "ChildVirus1", "SpeciesA");
            var childVirus2 = new Virus(0.6, 3, "ChildVirus2", "SpeciesA");

            grandParentVirus.AddChild(parentVirus1);
            grandParentVirus.AddChild(parentVirus2);
            parentVirus1.AddChild(childVirus1);
            parentVirus2.AddChild(childVirus2);

            Console.WriteLine("Original Virus Family:");
            grandParentVirus.Display();

            var clonedVirus = (Virus)grandParentVirus.Clone();

            Console.WriteLine("\nCloned Virus Family:");
            clonedVirus.Display();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}