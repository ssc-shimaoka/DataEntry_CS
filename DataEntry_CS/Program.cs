using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_CS
{
    class Program
    {
        
        /***
         *main処理 
         * 
         */
        static void Main(string[] args)
        {

            // 起動時処理


            while(true)
            {
                // メインメニュー表示
                Console.WriteLine(resource.MAINMENU_TEXT);

                // 機能選択（入力）
                var menuNumber = int.Parse(Console.ReadLine());

                // 機能選択
                switch (menuNumber)
                {
                    // 登録
                    case 1:
                        AddUser();
                        break;

                    // 一覧表示
                    case 2:
                        DispInfo();
                        break;

                    // 未定
                    case 3:
                        break;

                    // 未定
                    case 4:
                        break;

                    // 終了
                    case 5:
                        // 終了時処理

                        return;

                }
            }

        }


        /***
        * 登録処理
        * 
        */
        public static bool AddUser()
        {
            Models.HumanInfo humaninfo = new Models.HumanInfo();

            // 会社名入力
            humaninfo.CompanyName = controller.inputStringCommon(resource.ADD_COMPANYNAME_TEXT);
            // null・から文字列・空白文字列の場合、関数を抜ける
            if(String.IsNullOrWhiteSpace(humaninfo.CompanyName))
            {
                return false;
            }

            // 部署名入力
            humaninfo.Department = controller.inputStringCommon(resource.ADD_DEPARTMENT_TEXT);
            // null・から文字列・空白文字列の場合、関数を抜ける
            if (String.IsNullOrWhiteSpace(humaninfo.Department))
            {
                return false;
            }

            // 役職名入力
            humaninfo.Position = controller.inputStringCommon(resource.ADD_POSITION_TEXT);
            // null・から文字列・空白文字列の場合、関数を抜ける
            if (String.IsNullOrWhiteSpace(humaninfo.Position))
            {
                return false;
            }

            // 氏名入力
            humaninfo.Name = controller.inputStringCommon(resource.ADD_NAME_TEXT);
            // null・から文字列・空白文字列の場合、関数を抜ける
            if (String.IsNullOrWhiteSpace(humaninfo.Name))
            {
                return false;
            }

            // フリガナ入力
            humaninfo.ReadingKana = controller.inputStringCommon(resource.ADD_READINGKANA_TEXT);
            // null・から文字列・空白文字列の場合、関数を抜ける
            if (String.IsNullOrWhiteSpace(humaninfo.ReadingKana))
            {
                return false;
            }

            // 年齢入力
            humaninfo.Old = controller.inputIntCommon(resource.ADD_OLD_TEXT);
            // 0歳の場合、関数を抜ける
            if (humaninfo.Old == 0)
            {
                return false;
            }


            // DB登録処理
            using (var db = new Models.HumanInfoDbContext())
            {
                // データ登録
                db.HumanInfos.Add(humaninfo);
                // DBデータ更新
                db.SaveChanges();
            }

            return true;
        }


        /***
        * 一覧表示処理
        * 
        */
        public static void DispInfo()
        {
            var users = GetUserInfo();

            foreach(var user in users)
            {
                Console.WriteLine("{0} {1}\n", user.Id, user.Name);
            }
 
        }


        /***
        * ユーザー情報読み込み
        * 
        */
        public static IEnumerable<Models.HumanInfo> GetUserInfo()
        {
            using (var db = new Models.HumanInfoDbContext())
            {
                return db.HumanInfos
                    .ToList();
            }
        }
    }
}
