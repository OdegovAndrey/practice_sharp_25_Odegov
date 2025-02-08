namespace App;

public static class Prices
{
    public static string GetCurrencyAlias(int price, bool isShortNotation, bool isFirstCapital)
    {
        var stringEnd = "убль";
        var firstCapital = 'р';
        if (isFirstCapital)
            firstCapital = 'Р';
            
        if (isShortNotation)
        {
            Console.WriteLine($"{price} {firstCapital}уб.");
            return $"{price} {firstCapital}уб.";

        }
        else
        {
            if (true)
            {
                if (price > 10 && price < 21)
                {
                    stringEnd = "ублей";
                }
                else
                {
                    var price_last = price%10;
                    switch (price_last)
                    {
                        case 1:
                            stringEnd = "убль";
                            break;
                        case 2:
                        case 3: 
                        case 4:
                            stringEnd = "убля";
                            break;
                        case 5:
                        case 6: 
                        case 7:
                        case 8:
                        case 9: 
                        case 0:
                            stringEnd = "ублей";
                            break;
                    }
                }
                
            }
            Console.WriteLine($"{price} {firstCapital}{stringEnd}");
            return $"{price} {firstCapital}{stringEnd}";
        }
        // throw new NotImplementedException();
    }
}
