using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DylginA.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string result = "";

            foreach (string line in lines)
            {
                string[] words = line.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (word.Contains("w"))
                    {
                        result += word + " ";
                    }
                }
            }
            return result.Trim();
        }
        /*
            nXkwQYzgZ tsCms LlckTwkpaAGTvLPc
            fthzqqL XcNHugFmbsRgVVfsgHNGuUC
            SeRTRfFeAxzn raCml PzLyVamXVcmNn
            dlezsxTS z KxFxadaTMeBz BRW pSuA
            tVMMaxdnYJoY EUAji hntD RTmxxVdu
         */
    }
}
