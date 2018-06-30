using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyIStrukturyDanych
{
    class FileManager
    {
        public void FillFile(int lenght,int max, int min)
        {
            Random random = new Random();

            using (StreamWriter sw = new StreamWriter(@".\Wejscie.dat"))
            {
                for (int i = 0; i < lenght; i++)
                {
                    sw.WriteLine(random.Next(min, max) + ";");
                }
            }
        }

        public int[] GetIntArrayFromFile()
        {
            string holder = "";
            string text;
            List<string> numbersList = new List<string>();

            using (StreamReader sr = new StreamReader(@".\Wejscie.dat"))
            {
                text = sr.ReadToEnd();
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ';')
                {
                    for (int j = i; j < text.Length; j++)
                    {
                        if (text[j] == ';')
                        {
                            i = j;
                            break;
                        }
                        holder += text[j];
                    }
                }
                numbersList.Add(holder);
                holder = "";
            }

            int[] numbersArray = new int[numbersList.Count - 2];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = Convert.ToInt32(numbersList[i]);
            }

            return numbersArray;
        }

        public void SetIntArrayToFile(int[] array)
        {
            using (StreamWriter sw = new StreamWriter(@".\Wyjscie.dat"))
            {
                for (int i = array.Length-1; i >= 0 ; i--)
                {
                    sw.WriteLine(array[i] + ";");
                }
            }
        }

    }
}
