using System;

namespace Apaxiaaaaaaaaaaaans
{
    class Program
    {
        private bool ProperlyFormattedName(string name)
        {
            const int MINIMUM_VALID_LENGTH = 1;
            const int MAXIMUM_VALID_LENGTH = 250;
            bool valid = true;
            
            if(name.Length >= MINIMUM_VALID_LENGTH && name.Length <= MAXIMUM_VALID_LENGTH)
            {
                foreach(char ch in name)
                {
                    if(!char.IsDigit(ch))
                    {
                        valid = false;
                    }
                }    
            }
            else
            {
                valid = false;
            }
            return valid;
        }

        static void Main(string[] args)
        {
            string nameDuplicates;
            nameDuplicates = Console.ReadLine();
            string nameNoDuplicates = "";
            char letter = ' ';

            foreach(char a in nameDuplicates)
            {
                if(a == letter)
                {
                    continue;
                }
                else
                {
                    letter = a;
                    nameNoDuplicates += a;
                }
            }

            Console.WriteLine(nameNoDuplicates.ToLower());
        }
    }
}
