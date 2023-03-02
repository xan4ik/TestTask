using System.Text;
using SortedArray = System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<string>>;


var testArr1 = new string[] { "торс", "Кто", "фывап", "рок", "ток", "рост", "кот" };
var testArr2 = new string[] { "ток", "рост", "КОТ", "торс", "сорт", "Кто", "фывап", "рок", "11", "b" };
var testArr3 = new string[] { "абв", "ваб", "ОООТ", "фыв", "Кто", "фывап", "рок", "ТоК", "aa",};


Display(SortStrings(testArr1));
Display(SortStrings(testArr2));
Display(SortStrings(testArr3));




static void Display(SortedArray strings) 
{
    foreach (var arr in strings)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\n\n");
}

static SortedArray SortStrings(IEnumerable<string> strings) 
{
    return strings
        .GroupBy(x => x.ToLower().Sum(x => (int)(x * x)) + 3000 * x.Length) // x * x - убирает возможные ситуации типа a+d = b+c 
        .Select(x => x.AsEnumerable());                                     // 3000 * x.Length - какая-нибудь соль, чтобы исключить ситуации типа ?? = b
}





