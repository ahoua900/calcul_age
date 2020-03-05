using System;

namespace formation
{
    public class File:Costumer
    {
        public string FirstName;
        public int DateOfBirthday;
        public int MonthOfBirthday;
        public int YearOfBirthday;

        public void Birthday()
        {
            Console.WriteLine("Votre nom est "+" "+FirstName+" "+" et votre date de naissance est le "+" "+DateOfBirthday+"/"+MonthOfBirthday+"/"+YearOfBirthday);
        }
        
    }

    
    
}
