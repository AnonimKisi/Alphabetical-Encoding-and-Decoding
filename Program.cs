//Made by AnonimKisi
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Made by AnonimKisi";
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Encoding: 1");
            Console.WriteLine("Decoding: 2");
            Console.Write("\nInput: ");           
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------------------------");
            switch (input)
            {
                case 1:
                    Console.Write("Write the message that you wish you encode (leave a space between each letter): ");
                    string phrase = Console.ReadLine();
                    Console.WriteLine();
                    string[] words = phrase.Split(' ');
                    Console.Write("Encrpyted version: ");
                    
                        foreach (var words_1 in words)
                        {
                            if (words_1 == "a" || words_1 == "A")
                            {
                                Console.Write(" 1");
                            }
                            if (words_1 == "b" || words_1 == "B")
                            {
                                Console.Write(" 2");
                            }
                            if (words_1 == "c" || words_1 == "C")
                            {
                                Console.Write(" 3");
                            }
                            if (words_1 == "d" || words_1 == "D")
                            {
                                Console.Write(" 4");
                            }
                            if (words_1 == "e" || words_1 == "E")
                            {
                                Console.Write(" 5");
                            }
                            if (words_1 == "f" || words_1 == "F")
                            {
                                Console.Write(" 6");
                            }
                            if (words_1 == "g" || words_1 == "G")
                            {
                                Console.Write(" 7");
                            }
                            if (words_1 == "h" || words_1 == "H")
                            {
                                Console.Write(" 8");
                            }
                            if (words_1 == "i" || words_1 == "I")
                            {
                                Console.Write(" 9");
                            }
                            if (words_1 == "j" || words_1 == "J")
                            {
                                Console.Write(" 10");
                            }
                            if (words_1 == "k" || words_1 == "K")
                            {
                                Console.Write(" 11");
                            }
                            if (words_1 == "l" || words_1 == "L")
                            {
                                Console.Write(" 12");
                            }
                            if (words_1 == "m" || words_1 == "M")
                            {
                                Console.Write(" 13");
                            }
                            if (words_1 == "n" || words_1 == "N")
                            {
                                Console.Write(" 14");
                            }
                            if (words_1 == "o" || words_1 == "O")
                            {
                                Console.Write(" 15");
                            }
                            if (words_1 == "p" || words_1 == "P")
                            {
                                Console.Write(" 16");
                            }
                            if (words_1 == "q" || words_1 == "Q")
                            {
                                Console.Write(" 17");
                            }
                            if (words_1 == "r" || words_1 == "R")
                            {
                                Console.Write(" 18");
                            }
                            if (words_1 == "s" || words_1 == "S")
                            {
                                Console.Write(" 19");
                            }
                            if (words_1 == "t" || words_1 == "T")
                            {
                                Console.Write(" 20");
                            }
                            if (words_1 == "u" || words_1 == "U")
                            {
                                Console.Write(" 21");
                            }
                            if (words_1 == "v" || words_1 == "V")
                            {
                                Console.Write(" 22");
                            }
                            if (words_1 == "w" || words_1 == "W")
                            {
                                Console.Write(" 23");
                            }
                            if (words_1 == "x" || words_1 == "X")
                            {
                                Console.Write(" 24");
                            }
                            if (words_1 == "y" || words_1 == "Y")
                            {
                                Console.Write(" 25");
                            }

                            if (words_1 == "z" || words_1 == "Z")
                            {
                                Console.Write(" 26");
                            }                        
                        }
                    Console.WriteLine();
                    Main();
                    break;
                case 2:
                    Console.Write("Write the encrypted message that you wish you decode (leave a space between each number): ");
                    string word = Console.ReadLine();
                    Console.WriteLine();
                    string[] bunch_of_words = word.Split(' ');
                    Console.Write("Decoded version: ");

                    foreach (var the_words in bunch_of_words)
                    {
                        if (the_words == "1")
                        {
                            Console.Write(" a");
                        }
                        if (the_words == "2")
                        {
                            Console.Write(" b");
                        }
                        if (the_words == "3")
                        {
                            Console.Write(" c");
                        }
                        if (the_words == "4")
                        {
                            Console.Write(" d");
                        }
                        if (the_words == "5")
                        {
                            Console.Write(" e");
                        }
                        if (the_words == "6")
                        {
                            Console.Write(" f");
                        }
                        if (the_words == "7")
                        {
                            Console.Write(" g");
                        }
                        if (the_words == "8")
                        {
                            Console.Write(" h");
                        }
                        if (the_words == "9")
                        {
                            Console.Write(" i");
                        }
                        if (the_words == "10")
                        {
                            Console.Write(" j");
                        }
                        if (the_words == "11")
                        {
                            Console.Write(" k");
                        }
                        if (the_words == "12")
                        {
                            Console.Write(" l");
                        }
                        if (the_words == "13")
                        {
                            Console.Write(" m");
                        }
                        if (the_words == "14")
                        {
                            Console.Write(" n");
                        }
                        if (the_words == "15")
                        {
                            Console.Write(" o");
                        }
                        if (the_words == "16")
                        {
                            Console.Write(" p");
                        }
                        if (the_words == "17")
                        {
                            Console.Write(" q");
                        }
                        if (the_words == "18")
                        {
                            Console.Write(" r");
                        }
                        if (the_words == "19")
                        {
                            Console.Write(" s");
                        }
                        if (the_words == "20")
                        {
                            Console.Write(" t");
                        }
                        if (the_words == "21")
                        {
                            Console.Write(" u");
                        }
                        if (the_words == "22")
                        {
                            Console.Write(" v");
                        }
                        if (the_words == "23")
                        {
                            Console.Write(" w");
                        }
                        if (the_words == "24")
                        {
                            Console.Write(" x");
                        }
                        if (the_words == "25")
                        {
                            Console.Write(" y");
                        }
                        if (the_words == "26")
                        {
                            Console.Write(" z");
                        }
                    }
                    Console.WriteLine();
                    Main();
                    break;
            }
            Console.ReadKey(true);
        }            
    }
}