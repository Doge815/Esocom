using System;
using System.Collections.Generic;

/*
 Brainfuck
 Chef
 Ook!
 LOLCODE
 Malbolge
 */

namespace calc
{
    class Program
    {
        static string code = "";
        static string language = "";

        static void Main(string[] args)
        {
            try { language = args[0]; } catch { goto Skip; };
            for(int i = 1; i < args.Length; i++)
                code += code[i];

            switch (language)
            {
                case "HQ9+": hq9(); break;
                case "HQ9++": hq9(); break;
                case "HQ9+-": hq9(); break;
            }

            Skip:
            Console.ReadKey();
        }

        public static void hq9()
        {
            void do_the_song()  //I think, I don't have much to say
            {
                for (int u = 99; u > 1; u--)
                {
                    Console.WriteLine($"{ u } bottles of beer on the wall,\n{ u } bottles of beer.");
                    Console.WriteLine($"Take one down, pass it around,\n{ u - 1 } bottles of beer on the wall.\n");
                }
                Console.WriteLine("1 bottle of beer on the wall,\n1 bottle of beer.\nTake one down, pass it around,\nno more bottles of beer on the wall.");
            }

            int i = 0;  //Akkumulator
            List<object> objects = new List<object>();  //created Objects are placed here
            bool build_object = false;

            for (int u = 0; u < code.Length; u++)   //Debugger
            { 
                if (!new List<char> { 'h', 'q', '9', '+', '\n' }.Contains(code[u]))
                {
                    if (!(language == "hq9+-" && code[u] == '-'))
                    {
                        Console.WriteLine($"Error in command { u + 1}, unexpected character, { code[u]} isn't defined.");
                        return;
                    }
                }
            }

            for (int u = 0; u < code.Length; u++)
            {
                switch (code[u])
                {  //Main output
                    case 'h': Console.WriteLine("Hello world!"); build_object = false; break;
                    //case 'q': Console.WriteLine(code.Replace("q", i.ToString())); build_object = false; break;
                    case 'q': Console.WriteLine(code); build_object = false; break;
                    case '9': do_the_song(); build_object = false; break;
                    case '+': i++; if (build_object) { build_object = false; objects.Add(new Object()); } else if (language == "hq9++") build_object = true; break;
                    case '-': i--; build_object = false; break;
                }
            }

        }

        public static void brainfuck()
        {
            int i = 0;
            int right = code.Length;
            while (i < right)
            {
                switch (code[i])
                {
                    case '>':
                        {
                            this.ptr++;
                            if (this.ptr >= BUFSIZE)
                            {
                                this.ptr = 0;
                            }
                            break;
                        }
                    case '<':
                        {
                            this.ptr--;
                            if (this.ptr < 0)
                            {
                                this.ptr = BUFSIZE - 1;
                            }
                            break;
                        }
                    case '.':
                        {
                            Console.Write((char)this.buf[this.ptr]);
                            break;
                        }
                    case '+':
                        {
                            this.buf[this.ptr]++;
                            break;
                        }
                    case '-':
                        {
                            this.buf[this.ptr]--;
                            break;
                        }
                    case '[':
                        {
                            if (this.buf[this.ptr] == 0)
                            {
                                int loop = 1;
                                while (loop > 0)
                                {
                                    i++;
                                    char c = s[i];
                                    if (c == '[')
                                    {
                                        loop++;
                                    }
                                    else
                                    if (c == ']')
                                    {
                                        loop--;
                                    }
                                }
                            }
                            break;
                        }
                    case ']':
                        {
                            int loop = 1;
                            while (loop > 0)
                            {
                                i--;
                                char c = s[i];
                                if (c == '[')
                                {
                                    loop--;
                                }
                                else
                                if (c == ']')
                                {
                                    loop++;
                                }
                            }
                            i--;
                            break;
                        }
                    case ',':
                        {
                            // read a key
                            ConsoleKeyInfo key = Console.ReadKey(this.echo);
                            this.buf[this.ptr] = (int)key.KeyChar;
                            break;
                        }
                }
                i++;
            }
        }
    }
}