
var testArr1 = new string[] { "торс", "Кто", "фывап", "рок", "ток", "рост", "кот" };
var testArr2 = new string[] { "ток", "рост", "КОТ", "торс", "сорт", "Кто", "фывап", "рок" };
var testArr3 = new string[] { "абв", "ваб", "ОООТ", "фыв", "Кто", "фывап", "рок", "ТоК" };



Display(SortStrings(testArr1));
Display(SortStrings(testArr2));
Display(SortStrings(testArr3));



static void Display(IEnumerable<IEnumerable<string>> strings) 
{
    foreach (var arr in strings)
    {
        foreach (var item in arr)
        {
            Console.Write($" {item} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\n\n");
}

static IEnumerable<IEnumerable<string>> SortStrings(IEnumerable<string> strings) 
{
    return strings
        .GroupBy(x => x.ToLower().Sum(x => (int)x))
        .Select(x => x.AsEnumerable());
}


