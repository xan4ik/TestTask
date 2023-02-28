
var testArr1 = new string[] { "ток", "рост", "кот", "торс", "Кто", "фывап", "рок" };
var testArr2 = new string[] { "ток", "рост", "КОТ", "торс", "сорт", "Кто", "фывап", "рок" };
var testArr3 = new string[] { "абв", "ваб", "ОООТ", "фыв", "Кто", "фывап", "рок" };


var result = SortStrings(testArr1);
Display(SortStrings(testArr1));

result = SortStrings(testArr2);
Display(SortStrings(testArr2));

result = SortStrings(testArr3);
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
    int ConvertToInt(string value)
    {
        var norm = value.ToLower();
        return norm.AsEnumerable().Select(x => (int)x).Sum();
    }

    return strings.GroupBy(ConvertToInt).Select(x => x.AsEnumerable());
}


