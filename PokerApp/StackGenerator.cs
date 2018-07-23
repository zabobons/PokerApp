using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PokerApp
{
    class StackGeneratorHU
    {
        public StackGeneratorHU()
        {
            FirstPerson = new int();
            SecondPerson = new int();
            GenerateStack();
        }

        public virtual void GenerateStack()
        {
            var rand = new Random();
            FirstPerson = rand.Next(20, 1480);
            SecondPerson = 1500 - FirstPerson;
        }

        public int FirstPerson { get; protected set; }
        public int SecondPerson { get; protected set; }

    }

    class StackGenerator3way : StackGeneratorHU
    {
        public void StackGenerator()
        {
            ThirdPerson = new int();
            GenerateStack();
        }

        public override void GenerateStack()
        {
            var rand1 = new Random();
            FirstPerson = rand1.Next(20, 1380);
            SecondPerson = rand1.Next(20, 1500 - FirstPerson);
            ThirdPerson = 1500 - FirstPerson - SecondPerson;
        }

        public int ThirdPerson { get; private set; }
    }
}