//Made by AnonimKisi
using System;

namespace Caesar_Cipher_Encoding
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
                    Console.Write("Write the text that you want to encode: ");
                    string text = Console.ReadLine();
                    char[] chars = text.ToCharArray(0, text.Length);
                    Console.Write("\nEncoded version: ");

                    foreach (char letters in chars)
                    {
                        int storing_encoded_data = (int)letters;

                        if ((int)letters >= 65 && (int)letters <= 90)
                        {
                            if (letters == ' ')
                            {
                                storing_encoded_data = 0;
                            }

                            char new_letters = (char)(storing_encoded_data + 4);
                            new_letters = Char.ToUpper(new_letters);

                            if (new_letters == 'İ')
                            {
                                new_letters = 'I';
                            }

                            if (storing_encoded_data == 0)
                            {
                                new_letters = ' ';
                            }

                            if ((storing_encoded_data + 4) > 90)
                            {
                                new_letters = (char)(storing_encoded_data - 22);
                                new_letters = Char.ToUpper(new_letters);
                            }

                            Console.Write(new_letters);
                        }
                        else if ((int)letters >= 97 && (int)letters <= 122)
                        {
                            if (letters == ' ')
                            {
                                storing_encoded_data = 0;
                            }

                            char new_letters = (char)(storing_encoded_data + 4);
                            new_letters = Char.ToLower(new_letters);

                            if (new_letters == 'ı')
                            {
                                new_letters = 'i';
                            }

                            if (storing_encoded_data == 0)
                            {
                                new_letters = ' ';
                            }

                            if ((storing_encoded_data + 4) > 122)
                            {
                                new_letters = (char)(storing_encoded_data - 22);
                                new_letters = Char.ToLower(new_letters);
                            }

                            Console.Write(new_letters);
                        }else
                        {
                            Console.Write(letters);
                        }
                    }

                    Console.WriteLine();
                    Main();
                    break;

                //---------------------------------------------------------------------------------------------------------

                case 2:
                    Console.Write("Write the encoded text that you want to decode: ");
                    text = Console.ReadLine();
                    chars = text.ToCharArray(0, text.Length);
                    Console.Write("\nDecoded version: ");

                    foreach (char letters in chars)
                    {
                        int storing_encoded_data = (int)letters - 4;

                         if ((int)letters >= 65 && (int)letters <= 90)
                        {
                            if (storing_encoded_data < 65)
                            {
                                storing_encoded_data = (storing_encoded_data + 26);
                            }

                            if (letters == ' ')
                            {
                                storing_encoded_data = 0;
                            }

                            char new_letters = (char)storing_encoded_data;
                            new_letters = Char.ToUpper(new_letters);

                            if (storing_encoded_data == 0)
                            {
                                new_letters = ' ';
                            }

                            Console.Write(new_letters);
                        }
                        else if ((int)letters >= 97 && (int)letters <= 122)
                        {
                            if (storing_encoded_data < 97)
                            {
                                storing_encoded_data = (storing_encoded_data + 26);
                            }

                            if (letters == ' ')
                            {
                                storing_encoded_data = 0;
                            }

                            char new_letters = (char)storing_encoded_data;
                            new_letters = Char.ToLower(new_letters);

                            if (storing_encoded_data == 0)
                            {
                                new_letters = ' ';
                            }

                            Console.Write(new_letters);
                        }
                        else
                        {
                            Console.Write(letters);
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
