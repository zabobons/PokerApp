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
    enum Color
    {
        Heart,
        Diamond,
        Club,
        Spade
    }

    enum Figure
    {
        Two,//0
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Quenn,
        King,
        Ace//12
    }
}