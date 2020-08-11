using System;

namespace core_console {
    class Program {
        static void Main(string[] args) {
            int quantityToAdd = 24;
            int maxPerSlot = 5;
            int numberOfNewSlotsUsed = quantityToAdd / maxPerSlot;
            int numberInIncompleteSlot = quantityToAdd % maxPerSlot;

            Console.WriteLine(numberOfNewSlotsUsed);
            Console.WriteLine(numberInIncompleteSlot);

            foreach (var arg in args) {
              Console.WriteLine(arg);
            }
        }
    }
}
