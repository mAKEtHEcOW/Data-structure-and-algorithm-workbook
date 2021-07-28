using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dataStructure
{
    //辅助测试类
    class TestHelper
    {
        //读取名为filename的文件,并将它分词，分词后存入list中并返回使用
        public static List<string> ReadFile(string filename)
        {
            //使用FileStream类打开filename文件
            FileStream fs = new FileStream(filename, FileMode.Open);

            //使用StreamReader读取filename文件信息
            StreamReader sr = new StreamReader(fs);

            //将读取的单词存入动态词组words中
            List<string> words = new List<string>();

            //分词操作，这是一个非常简陋的分词方式
            //只要单词拼写不一样，我们就认为是不同的单词。不考虑单词的词性和时态
            while (!sr.EndOfStream)
            {
                //读取一行字符串并去除字符串的头部和尾部的空白符号，存储在contents中
                string contents = sr.ReadLine().Trim();

                //寻找contents第一个字母的位置
                int start = FirstCharacterIndex(contents, 0);

                //开始分词逻辑，讲一个个的单词存储在数组words中
                for (int i = start; i < contents.Length; i++)
                {
                    if (i == contents.Length || !Char.IsLetter(contents[i]))
                    {
                        string word = contents.Substring(start, i - start).ToLower();
                        words.Add(word);
                        start = FirstCharacterIndex(contents, i);
                        i = start + 1;
                    }
                    else
                        i++;
                }
            }

            //关闭流对象释放资源
            fs.Close();
            sr.Close();

            return words;
        }

        private static int FirstCharacterIndex(string s, int start)
        {
            for (int i = start; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    return i;
                }

            }
            return s.Length;
        }
    }
}
