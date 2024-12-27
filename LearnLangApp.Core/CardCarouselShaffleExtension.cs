using System;

namespace LearnLangApp.Core;

public static class CardCarouselShaffleExtension
{
    public static CardCarousel<T> Shaffle<T>(this CardCarousel<T> cardCarousel) where T: Card
    {
        var list = cardCarousel.ToList();

        var random = new Random();

        for (int i = 0; i < list.Count; i++)
        {
            int randomNumber = i + (int)(random.NextDouble() * (list.Count - i));
            T t = list[randomNumber];
            list[randomNumber] = list[i];
            list[i] = t;
        }

        return new CardCarousel<T>(list);
    }
}
