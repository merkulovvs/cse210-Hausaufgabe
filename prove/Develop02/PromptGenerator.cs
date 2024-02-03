using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();


    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomPromptNumber = randomGenerator.Next(0,3);

        return _prompts[randomPromptNumber];
    }

}