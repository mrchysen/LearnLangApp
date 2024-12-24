using LearnLangApp.Core;

var cc = new CardCarousel<Card>([
    new() {
        Definition = "Text",
        Word = "Текст"
    },
    new() {
        Definition = "Any",
        Word = "Любой"
    },
    new() {
        Definition = "Split",
        Word = "Расколоть"
    }
    ]);

var coll = SomeStrangeFunction(cc);

foreach (var card in cc)
{
    Console.WriteLine($"{card.Definition} - {card.Word}");
}

Console.WriteLine(coll.First());

static IEnumerable<string> SomeStrangeFunction(CardCarousel<Card> carousel)
{
    int i = 0;

    foreach(var card in carousel)
    {
        i++;

        yield return card.Word + " " + i;
    }
}