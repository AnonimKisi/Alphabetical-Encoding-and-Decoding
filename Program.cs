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
            Console.WriteLine("Encryption: 1");
            Console.WriteLine("Decryption: 2");
            Console.Write("\nInput: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------------------------");
            switch (input)
            {
                case 1:
                    Console.Write("Write the message that you wish you encrypt (leave a space between each letter): ");

                    string phrase = Console.ReadLine();

                    string[] words = phrase.Split(' ');

                    Console.Write("\nEncrpyted version: ");

                    foreach (var words_1 in words)
                    {
                        string storing_encrypted_data = "1";
                        //------------------------------------
                        if (words_1 == "a" || words_1 == "A")
                        {
                            storing_encrypted_data = "2";
                        }
                        if (words_1 == "b" || words_1 == "B")
                        {
                            storing_encrypted_data = "3";
                        }
                        if (words_1 == "c" || words_1 == "C")
                        {
                            storing_encrypted_data = "4";
                        }
                        if (words_1 == "d" || words_1 == "D")
                        {
                            storing_encrypted_data = "5";
                        }
                        if (words_1 == "e" || words_1 == "E")
                        {
                            storing_encrypted_data = "6";
                        }
                        if (words_1 == "f" || words_1 == "F")
                        {
                            storing_encrypted_data = "7";
                        }
                        if (words_1 == "g" || words_1 == "G")
                        {
                            storing_encrypted_data = "8";
                        }
                        if (words_1 == "h" || words_1 == "H")
                        {
                            storing_encrypted_data = "9";
                        }
                        if (words_1 == "i" || words_1 == "I")
                        {
                            storing_encrypted_data = "10";
                        }
                        if (words_1 == "j" || words_1 == "J")
                        {
                            storing_encrypted_data = "11";
                        }
                        if (words_1 == "k" || words_1 == "K")
                        {
                            storing_encrypted_data = "12";
                        }
                        if (words_1 == "l" || words_1 == "L")
                        {
                            storing_encrypted_data = "13";
                        }
                        if (words_1 == "m" || words_1 == "M")
                        {
                            storing_encrypted_data = "14";
                        }
                        if (words_1 == "n" || words_1 == "N")
                        {
                            storing_encrypted_data = "15";
                        }
                        if (words_1 == "o" || words_1 == "O")
                        {
                            storing_encrypted_data = "16";
                        }
                        if (words_1 == "p" || words_1 == "P")
                        {
                            storing_encrypted_data = "17";
                        }
                        if (words_1 == "q" || words_1 == "Q")
                        {
                            storing_encrypted_data = "18";
                        }
                        if (words_1 == "r" || words_1 == "R")
                        {
                            storing_encrypted_data = "19";
                        }
                        if (words_1 == "s" || words_1 == "S")
                        {
                            storing_encrypted_data = "20";
                        }
                        if (words_1 == "t" || words_1 == "T")
                        {
                            storing_encrypted_data = "21";
                        }
                        if (words_1 == "u" || words_1 == "U")
                        {
                            storing_encrypted_data = "22";
                        }
                        if (words_1 == "v" || words_1 == "V")
                        {
                            storing_encrypted_data = "23";
                        }
                        if (words_1 == "w" || words_1 == "W")
                        {
                            storing_encrypted_data = "24";
                        }
                        if (words_1 == "x" || words_1 == "X")
                        {
                            storing_encrypted_data = "25";
                        }
                        if (words_1 == "y" || words_1 == "Y")
                        {
                            storing_encrypted_data = "26";
                        }
                        if (words_1 == "z" || words_1 == "Z")
                        {
                            storing_encrypted_data = "1";
                        }
                        //--------------------------------
                        string new_words;

                        if (storing_encrypted_data == "1")
                        {
                            new_words = " D";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "2")
                        {
                            new_words = " E";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "3")
                        {
                            new_words = " F";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "4")
                        {
                            new_words = " G";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "5")
                        {
                            new_words = " H";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "6")
                        {
                            new_words = " I";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "7")
                        {
                            new_words = " J";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "8")
                        {
                            new_words = " K";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "9")
                        {
                            new_words = " L";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "10")
                        {
                            new_words = " M";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "11")
                        {
                            new_words = " N";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "12")
                        {
                            new_words = " O";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "13")
                        {
                            new_words = " P";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "14")
                        {
                            new_words = " Q";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "15")
                        {
                            new_words = " R";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "16")
                        {
                            new_words = " S";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "17")
                        {
                            new_words = " T";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "18")
                        {
                            new_words = " U";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "19")
                        {
                            new_words = " V";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "20")
                        {
                            new_words = " W";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "21")
                        {
                            new_words = " X";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "22")
                        {
                            new_words = " Y";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "23")
                        {
                            new_words = " Z";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "24")
                        {
                            new_words = " A";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "25")
                        {
                            new_words = " B";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "26")
                        {
                            new_words = " C";
                            Console.Write(new_words);
                        }
                    }
                    Console.WriteLine();
                    Main();
                    break;
                //---------------------------------------------------------------------------------------------------------
                case 2:
                    Console.Write("Write the encrypted message that you wish you decrypt (leave a space between each letter): ");

                    string word = Console.ReadLine();

                    string[] bunch_of_words = word.Split(' ');

                    Console.Write("\nDecrypted version: ");

                    foreach (var the_words in bunch_of_words)
                    {
                        string new_words = " ";
                        string storing_encrypted_data = " ";
                        //----------------------------------
                        if (the_words == "A" || the_words == "a")
                        {
                            new_words = "24";
                        }
                        if (the_words == "B" || the_words == "b")
                        {
                            new_words = "25";
                        }
                        if (the_words == "C" || the_words == "c")
                        {
                            new_words = "26";
                        }
                        if (the_words == "D" || the_words == "d")
                        {
                            new_words = "1";
                        }
                        if (the_words == "E" || the_words == "e")
                        {
                            new_words = "2";
                        }
                        if (the_words == "F" || the_words == "f")
                        {
                            new_words = "3";
                        }
                        if (the_words == "G" || the_words == "g")
                        {
                            new_words = "4";
                        }
                        if (the_words == "H" || the_words == "h")
                        {
                            new_words = "5";
                        }
                        if (the_words == "I" || the_words == "i")
                        {
                            new_words = "6";
                        }
                        if (the_words == "J" || the_words == "j")
                        {
                            new_words = "7";
                        }
                        if (the_words == "K" || the_words == "k")
                        {
                            new_words = "8";
                        }
                        if (the_words == "L" || the_words == "l")
                        {
                            new_words = "9";
                        }
                        if (the_words == "M" || the_words == "m")
                        {
                            new_words = "10";
                        }
                        if (the_words == "N" || the_words == "n")
                        {
                            new_words = "11";
                        }
                        if (the_words == "O" || the_words == "o")
                        {
                            new_words = "12";
                        }
                        if (the_words == "P" || the_words == "p")
                        {
                            new_words = "13";
                        }
                        if (the_words == "Q" || the_words == "q")
                        {
                            new_words = "14";
                        }
                        if (the_words == "R" || the_words == "r")
                        {
                            new_words = "15";
                        }
                        if (the_words == "S" || the_words == "s")
                        {
                            new_words = "16";
                        }
                        if (the_words == "T" || the_words == "t")
                        {
                            new_words = "17";
                        }
                        if (the_words == "U" || the_words == "u")
                        {
                            new_words = "18";
                        }
                        if (the_words == "V" || the_words == "v")
                        {
                            new_words = "19";
                        }
                        if (the_words == "W" || the_words == "w")
                        {
                            new_words = "20";
                        }
                        if (the_words == "X" || the_words == "x")
                        {
                            new_words = "21";
                        }
                        if (the_words == "Y" || the_words == "y")
                        {
                            new_words = "22";
                        }
                        if (the_words == "Z" || the_words == "z")
                        {
                            new_words = "23";
                        }
                        //--------------------------------
                        if (new_words == "1")
                        {
                            Console.Write(" Z");
                        }
                        if (new_words == "2")
                        {
                            Console.Write(" A");
                        }
                        if (new_words == "3")
                        {
                            Console.Write(" B");
                        }
                        if (new_words == "4")
                        {
                            Console.Write(" C");
                        }
                        if (new_words == "5")
                        {
                            Console.Write(" D");
                        }
                        if (new_words == "6")
                        {
                            Console.Write(" E");
                        }
                        if (new_words == "7")
                        {
                            Console.Write(" F");
                        }
                        if (new_words == "8")
                        {
                            Console.Write(" G");
                        }
                        if (new_words == "9")
                        {
                            Console.Write(" H");
                        }
                        if (new_words == "10")
                        {
                            Console.Write(" I");
                        }
                        if (new_words == "11")
                        {
                            Console.Write(" J");
                        }
                        if (new_words == "12")
                        {
                            Console.Write(" K");
                        }
                        if (new_words == "13")
                        {
                            Console.Write(" L");
                        }
                        if (new_words == "14")
                        {
                            Console.Write(" M");
                        }
                        if (new_words == "15")
                        {
                            Console.Write(" N");
                        }
                        if (new_words == "16")
                        {
                            Console.Write(" O");
                        }
                        if (new_words == "17")
                        {
                            Console.Write(" P");
                        }
                        if (new_words == "18")
                        {
                            Console.Write(" Q");
                        }
                        if (new_words == "19")
                        {
                            Console.Write(" R");
                        }
                        if (new_words == "20")
                        {
                            Console.Write(" S");
                        }
                        if (new_words == "21")
                        {
                            Console.Write(" T");
                        }
                        if (new_words == "22")
                        {
                            Console.Write(" U");
                        }
                        if (new_words == "23")
                        {
                            Console.Write(" V");
                        }
                        if (new_words == "24")
                        {
                            Console.Write(" W");
                        }
                        if (new_words == "25")
                        {
                            Console.Write(" X");
                        }
                        if (new_words == "26")
                        {
                            Console.Write(" Y");
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