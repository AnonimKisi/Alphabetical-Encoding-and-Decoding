//Made by AnonimKisi
using System;

namespace Encryption_and_Decryption
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
                    Console.Write("Write the message that you wish you encrypt: ");
                    string text = Console.ReadLine();
                    char[] chars = text.ToCharArray(0, text.Length);
                    Console.Write("\nEncrypted version: ");

                    foreach (char letters in chars)
                    {
                        string storing_encrypted_data = "1";
                        //------------------------------------
                        if (letters == 'a' || letters == 'A')
                        {
                            storing_encrypted_data = "2";
                        }
                        if (letters == 'b' || letters == 'B')
                        {
                            storing_encrypted_data = "3";
                        }
                        if (letters == 'c' || letters == 'C')
                        {
                            storing_encrypted_data = "4";
                        }
                        if (letters == 'd' || letters == 'D')
                        {
                            storing_encrypted_data = "5";
                        }
                        if (letters == 'e' || letters == 'E')
                        {
                            storing_encrypted_data = "6";
                        }
                        if (letters == 'f' || letters == 'F')
                        {
                            storing_encrypted_data = "7";
                        }
                        if (letters == 'g' || letters == 'G')
                        {
                            storing_encrypted_data = "8";
                        }
                        if (letters == 'h' || letters == 'H')
                        {
                            storing_encrypted_data = "9";
                        }
                        if (letters == 'i' || letters == 'I')
                        {
                            storing_encrypted_data = "10";
                        }
                        if (letters == 'j' || letters == 'J')
                        {
                            storing_encrypted_data = "11";
                        }
                        if (letters == 'k' || letters == 'K')
                        {
                            storing_encrypted_data = "12";
                        }
                        if (letters == 'l' || letters == 'L')
                        {
                            storing_encrypted_data = "13";
                        }
                        if (letters == 'm' || letters == 'M')
                        {
                            storing_encrypted_data = "14";
                        }
                        if (letters == 'n' || letters == 'N')
                        {
                            storing_encrypted_data = "15";
                        }
                        if (letters == 'o' || letters == 'O')
                        {
                            storing_encrypted_data = "16";
                        }
                        if (letters == 'p' || letters == 'P')
                        {
                            storing_encrypted_data = "17";
                        }
                        if (letters == 'q' || letters == 'Q')
                        {
                            storing_encrypted_data = "18";
                        }
                        if (letters == 'r' || letters == 'R')
                        {
                            storing_encrypted_data = "19";
                        }
                        if (letters == 's' || letters == 'S')
                        {
                            storing_encrypted_data = "20";
                        }
                        if (letters == 't' || letters == 'T')
                        {
                            storing_encrypted_data = "21";
                        }
                        if (letters == 'u' || letters == 'U')
                        {
                            storing_encrypted_data = "22";
                        }
                        if (letters == 'v' || letters == 'V')
                        {
                            storing_encrypted_data = "23";
                        }
                        if (letters == 'w' || letters == 'W')
                        {
                            storing_encrypted_data = "24";
                        }
                        if (letters == 'x' || letters == 'X')
                        {
                            storing_encrypted_data = "25";
                        }
                        if (letters == 'y' || letters == 'Y')
                        {
                            storing_encrypted_data = "26";
                        }
                        if (letters == 'z' || letters == 'Z')
                        {
                            storing_encrypted_data = "1";
                        }
                        if(letters == ' ')
                        {
                            storing_encrypted_data = "0";
                        }
                        //--------------------------------
                        string new_words;

                        if (storing_encrypted_data == "1")
                        {
                            new_words = "D";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "2")
                        {
                            new_words = "E";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "3")
                        {
                            new_words = "F";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "4")
                        {
                            new_words = "G";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "5")
                        {
                            new_words = "H";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "6")
                        {
                            new_words = "I";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "7")
                        {
                            new_words = "J";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "8")
                        {
                            new_words = "K";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "9")
                        {
                            new_words = "L";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "10")
                        {
                            new_words = "M";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "11")
                        {
                            new_words = "N";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "12")
                        {
                            new_words = "O";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "13")
                        {
                            new_words = "P";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "14")
                        {
                            new_words = "Q";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "15")
                        {
                            new_words = "R";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "16")
                        {
                            new_words = "S";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "17")
                        {
                            new_words = "T";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "18")
                        {
                            new_words = "U";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "19")
                        {
                            new_words = "V";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "20")
                        {
                            new_words = "W";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "21")
                        {
                            new_words = "X";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "22")
                        {
                            new_words = "Y";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "23")
                        {
                            new_words = "Z";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "24")
                        {
                            new_words = "A";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "25")
                        {
                            new_words = "B";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "26")
                        {
                            new_words = "C";
                            Console.Write(new_words);
                        }
                        if (storing_encrypted_data == "0")
                        {
                            new_words = " ";
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                    Main();
                    break;
                //---------------------------------------------------------------------------------------------------------
                case 2:
                    Console.Write("Write the encrypted message that you wish you decrypt: ");

                    text = Console.ReadLine();
                    chars = text.ToCharArray(0, text.Length);

                    Console.Write("\nDecrypted version: ");

                    foreach (char letters in chars)
                    {
                        string storing_encrypted_data = "1";
                        //----------------------------------
                        if (letters == 'A' || letters == 'a')
                        {
                            storing_encrypted_data = "24";
                        }
                        if (letters == 'B' || letters == 'b')
                        {
                            storing_encrypted_data = "25";
                        }
                        if (letters == 'C' || letters == 'c')
                        {
                            storing_encrypted_data = "26";
                        }
                        if (letters == 'D' || letters == 'd')
                        {
                            storing_encrypted_data = "1";
                        }
                        if (letters == 'E' || letters == 'e')
                        {
                            storing_encrypted_data = "2";
                        }
                        if (letters == 'F' || letters == 'f')
                        {
                            storing_encrypted_data = "3";
                        }
                        if (letters == 'G' || letters == 'g')
                        {
                            storing_encrypted_data = "4";
                        }
                        if (letters == 'H' || letters == 'h')
                        {
                            storing_encrypted_data = "5";
                        }
                        if (letters == 'I' || letters == 'i')
                        {
                            storing_encrypted_data = "6";
                        }
                        if (letters == 'J' || letters == 'j')
                        {
                            storing_encrypted_data = "7";
                        }
                        if (letters == 'K' || letters == 'k')
                        {
                            storing_encrypted_data = "8";
                        }
                        if (letters == 'L' || letters == 'l')
                        {
                            storing_encrypted_data = "9";
                        }
                        if (letters == 'M' || letters == 'm')
                        {
                            storing_encrypted_data = "10";
                        }
                        if (letters == 'N' || letters == 'n')
                        {
                            storing_encrypted_data = "11";
                        }
                        if (letters == 'O' || letters == 'o')
                        {
                            storing_encrypted_data = "12";
                        }
                        if (letters == 'P' || letters == 'p')
                        {
                            storing_encrypted_data = "13";
                        }
                        if (letters == 'Q' || letters == 'q')
                        {
                            storing_encrypted_data = "14";
                        }
                        if (letters == 'R' || letters == 'r')
                        {
                            storing_encrypted_data = "15";
                        }
                        if (letters == 'S' || letters == 's')
                        {
                            storing_encrypted_data = "16";
                        }
                        if (letters == 'T' || letters == 't')
                        {
                            storing_encrypted_data = "17";
                        }
                        if (letters == 'U' || letters == 'u')
                        {
                            storing_encrypted_data = "18";
                        }
                        if (letters == 'V' || letters == 'v')
                        {
                            storing_encrypted_data = "19";
                        }
                        if (letters == 'W' || letters == 'w')
                        {
                            storing_encrypted_data = "20";
                        }
                        if (letters == 'X' || letters == 'x')
                        {
                            storing_encrypted_data = "21";
                        }
                        if (letters == 'Y' || letters == 'y')
                        {
                            storing_encrypted_data = "22";
                        }
                        if (letters == 'Z' || letters == 'z')
                        {
                            storing_encrypted_data = "23";
                        }
                        if(letters == ' ')
                        {
                            storing_encrypted_data = "0";
                        }
                        //--------------------------------
                        if (storing_encrypted_data == "1")
                        {
                            Console.Write("Z");
                        }
                        if (storing_encrypted_data == "2")
                        {
                            Console.Write("A");
                        }
                        if (storing_encrypted_data == "3")
                        {
                            Console.Write("B");
                        }
                        if (storing_encrypted_data == "4")
                        {
                            Console.Write("C");
                        }
                        if (storing_encrypted_data == "5")
                        {
                            Console.Write("D");
                        }
                        if (storing_encrypted_data == "6")
                        {
                            Console.Write("E");
                        }
                        if (storing_encrypted_data == "7")
                        {
                            Console.Write("F");
                        }
                        if (storing_encrypted_data == "8")
                        {
                            Console.Write("G");
                        }
                        if (storing_encrypted_data == "9")
                        {
                            Console.Write("H");
                        }
                        if (storing_encrypted_data == "10")
                        {
                            Console.Write("I");
                        }
                        if (storing_encrypted_data == "11")
                        {
                            Console.Write("J");
                        }
                        if (storing_encrypted_data == "12")
                        {
                            Console.Write("K");
                        }
                        if (storing_encrypted_data == "13")
                        {
                            Console.Write("L");
                        }
                        if (storing_encrypted_data == "14")
                        {
                            Console.Write("M");
                        }
                        if (storing_encrypted_data == "15")
                        {
                            Console.Write("N");
                        }
                        if (storing_encrypted_data == "16")
                        {
                            Console.Write("O");
                        }
                        if (storing_encrypted_data == "17")
                        {
                            Console.Write("P");
                        }
                        if (storing_encrypted_data == "18")
                        {
                            Console.Write("Q");
                        }
                        if (storing_encrypted_data == "19")
                        {
                            Console.Write("R");
                        }
                        if (storing_encrypted_data == "20")
                        {
                            Console.Write("S");
                        }
                        if (storing_encrypted_data == "21")
                        {
                            Console.Write("T");
                        }
                        if (storing_encrypted_data == "22")
                        {
                            Console.Write("U");
                        }
                        if (storing_encrypted_data == "23")
                        {
                            Console.Write("V");
                        }
                        if (storing_encrypted_data == "24")
                        {
                            Console.Write("W");
                        }
                        if (storing_encrypted_data == "25")
                        {
                            Console.Write("X");
                        }
                        if (storing_encrypted_data == "26")
                        {
                            Console.Write("Y");
                        }
                        if(storing_encrypted_data == "0")
                        {
                            Console.Write(" ");
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
