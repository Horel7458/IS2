using F23.StringSimilarity;
namespace InceputIS2Prroject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The similarity is (0)",new Cosine().Similarity("Hello, World!", "Hello, class!"));
    }
}