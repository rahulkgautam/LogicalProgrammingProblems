using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LogicalPrograms
{
    class VendingMachine
    {
        // List of available notes
        private static int[] availableNotes = { 1000, 500, 100, 50, 10, 5, 2, 1 };

        public static int[] GetChange(int amount)
        {
            List<int> notes = new List<int>();

            // Helper function to find minimum notes recursively
            GetMinimumNotes(amount, notes);

            // Convert the list of notes to an array
            int[] result = notes.ToArray();
            return result;
        }

        private static void GetMinimumNotes(int amount, List<int> notes)
        {
            if (amount == 0)
                return;

            foreach (int note in availableNotes)
            {
                if (amount >= note)
                {
                    int count = amount / note;
                    for (int i = 0; i < count; i++)
                    {
                        notes.Add(note);
                    }

                    int remainingAmount = amount % note;
                    GetMinimumNotes(remainingAmount, notes);
                    break;
                }
            }
        }
    }

}
