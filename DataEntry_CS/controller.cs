using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_CS
{
    public class controller
    {
        /// <summary>
        /// 各種情報入力処理
        /// </summary>
        /// <param name="humaninfo"></param>
        /// <returns></returns>
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
        /// 変更処理
        /// </summary>
        /// <param name="humaninfo"></param>
        /// <returns></returns>
        public static bool ChangeData(Models.HumanInfo humaninfo)
        {
            // 変更箇所選択
            var itemnumber = inputIntCommon(resource.ADD_SELECTITEM_TEXT);

            switch (itemnumber)
            {
                case 1:
                    humaninfo.CompanyName = inputStringCommon(resource.CHANGE_COMPANYNAME_TEXT, humaninfo.CompanyName);
                    break;
                case 2:
                    humaninfo.Department = inputStringCommon(resource.CHANGE_DEPARTMENT_TEXT, humaninfo.Department);
                    break;
                case 3:
                    humaninfo.Position = inputStringCommon(resource.CHANGE_POSITION_TEXT, humaninfo.Position);
                    break;
                case 4:
                    humaninfo.Name = inputStringCommon(resource.CHANGE_NAME_TEXT, humaninfo.Name);
                    break;
                case 5:
                    humaninfo.ReadingKana = inputStringCommon(resource.CHANGE_READINGKANA_TEXT, humaninfo.ReadingKana);
                    break;
                case 6:
                    humaninfo.Old = inputIntCommon(resource.CHANGE_OLD_TEXT, humaninfo.Old);
                    break;
                default:
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
        /// データ入力共通処理（文字列）オーバーライド
        /// </summary>
        /// <param name="inputText">メッセージ文章</param>
        /// <returns></returns>
        public static string inputStringCommon(string inputText, string item)
        {
            // 文章出力
            Console.WriteLine(inputText,item);

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


        /// <summary>
        /// データ入力共通処理（数値）
        /// </summary>
        /// <param name="inputText">メッセージ文章</param>
        /// <returns></returns>
        public static int inputIntCommon(string inputText, int item)
        {
            // 文章出力
            Console.WriteLine(inputText,item);

            // 入力
            var res = int.Parse(Console.ReadLine() ?? null);

            return res;
        }


    }
}
