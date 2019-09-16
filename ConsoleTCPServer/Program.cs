 using System;
 using System.Collections.Generic;
 using System.Text;
 using System.Net.Sockets;
 using System.Net;
 using System.Threading;
 using System.Text.RegularExpressions;
 using System.IO;

namespace ConsoleTCPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определим нужное максимальное количество потоков
            // Пусть будет по 4 на каждый процессор
            int MaxThreadsCount = Environment.ProcessorCount * 4;
            // Установим максимальное количество рабочих потоков
            ThreadPool.SetMaxThreads(MaxThreadsCount, MaxThreadsCount);
            // Установим минимальное количество рабочих потоков
            ThreadPool.SetMinThreads(2, 2);
            // Создадим новый сервер на порту 80
            new Server(808);
        }
    }
}
 