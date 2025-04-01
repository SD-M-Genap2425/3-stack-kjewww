using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;
//using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history

        HistoryManager historyManager = new();

        historyManager.KunjungiHalaman("google.com");
        historyManager.KunjungiHalaman("example.com");
        historyManager.KunjungiHalaman("stackoverflow.com");

        Console.WriteLine("Halaman saat ini: " + historyManager.LihatHalamanSaatIni());
        Console.WriteLine("Kembali ke " + historyManager.Kembali());
        Console.WriteLine("Halaman saat ini: " + historyManager.LihatHalamanSaatIni());
        Console.WriteLine("History:");
        historyManager.TampilkanHistory();

        // Bracket validator

        string ekspresiValid = "[{}](){}";
        string ekspresiInvalid = "(]";

        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {BracketValidator.ValidasiEkspresi(ekspresiValid)}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {BracketValidator.ValidasiEkspresi(ekspresiInvalid)}");

        //Palindrome Checker

        Console.WriteLine(PalindromeChecker.CekPalindrom("Kasur ini rusak"));
        Console.WriteLine(PalindromeChecker.CekPalindrom("Hello World"));
        Console.WriteLine(PalindromeChecker.CekPalindrom("A man, a plan, a canal: Panama"));
        Console.WriteLine(PalindromeChecker.CekPalindrom(""));
    }
}
