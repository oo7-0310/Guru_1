using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int lastTick = 0;
            while (true)
            {
                int currentTick = System.Environment.TickCount;
                int elapsedTick = currentTick - lastTick;
                //입력

                //로직

                //렌더링
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Hello World!");
            }

            
        }
    }
}
