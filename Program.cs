namespace SortingTechniques
{
    class Program
    {
        public static void Main(string[] args)
        {
            // BubbleSort sort = new BubbleSort();
            //sort.DisplayBubbleSort();
            //PrimeNum prime= new PrimeNum();
            //prime.Display();
            //InsertionSort.DisplayInsertion();
            //Anagram.DisplayAnagram();
            PrimeIsPalindromAndAnagram obja = new PrimeIsPalindromAndAnagram();
            obja.prime(2, 1000);
            obja.checkpal();
            obja.checkAnagram();

        }
    }
}