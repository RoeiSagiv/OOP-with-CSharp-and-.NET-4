using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class VersionAndSpacesMethods
    {
        public class Version : IClickReporter
        {
            public void ReportActionClicked()
            {
                showVersion();
            }

            private void showVersion()
            {
                Console.WriteLine("Version: 21.1.4.8930");
            }
        }

        public class CountSpaces : IClickReporter
        {
            public void ReportActionClicked()
            {
                showNumberOfSpacesInInputSentence();
            }

            private void showNumberOfSpacesInInputSentence()
            {
                string sentenceFromUser = getSentenceFromUser();
                int numberOfSpaces = countSpacesInTheSentence(sentenceFromUser);
                string numOfSentenceMsg = string.Format("The number of spaces in the sentence: {0} is {1}", sentenceFromUser, numberOfSpaces);
                Console.WriteLine(numOfSentenceMsg);
            }

            private string getSentenceFromUser()
            {
                string sentenceFromUser = string.Empty;
                Console.WriteLine("Please enter a sentence: ");
                sentenceFromUser = Console.ReadLine();

                return sentenceFromUser;
            }

            private int countSpacesInTheSentence(string i_SentenceFromUser)
            {
                string sentenceFromUser = i_SentenceFromUser;
                int numberOfSpaces = 0;
                char[] sentenceByChar = sentenceFromUser.ToCharArray();
                for(int i = 0; i < sentenceByChar.Length; i++)
                {
                    if(sentenceByChar[i] == ' ')
                    {
                        numberOfSpaces++;
                    }
                }

                return numberOfSpaces;
            }
        }
    }
}
