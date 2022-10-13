using System;

namespace pianoSSnl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("выберите октаву с помощью клавиш F1 или F2");
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                Console.WriteLine(key.Key);
                if (key.Key == ConsoleKey.F1)
                {
                    int f1 = 1;
                    sound1(f1);
                }
                if (key.Key == ConsoleKey.F2)
                {
                    int f2 = 2;
                    sound1(f2);
                }
                ConsoleKeyInfo keyA = Console.ReadKey();
                key = keyA;
            }
        }
        static void sound1(int count)
        {
            Console.WriteLine("Играйте с помщью клавиш ряда Q-P, A,S");
            ConsoleKeyInfo key1 = Console.ReadKey();
            while (key1.Key != ConsoleKey.Escape)
            {
                keymethod(key1);
                int keymethodback = count * keymethod(key1);
                Console.Beep(keymethodback, 200);
                ConsoleKeyInfo key1A = Console.ReadKey();
                Console.Clear();
                key1 = key1A;

            }
        }
        static int keymethod(ConsoleKeyInfo keyhold)
        {
            if (keyhold.Key == ConsoleKey.Q)
            {
                int keyback = octave1(0);
                return keyback;
            }
            else if (keyhold.Key == ConsoleKey.W)
            {
                int keyback = octave1(1);
                return keyback;
            }
            else if (keyhold.Key == ConsoleKey.E)
            {
                int keyback = octave1(2);
                return keyback;
            }
            else if (keyhold.Key == ConsoleKey.Q)
            {
                int keyback = octave1(3);
                return keyback;
            }
            else if (keyhold.Key == ConsoleKey.Q)
            {
                int keyback = octave1(4);
                return keyback;
            }
            else if (keyhold.Key == ConsoleKey.Y)
            {
                int keyback = octave1(5);
                return keyback;
            }
            else if (keyhold.Key == ConsoleKey.U)
            {
                int keyback = octave1(6);
                return keyback;
            }
            else if (keyhold.Key == ConsoleKey.I)
            {
                int keyback = octave1(7);
                return keyback;
            }
            else if (keyhold.Key == ConsoleKey.O)
            {
                int keyback = octave1(8);
                return keyback;
            }
            else if (keyhold.Key == ConsoleKey.P)
            {
                int keyback = octave1(9);
                return keyback;
            }
            else if (keyhold.Key == ConsoleKey.A)
            {
                int keyback = octave1(10);
                return keyback;
            }
            else if (keyhold.Key == ConsoleKey.S)
            {
                int keyback = octave1(11);
                return keyback;
            }
            else
            {
                int keyback = 0;
                return keyback;
            } 
        }
        static int octave1(int massivehold)
        {

            int[] firstOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            int massiveback1 = firstOctave[massivehold];
            return massiveback1;
        }
        static int octave2(int massivehold)
        {
            int[] secondOctave = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
            int massiveback2 = secondOctave[massivehold];
            return massiveback2;
        }
    }
}
