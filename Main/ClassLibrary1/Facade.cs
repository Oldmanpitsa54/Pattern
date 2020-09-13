using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Facade
    {
        Engine engine;
        Wheel wheel;
        Window window;
        public Facade(Engine eng, Wheel whe, Window win)
        {
            engine = eng;
            wheel = whe;
            window = win;
        }
        public void BuildAll()
        {
            engine.Setup();
            wheel.Setup();
            window.Setup();
        }
        public void WithoutWheels()
        {
            engine.Setup();
            window.Setup();
        }
    }

    public class Engine
    {
        public void Setup()
        {
            Console.WriteLine("Engine has been set up!");
        }
    }

    public class Wheel
    {
        public void Setup()
        {
            Console.WriteLine("Wheel has been set up!");
        }
    }

    public class Window
    {
        public void Setup()
        {
            Console.WriteLine("Window has been set up!");
        }
    }
}
