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
                Console.WriteLine(resource.TEXT);

                // 機能選択（入力）
                var menuNumber = int.Parse(Console.ReadLine());

                // 機能選択
                switch (menuNumber)
                {
                    // 登録
                    case 1:

                        break;

                    // 一覧表示
                    case 2:
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
        public bool AddUser()
        {
            Models.HumanInfo humaninfo = new Models.HumanInfo();

            // 会社名 文章出力
            Console.WriteLine(resource.TEXT);

            // 会社名入力
            humaninfo.CompanyName = Console.ReadLine();














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

    }
}
