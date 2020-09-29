using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_CS
{
    class Program
    {
        /// <summary>
        /// *main処理 
        /// </summary>
        /// <param name="args"></param>
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
                        var selectNumber = DispInfo();
                        DispDetails(selectNumber);


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


        /// <summary>
        /// 新規登録機能
        /// </summary>
        /// <returns>登録可否</returns>
        public static bool AddUser()
        {
            Models.HumanInfo humaninfo = new Models.HumanInfo();

            // 各種情報入力処理
            controller.InputData(humaninfo);

            /*
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
            */

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


        /// <summary>
        /// 一覧表示処理
        /// </summary>
        public static int DispInfo()
        {
            // 画面クリア
            Console.Clear();

            // 読み込み処理
            var users = GetUserInfo();

            // データ一覧表示
            foreach(var user in users)
            {
                Console.WriteLine("{0} {1}\n", user.Id, user.Name);
            }

            // 変更・削除機能選択表示
            // 詳細情報選択画面表示
            var selectId = controller.inputIntCommon(resource.ADD_SELECTNUMBER_TEXT);
            if(1 > selectId || selectId > 10)
            {
                return -1;
            }
            else
            {
                return selectId;
            }
        }

        /// <summary>
        /// ユーザー情報読み込み
        /// </summary>
        /// <returns>DB読み込みデータ（リスト）</returns>
        public static IEnumerable<Models.HumanInfo> GetUserInfo()
        {
            using (var db = new Models.HumanInfoDbContext())
            {
                return db.HumanInfos
                    .ToList();
            }
        }

        public static bool DispDetails(int selectNumber)
        {
            // input値チェック
            if(selectNumber == -1)
            {
                return false;
            }

            // 画面クリア
            Console.Clear();

            // 詳細情報画面表示
            // 読み込み処理
            var users = GetUserInfo();

            // データ一覧表示
            foreach (var user in users)
            {
                if(selectNumber == user.Id)
                {
                    Console.WriteLine("会社名：{0}", user.CompanyName);
                    Console.WriteLine("部署名：{0}", user.Department);
                    Console.WriteLine("役職名：{0}", user.Position);
                    Console.WriteLine("氏名　：{0}", user.Name);

                }
            }

            return true;
        }

    }
}
