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
    class CardsGenerator
    {  
        public CardsGenerator()
        {
            FirstCard = new Card();
            SecondCard = new Card();
        }
        public void GenerateRandomCards()
        {
            var rand = new System.Random();
            int firstFigureIndex = rand.Next(0, 13);
            int firstColorIndex = rand.Next(0, 3);
            FirstCard.figure = (Figure)firstFigureIndex;
            FirstCard.color = (Color)firstColorIndex;

            do
            {
                int secondFigureIndex = rand.Next(0, 13);
                int secondColorIndex = rand.Next(0, 3);
                SecondCard.figure = (Figure)secondFigureIndex;
                SecondCard.color = (Color)secondColorIndex;
            }
            while (FirstCard == SecondCard);
        }

        public Card FirstCard { get; private set; }
        public Card SecondCard { get; private set; }
    }

    class Card
    {
        public Color color;
        public Figure figure;
    }
}