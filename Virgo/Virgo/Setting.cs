using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virgo
{
    public class Setting
    {
        public static string hoge { get; set; } //テスト記述 グローバル変数的に使う方法？

        public Setting()
        {
            //初期値としてDBから設定を読み込む
            //DBからの読み込みに失敗した場合はデフォルト値を設定する
            //コンストラクタでセットし、あとは読み込みのみにしたい
            //可能ならクラスもシングルトン的に定義したい
            //TODO:デフォルト値の定義場所を検討
            //TODO:シングルトン的にクラスを保持する方法を調査
        }
    }
}
