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
        CardsGenerator()
        {
            _firstCard = new Card();
            _secondCard = new Card();
        }
        public void GenerateRandomCards()
        {
            var rand = new System.Random();
            int firstFigureIndex = rand.Next(0, 13);
            int firstColorIndex = rand.Next(0, 3);
            _firstCard.figure = (Figure)firstFigureIndex;
            _firstCard.color = (Color)firstColorIndex;

            do
            {
                int secondFigureIndex = rand.Next(0, 13);
                int secondColorIndex = rand.Next(0, 3);
                _secondCard.figure = (Figure)secondFigureIndex;
                _secondCard.color = (Color)secondColorIndex;
            }
            while (_firstCard == _secondCard);
        }

        Card _firstCard;
        Card _secondCard;
    }

    class Card
    {
        public Color color;
        public Figure figure;
    }
}