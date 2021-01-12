using System;

namespace Task_4
{
    class Robot
    {
        // класс для представления робота
        int x, y; // положение робота на плоскости 

        public void Right() { x++; }      // направо
        public void Left() { x--; }      // налево
        public void Forward() { y++; }  // вперед
        public void Backward() { y--; }  // назад

        public string Position()
        {  // сообщить координаты
            return String.Format("The Robot position: x={0}, y={1}", x, y);
        }
    }
    delegate void Steps();
    class Program
    {
        static void Main(string[] args)
        {
            Robot rob = new Robot();    // конкретный робот 
            Console.WriteLine("Enter commands divided by space");
            string[] arr = Console.ReadLine().Split();
            Steps[] trace = new Steps[arr.Length];
            Steps delR = new Steps(rob.Right);      // направо
            Steps delL = new Steps(rob.Left);       // налево
            Steps delF = new Steps(rob.Forward);    // вперед
            Steps delB = new Steps(rob.Backward);   // назад
                                                    // шаги по диагоналям (многоадресные делегаты):
            Steps delRF = delR + delF;
            Steps delRB = delR + delB;
            Steps delLF = delL + delF;
            Steps delLB = delL + delB;
            for (int i=0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case "L":
                        trace[i]= delL;
                        break;
                    case "R":
                        trace[i] = delR;
                        break;
                    case "F":
                        trace[i] = delF;
                        break;
                    case "B":
                        trace[i] = delB;
                        break;
                    case "RF":
                        trace[i] = delRF;
                        break;
                    case "RB":
                        trace[i] = delRB;
                        break;
                    case "LF":
                        trace[i] = delLF;
                        break;
                    case "LB":
                        trace[i] = delLB;
                        break;
                }
            }
           
            // сообщить координаты
            Console.WriteLine("Start:" + rob.Position());
            Steps del = trace[0];
            for(int i = 1; i < trace.Length; i++)
            {
                del += trace[i];
            }
            del();
            Console.WriteLine(rob.Position());     // сообщить координаты
            Console.WriteLine("Для завершения нажмите любую клавишу.");
            Console.ReadKey();

        }
    }
}
