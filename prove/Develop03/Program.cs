using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("2 Nephi", 1, 15);
        Scripture scripture = new Scripture(reference,"But behold, the Lord hath redeemed my soul from hell; I have beheld his glory, and I am encircled about eternally in the arms of his love." );
        

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("");

        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string input = Console.ReadLine();



        //scripture.GetDisplayVerse();        
    }
}