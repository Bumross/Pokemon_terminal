using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowManager windowManager = new WindowManager();
            windowManager.SetWindow(new Title());
            windowManager.DisplayWindow();
        }
    }}