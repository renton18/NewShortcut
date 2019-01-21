using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using 新ファイル名を指定して実行.Model;

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
            //すでに起動している場合
            Process[] pss = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            if (pss.Count() >= 2)
            {
                //LINGを使用する場合
                pss.Single(p => p.Id != Process.GetCurrentProcess().Id).Kill();

                //LINQを使用しない場合（using System.Linq;必要）
                //foreach (var ps in pss)
                //{
                //    if (ps.Id != Process.GetCurrentProcess().Id)
                //    {
                //        ps.Kill();
                //    }
                //}
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
         }
    }
}
