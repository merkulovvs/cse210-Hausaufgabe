using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("2 Nephi", 1, 15);
        Scripture scripture = new Scripture(reference,"But behold, the Lord hath aredeemed my soul from hell; I have beheld his bglory, and I am encircled about eternally in the carms of his dlove." );
        

        Console.WriteLine($"{scripture.GetDisplayText()}");

        
    }
}