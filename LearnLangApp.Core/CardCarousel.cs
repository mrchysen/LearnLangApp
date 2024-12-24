using System.Collections;

namespace LearnLangApp.Core;

public class CardCarousel<T> : IEnumerable<T> where T : Card
{
    private List<T> _cards;

    public CardCarousel(List<T> cards)
        => _cards = cards;
    
    public IEnumerator<T> GetEnumerator() => _cards.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _cards.GetEnumerator();
}
