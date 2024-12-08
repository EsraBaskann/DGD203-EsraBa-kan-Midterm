//Created collaboratively using Windsurf and ChatGPT
using System;
using System.Collections.Generic;
using System.Threading;

namespace AdventureGame
{
    public class Game
    {
        private readonly string playerName;
        private readonly List<string> playerChoices;
        private bool hasInsight = false;
        private bool hasAncientKnowledge = false;
        private bool hasGuardianBlessing = false;
        private string journeySummary = "";

        public Game(string playerName)
        {
            this.playerName = playerName;
            this.playerChoices = new List<string>();
        }

        private void WriteSlowly(string text, int delay = 10)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }

        public void Start()
        {
            WriteSlowly("\nLegends tell of the Relic of Eternity, hidden deep within the Forbidden Forest.\n", 20);
            WriteSlowly("It is said to grant the heart's deepest desire but at a cost unknown to man.\n", 20);
            WriteSlowly("As the first rays of dawn pierce the misty woods, you tighten your pack and take the first step into the unknown...\n\n", 20);
            Thread.Sleep(1000);

            // Question 1: The First Fork
            var q1 = new Question(
                "You come to a fork in the forest path. Faint whispers echo in the air, and the trees seem to lean closer. What do you do?",
                new[] {
                    "A) Take the overgrown path",
                    "B) Follow the marked path",
                    "C) Climb a tree to scout",
                    "D) Return to the village"
                }
            );
            string choice1 = q1.Ask(playerName);
            playerChoices.Add(choice1);
            ProcessFirstChoice(choice1);

            // Question 2: The River Crossing
            var q2 = new Question(
                "A wide river rushes before you, its waters dark and cold. How will you cross?",
                new[] {
                    "A) Use a fallen tree as a bridge",
                    "B) Search for a shallow wading spot",
                    "C) Build a raft",
                    "D) Seek help from a mysterious traveler"
                }
            );
            string choice2 = q2.Ask(playerName);
            playerChoices.Add(choice2);
            ProcessSecondChoice(choice2);

            // Question 3: The Whispering Cave
            var q3 = new Question(
                "You find a cave with glowing moss and whispering voices. What do you do?",
                new[] {
                    "A) Enter cautiously with a torch",
                    "B) Ignore it and move on",
                    "C) Leave a trail to find your way back later",
                    "D) Block the entrance to seal whatever's inside"
                }
            );
            string choice3 = q3.Ask(playerName);
            playerChoices.Add(choice3);
            ProcessThirdChoice(choice3);

            // Question 4: The Guardian's Challenge
            var q4 = new Question(
                "An ancient stone guardian confronts you. It asks: \"What is your greatest strength?\"",
                new[] {
                    "A) \"My courage.\"",
                    "B) \"My intelligence.\"",
                    "C) \"My adaptability.\"",
                    "D) \"My perseverance.\""
                }
            );
            string choice4 = q4.Ask(playerName);
            playerChoices.Add(choice4);
            ProcessFourthChoice(choice4);

            // Final Question: The Relic's Decision
            WriteSlowly("\nThe relic speaks, its voice echoing with ancient power:\n", 20);
            WriteSlowly("\"What will you wish for? Prove you are worthy by choosing wisely.\"\n\n", 20);

            var q5 = new Question(
                "Your heart races as you make your final choice. What do you wish for?",
                new[] {
                    "A) To help others and bring prosperity to the land",
                    "B) To gain ultimate power and knowledge",
                    "C) To discover the truth about everything",
                    "D) To become the eternal protector of the forest"
                }
            );
            string finalChoice = q5.Ask(playerName);
            playerChoices.Add(finalChoice);
            GenerateEnding(finalChoice);
        }

        private void ProcessFirstChoice(string choice)
        {
            Console.Clear();
            switch (choice)
            {
                case "A":
                    WriteSlowly("\nThe ancient hermit shares cryptic wisdom. You gain insight into the path ahead...\n", 10);
                    hasInsight = true;
                    journeySummary += "You chose wisdom from the hermit, ";
                    break;
                case "B":
                    WriteSlowly("\nThe symbols lead you to hidden knowledge, though some mysteries remain...\n", 10);
                    hasAncientKnowledge = true;
                    journeySummary += "You followed the ancient markings, ";
                    break;
                case "C":
                    WriteSlowly("\nFrom above, you gain a broader perspective of your journey...\n", 10);
                    journeySummary += "You sought the higher ground, ";
                    break;
                case "D":
                    WriteSlowly("\nThe village's wisdom proves valuable, though time was lost...\n", 10);
                    journeySummary += "You valued preparation over haste, ";
                    break;
            }
            Thread.Sleep(1000);
        }

        private void ProcessSecondChoice(string choice)
        {
            Console.Clear();
            switch (choice)
            {
                case "A":
                    WriteSlowly("\nYour bravery in crossing the treacherous bridge shows your determination...\n", 10);
                    journeySummary += "faced danger with courage, ";
                    break;
                case "B":
                    WriteSlowly("\nPatience reveals hidden treasures in the shallow waters...\n", 10);
                    hasAncientKnowledge = true;
                    journeySummary += "chose the careful path, ";
                    break;
                case "C":
                    WriteSlowly("\nYour resourcefulness in building the raft demonstrates wisdom...\n", 10);
                    hasInsight = true;
                    journeySummary += "showed resourcefulness, ";
                    break;
                case "D":
                    WriteSlowly("\nThe mysterious traveler's aid comes with hidden knowledge...\n", 10);
                    hasAncientKnowledge = true;
                    journeySummary += "trusted in others, ";
                    break;
            }
            Thread.Sleep(1000);
        }

        private void ProcessThirdChoice(string choice)
        {
            Console.Clear();
            switch (choice)
            {
                case "A":
                    WriteSlowly("\nThe cave's ancient carvings reveal crucial secrets about the relic...\n", 10);
                    hasAncientKnowledge = true;
                    journeySummary += "braved the unknown, ";
                    break;
                case "B":
                    WriteSlowly("\nThough you avoid danger, the whispers of knowledge fade away...\n", 10);
                    journeySummary += "chose caution, ";
                    break;
                case "C":
                    WriteSlowly("\nYour methodical approach ensures no opportunity is lost...\n", 10);
                    hasInsight = true;
                    journeySummary += "planned ahead, ";
                    break;
                case "D":
                    WriteSlowly("\nThe sealed cave's energy lingers, affecting your journey...\n", 10);
                    journeySummary += "took decisive action, ";
                    break;
            }
            Thread.Sleep(1000);
        }

        private void ProcessFourthChoice(string choice)
        {
            Console.Clear();
            switch (choice)
            {
                case "A":
                    WriteSlowly("\nThe guardian acknowledges your courage with a blessing...\n", 10);
                    hasGuardianBlessing = true;
                    journeySummary += "and proved your courage. ";
                    break;
                case "B":
                    WriteSlowly("\nYour wisdom impresses the guardian, earning its respect...\n", 10);
                    hasGuardianBlessing = true;
                    journeySummary += "and demonstrated wisdom. ";
                    break;
                case "C":
                    WriteSlowly("\nThe guardian admires your adaptability and grants passage...\n", 10);
                    hasGuardianBlessing = true;
                    journeySummary += "and showed adaptability. ";
                    break;
                case "D":
                    WriteSlowly("\nYour determination moves the guardian to aid your quest...\n", 10);
                    hasGuardianBlessing = true;
                    journeySummary += "and persevered to the end. ";
                    break;
            }
            Thread.Sleep(1000);
        }

        private void GenerateEnding(string choice)
        {
            Console.Clear();
            WriteSlowly("\n═══════════════════════════════════════════\n", 5);
            WriteSlowly($"The Relic of Eternity has judged your heart, {playerName}...\n\n", 20);

            switch (choice)
            {
                case "A":
                    WriteSlowly("The relic glows with a warm, golden light.\n", 15);
                    WriteSlowly("\"Your selflessness shall shape the world.\"\n\n", 15);
                    WriteSlowly("A radiant energy surrounds you, and in an instant, the blight over the Forbidden Forest vanishes.\n", 10);
                    WriteSlowly("Plants flourish, animals return, and the once-treacherous land becomes a sanctuary.\n\n", 10);
                    if (hasGuardianBlessing)
                        WriteSlowly("The guardian's blessing amplifies your benevolent wish, spreading prosperity far beyond the forest.\n", 10);
                    break;

                case "B":
                    WriteSlowly("The relic burns with a searing crimson light.\n", 15);
                    WriteSlowly("\"Power you seek, and power you shall wield.\"\n\n", 15);
                    WriteSlowly("A dark energy courses through you, granting unmatched strength and intellect.\n", 10);
                    if (hasAncientKnowledge)
                        WriteSlowly("Your accumulated knowledge combines with the relic's power, making you truly formidable.\n", 10);
                    WriteSlowly("You rise to prominence, feared and respected in equal measure.\n", 10);
                    break;

                case "C":
                    WriteSlowly("The relic pulses with a cool, silvery glow.\n", 15);
                    WriteSlowly("\"The truth shall set you free—or chain you forever.\"\n\n", 15);
                    WriteSlowly("Your vision blurs, and when it clears, you see the world's hidden truths.\n", 10);
                    if (hasInsight)
                        WriteSlowly("Your previous insights help you better understand the overwhelming knowledge granted by the relic.\n", 10);
                    WriteSlowly("Though you are wiser, you are left to question whether ignorance was bliss.\n", 10);
                    break;

                case "D":
                    WriteSlowly("The relic hums with a deep, green resonance.\n", 15);
                    WriteSlowly("\"You wish to protect what is sacred. So be it.\"\n\n", 15);
                    WriteSlowly("Vines and roots emerge from the ground, wrapping around you gently.\n", 10);
                    WriteSlowly("You become one with the forest, your body transforming into a guardian spirit.\n", 10);
                    if (hasGuardianBlessing && hasAncientKnowledge)
                        WriteSlowly("The guardian's blessing and your knowledge of the ancient ways make you an exceptionally powerful protector.\n", 10);
                    break;
            }

            WriteSlowly("\nYour Journey's Path:\n", 15);
            WriteSlowly(journeySummary + "\n", 10);
            
            WriteSlowly("\nPress any key to end your tale...", 10);
            Console.ReadKey(true);
        }
    }
}
