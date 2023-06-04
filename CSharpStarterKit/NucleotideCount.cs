

namespace CSharpLearn
{
    internal static class NucleotideCountMod
    {

        public static void NucleotideCount(Language languageChoice)
        {
            // English: Implementation for the Nucleotide Count problem
            // Chinese: 核苷酸计数问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter a DNA sequence: ", "A:", "C:", "G:", "T:" } :
                new string[] { "输入一个DNA序列: ", "A:", "C:", "G:", "T:" };

            Console.Write(languageStrings[0]);
            string sequence = Console.ReadLine().ToUpper();

            Dictionary<char, int> nucleotideCount = new Dictionary<char, int>
        {
            { 'A', 0 },
            { 'C', 0 },
            { 'G', 0 },
            { 'T', 0 }
        };

            foreach (char nucleotide in sequence)
            {
                if (nucleotideCount.ContainsKey(nucleotide))
                {
                    nucleotideCount[nucleotide]++;
                }
            }

            Console.WriteLine(languageStrings[1] + nucleotideCount['A']);
            Console.WriteLine(languageStrings[2] + nucleotideCount['C']);
            Console.WriteLine(languageStrings[3] + nucleotideCount['G']);
            Console.WriteLine(languageStrings[4] + nucleotideCount['T']);
        }
    }
}