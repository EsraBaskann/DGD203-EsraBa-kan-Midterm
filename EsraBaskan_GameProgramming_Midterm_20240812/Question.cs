//Created collaboratively using Windsurf and ChatGPT
using System;

namespace AdventureGame
{
    public class Question
    {
        public string Text { get; }
        public string[] Options { get; }

        public Question(string text, string[] options)
        {
            if (options.Length != 4)
            {
                throw new ArgumentException("Each question must have exactly 4 options.");
            }
            Text = text;
            Options = options;
        }

        public string Ask(string playerName)
        {
            while (true)
            {
                Console.WriteLine($"\n{playerName}, {Text}");
                foreach (string option in Options)
                {
                    Console.WriteLine(option);
                }
                Console.Write("\nYour choice (A/B/C/D): ");
                string? answer = Console.ReadLine()?.Trim().ToUpper() ?? "";
                
                if (answer == "A" || answer == "B" || answer == "C" || answer == "D")
                    return answer;
                
                Console.WriteLine("Invalid choice! Please select A, B, C, or D.");
            }
        }
    }
}
