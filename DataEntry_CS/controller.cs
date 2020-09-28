using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_CS
{
    public class controller
    {
        /***
         * データ入力共通処理（文字列）
        */
        public static string inputStringCommon(string inputText)
        {
            // 文章出力
            Console.WriteLine(inputText);

            // 入力
            var res = Console.ReadLine() ?? null;

            return res;
        }



        /***
         * データ入力共通処理（数値）
        */
        public static int inputIntCommon(string inputText)
        {
            // 文章出力
            Console.WriteLine(inputText);

            // 入力
            var res = int.Parse(Console.ReadLine() ?? null);

            return res;
        }


    }
}
