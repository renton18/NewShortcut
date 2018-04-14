using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 新ファイル名を指定して実行
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine(System.Diagnostics.Process.GetProcessesByName(
                System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length);
            //二重起動をチェックする
            if (System.Diagnostics.Process.GetProcessesByName("新ファイル名を指定して実行").Length > 1)
            {
                //すでに起動していると判断して終了
                System.Diagnostics.Process.GetProcessesByName("新ファイル名を指定して実行")[0].Kill();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
