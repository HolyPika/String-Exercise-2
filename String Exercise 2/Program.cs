namespace String_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");
            string input = Console.ReadLine();
            // readline yazilan seyi direkt okudugu icin string = readline demek kullanicinin yazdigini string degerine verir.

            Console.Write("Enter a character to search: ");
            char search = Console.ReadLine()[0];
            //char sadece tek bir karakteri depolamak icin kullanin degiskendir o yuzden kullanicinin aradigi tek kelimelik degeri bu degiskene atiyoruz

            int searchresult = input.IndexOf(search);
            //input.IndexOf(char) is a method in C# used to find the index of the first occurrence of a specified character (char) within a string called input.

            Console.WriteLine("Search of input of {0} is at index {1}", search, searchresult);


            // bu egzersizde concatination kullanarak isim soyisim yazilmasi gerekiyor.
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            string surname = Console.ReadLine();

            string fullname = string.Concat(name, " ", surname);

            Console.WriteLine("It is nice to meet you {0}", fullname);
        }
    }
}