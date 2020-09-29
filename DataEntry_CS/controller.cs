using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_CS
{
    public class controller
    {

        // 各種情報入力処理
        public static bool InputData(Models.HumanInfo humaninfo)
        {
            // 会社名入力
            humaninfo.CompanyName = inputStringCommon(resource.ADD_COMPANYNAME_TEXT);
            // null・から文字列・空白文字列の場合、関数を抜ける
            if (String.IsNullOrWhiteSpace(humaninfo.CompanyName))
            {
                return false;
            }

            // 部署名入力
            humaninfo.Department = inputStringCommon(resource.ADD_DEPARTMENT_TEXT);
            // null・から文字列・空白文字列の場合、関数を抜ける
            if (String.IsNullOrWhiteSpace(humaninfo.Department))
            {
                return false;
            }

            // 役職名入力
            humaninfo.Position = inputStringCommon(resource.ADD_POSITION_TEXT);
            // null・から文字列・空白文字列の場合、関数を抜ける
            if (String.IsNullOrWhiteSpace(humaninfo.Position))
            {
                return false;
            }

            // 氏名入力
            humaninfo.Name = inputStringCommon(resource.ADD_NAME_TEXT);
            // null・から文字列・空白文字列の場合、関数を抜ける
            if (String.IsNullOrWhiteSpace(humaninfo.Name))
            {
                return false;
            }

            // フリガナ入力
            humaninfo.ReadingKana = inputStringCommon(resource.ADD_READINGKANA_TEXT);
            // null・から文字列・空白文字列の場合、関数を抜ける
            if (String.IsNullOrWhiteSpace(humaninfo.ReadingKana))
            {
                return false;
            }

            // 年齢入力
            humaninfo.Old = inputIntCommon(resource.ADD_OLD_TEXT);
            // 0歳の場合、関数を抜ける
            if (humaninfo.Old == 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// データ入力共通処理（文字列）
        /// </summary>
        /// <param name="inputText">メッセージ文章</param>
        /// <returns></returns>
        public static string inputStringCommon(string inputText)
        {
            // 文章出力
            Console.WriteLine(inputText);

            // 入力
            var res = Console.ReadLine() ?? null;

            return res;
        }


        /// <summary>
        /// データ入力共通処理（数値）
        /// </summary>
        /// <param name="inputText">メッセージ文章</param>
        /// <returns></returns>
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
