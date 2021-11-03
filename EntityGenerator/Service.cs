using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityGenerator
{
    public class Service
    {
        public string Convert(string text)
        {

            if (text == "")
            {
                return "";
            }

            string[] hoge = text.Split(',');

            // リターン用変数を生成
            StringBuilder result = new StringBuilder();

            // コメントを生成
            result.AppendLine("/**");
            result.AppendLine("* " + hoge[0]);
            result.AppendLine("*/");

            // アクセス修飾子はprivate
            // データ型をDBからJavaへ変換
            // メンバ名は小文字
            // セミコロンを付与
            result.AppendLine("private "
                + TypeConvertUtil.DbToEntity(hoge[2])
                + " " + hoge[1].ToLower() + ";");

            // 1行空白行入れる
            result.AppendLine();

            // リターン
            return result.ToString();


        }
    }
}
