using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctWords
{
    public class WordsOperations
    {

        public void DisplayDistinctWords(string lsinputParagraph)
        {
            List<string> wordsList;
            List<string> distinctList;
            char[] seperators = new char[] { ' ', ',' };
            int count = 0;

            try
            {

                if (String.IsNullOrEmpty(lsinputParagraph))
                {
                    Console.WriteLine("Input paragraph is empty.");
                    return;
                }

                /* Split the Input paragraph by word seperators. */
                wordsList = lsinputParagraph.Split(seperators, StringSplitOptions.RemoveEmptyEntries).ToList();

                distinctList = wordsList.Select(x => x.TrimEnd('.')).Distinct(StringComparer.CurrentCultureIgnoreCase).ToList();

                /* Get the list of distinct words and count of each word in the paragraph. */
                foreach (string word in distinctList)
                {
                    count = wordsList.FindAll(x => x.TrimEnd('.').Equals(word, StringComparison.CurrentCultureIgnoreCase)).Count();

                    Console.WriteLine(word + " --> " + count.ToString());
                }                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
