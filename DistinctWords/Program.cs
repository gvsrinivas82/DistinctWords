using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctWords
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string lsParagraph = "";

            WordsOperations objWordsOperation = new WordsOperations();

            /* Test Case 1 --> Pass empy string. It should display message "Input paragraph is empty." ==> SUCCESS */
            objWordsOperation.DisplayDistinctWords(lsParagraph);

            /* Test Case 2 */
            /* Expected Output --> The --> 2, Universe --> 2 ... All other words --> 1 ==> SUCCESS */
            lsParagraph = "The Universe is the most beautiful universe.";
            objWordsOperation.DisplayDistinctWords(lsParagraph);

            /* Test Case 3 */
            /* With some Extra spaces */
            /* Expected Output --> The --> 2, Universe --> 2 ... All other words --> 1 ==> SUCCESS */
            lsParagraph = "The   Universe  is the most    beautiful    universe.";
            objWordsOperation.DisplayDistinctWords(lsParagraph);

            /* Test Case 4 */
            /* With some Numbers */
            /* Expected Output
                The --> 1
                paragraph --> 2
                2 --> 1
                is --> 1
                very --> 1
                lengthy --> 1
                Need --> 1
                to --> 1
                split --> 1
                this --> 1             
             */
            /*  Testing ==> SUCCESS */
            lsParagraph = "The paragraph 2 is very lengthy. Need to split this paragraph.";
            objWordsOperation.DisplayDistinctWords(lsParagraph);

            /* Test Case 5 */
            /* With some Lengthy Paragraph ==> SUCCESS. */
            lsParagraph = "Bursting with imagery, motion, interaction and distraction though it is, today’s World Wide Web is still primarily a conduit for textual information. " +
                          "In HTML5, the focus on writing and authorship is more pronounced than ever. It’s evident in the very way that new elements such as article and aside are named. " +
                          "HTML5 asks us to treat the HTML document more as well, a document.";

            objWordsOperation.DisplayDistinctWords(lsParagraph);


            /* Test Casee 6 --> With decimal numbers. */
            /* Iteration 1 --> FAILED. 8.1 is returned as seperate two words which is wrong. */
            /* Iteration 2 --> SUCCESS. 8.1 is returned as one single words which is correct. */
            /* After this fix, RE-Ran all the above test cases. They passed successfully. */
            lsParagraph = "My phone is 8.1 version";
            objWordsOperation.DisplayDistinctWords(lsParagraph);

            Console.ReadLine();

        }
    }
}
