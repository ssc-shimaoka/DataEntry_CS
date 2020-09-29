using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_CS
{
    class resource
    {
        // 
        public static readonly string MAINMENU_TEXT = "メインメニュー\n１ 新規登録\n２ 一覧表示\n３ 未定\n４ 未定\n５ 終了";

        // 
        public static readonly string ADD_COMPANYNAME_TEXT = "会社名を入力してください\n＞";
        public static readonly string ADD_DEPARTMENT_TEXT = "部署名を入力してください\n＞";
        public static readonly string ADD_POSITION_TEXT = "役職名を入力してください\n＞";
        public static readonly string ADD_NAME_TEXT = "氏名を入力してください\n＞";
        public static readonly string ADD_READINGKANA_TEXT = "フリガナを入力してください\n＞";
        public static readonly string ADD_OLD_TEXT = "年齢を入力してください\n＞";

        // 
        public static readonly string ADD_SELECTNUMBER_TEXT = "番号を選択してください\n＞";
        public static readonly string ADD_SELECTFUNCTION_TEXT = "\n機能を選択してください\n１．変更\n２．削除\n＞";
        public static readonly string ADD_SELECTITEM_TEXT = "\n変更箇所を選択してください\n１．会社名\n２．部署\n３．役職\n４．氏名\n５．フリガナ\n６．年齢\n＞＞";

        public static readonly string CHANGE_COMPANYNAME_TEXT = "会社名\n\n現在の値：{0}\n＞";
        public static readonly string CHANGE_DEPARTMENT_TEXT = "部署名\n\n現在の値：{0}\n＞";
        public static readonly string CHANGE_POSITION_TEXT = "役職名\n\n現在の値：{0}\n＞";
        public static readonly string CHANGE_NAME_TEXT = "氏名\n\n現在の値：{0}\n＞";
        public static readonly string CHANGE_READINGKANA_TEXT = "フリガナ\n\n現在の値：{0}\n＞";
        public static readonly string CHANGE_OLD_TEXT = "年齢\n\n現在の値：{0}\n＞";
    }
}
