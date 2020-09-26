using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_CS.Models
{
    public class HumanInfo
    {
        // キー
        public int Id { get; set; }

        // 会社名
        public string CompanyName { get; set; }

        // 部署
        public string Department { get; set; }

        // 役職
        public string Position { get; set; }

        // 氏名
        public string Name { get; set; }

        // フリガナ
        public string ReadingKana { get; set; }

        // 年齢
        public int Old { get; set; }
    }
}
