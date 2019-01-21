using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using 新ファイル名を指定して実行.Model;

namespace 新ファイル名を指定して実行
{
    public partial class Form1 : Form
    {
        //フォーム移動用
        [DllImport("user32.dll")] extern static int MoveWindow(IntPtr hwnd, int x, int y, int nWidth, int nHeight, int bRepaint);

        List<string> aliass = new List<string>();
        List<string> details1 = new List<string>();
        List<string> details2 = new List<string>();
        List<string> commands = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach (var items in Properties.Settings.Default.COMMANDS)
            //{
            //    var item = items.Split(',');
            //    //, new Command("cmd", "cmd", "コマンドプロンプト", "コマンドプロンプト", 0, DateTime.Now, DateTime.Now)
            //    Console.WriteLine(@",new Command(""" + item[0] + @""",""" + item[3] + @""",""" + item[1] + @""",""" + item[2]
            //           + @""",0, DateTime.Now, DateTime.Now)");
            //}


            //フォーム表示設定
            this.Height = 150;
            this.Width = 400;
            this.KeyPreview = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //フォーム表示位置
            switch (Properties.Settings.Default.displaySetting)
            {
                case "左上": this.Top = 0; this.Left = 0; break;
                case "左下": this.Top = Screen.PrimaryScreen.Bounds.Height - this.Height - 35; this.Left = 0; break;
                default: break;
            }

            //コマンド一覧表示
            List<Command> commandList;
            using (CommandDbContext db = new CommandDbContext())
            {
                commandList = db.Commands.ToList();
            }
            dataGridView1.DataSource = commandList;

            //コンボボックス サジェスト設定
            mainCb.Focus();
            AutoCompleteStringCollection sAutoList = new AutoCompleteStringCollection();
            mainCb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            mainCb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            mainCb.AutoCompleteCustomSource = sAutoList;
            //コンボボックス サジェストコマンド登録
            commandList.ToList().ForEach(c => sAutoList.Add(c.alias));
        }

        /// <summary>
        /// コマンド入力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMain_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER押下
            if (e.KeyValue == (char)Keys.Enter)
            {
                Command currentCommand;
                using (CommandDbContext db = new CommandDbContext())
                {
                    currentCommand = db.Commands.Single(c => c.alias == mainCb.Text.Trim());
                }

                string command = currentCommand.command;
                string currentArg = "";

                //スペースがあるコマンドの場合
                if (command.Contains(" "))
                {
                    //shell:で始まるもの
                    if (!command.Contains("shell:"))
                    {
                        currentArg = command.Substring(command.IndexOf(" "), command.Length - command.IndexOf(" ")).Trim();
                        command = command.Substring(0, command.IndexOf(" ")).Trim();
                    }
                }

                Process p = new Process();
                p.StartInfo.FileName = command;          // コマンド名
                if (currentArg != "") { p.StartInfo.Arguments = currentArg; }         // 引数有の場合
                if (e.Shift && e.Control) { p.StartInfo.Verb = "RunAs"; }         // CTRL + Shiftが押されたら管理者権限実行
                //p.StartInfo.CreateNoWindow = true;            // DOSプロンプトの黒い画面を非表示
                //p.StartInfo.UseShellExecute = false;          // プロセスを新しいウィンドウで起動するか否か
                //p.StartInfo.RedirectStandardOutput = true;    // 標準出力をリダイレクトして取得したい

                try
                {
                    p.Start();
                    //アイドル状態になるまで待機
                    //p.WaitForInputIdle();
                    //表示サイズ
                    //if (e.Alt)
                    //{
                    //    MoveWindow(p.MainWindowHandle, 0, 0,
                    //        Screen.PrimaryScreen.Bounds.Width / 2,
                    //        Screen.PrimaryScreen.Bounds.Height,
                    //        1);
                    //}

                    //「常に起動」にチェックなしの場合
                    if (!checkBoxKidoSetting.Checked)
                    {
                        this.Close();
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //設定モード F1
            if (e.KeyCode == Keys.F1)
            {
                if (this.Height == 150) { this.WindowState = FormWindowState.Maximized; }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Height = 150; this.Width = 400;
                }

                //フォーム位置
                switch (comboBoxDisplay.Text)
                {
                    case "左上": this.Top = 0; break;
                    case "左下": this.Top = Screen.PrimaryScreen.Bounds.Height - this.Height - 35; break;
                    default: break;
                }
            }
            //管理者権限モード SHIFT + CONTROL
            if (e.Shift && e.Control)
            {
                //this.Text = this.Text + "  【管理者権限】";
                //反転表示された文字列を批反転状態に戻す
                mainCb.SelectionStart = mainCb.Text.Length;
                mainCb.ForeColor = Color.Red;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Shift || e.Control)
            {
                //this.Text = this.Text.Replace("  【管理者権限】", "");
                mainCb.ForeColor = Color.Black;
            }
        }

        private void checkBoxKidoSetting_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.kidoSetting = checkBoxKidoSetting.Checked;
            Properties.Settings.Default.Save();
        }
        private void comboBoxDisplay_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.displaySetting = comboBoxDisplay.Text;
            Properties.Settings.Default.Save();
        }

        private void commandSearchTb_TextChanged(object sender, EventArgs e)
        {
            var keyword = commandSearchTb.Text.Trim();
            using (CommandDbContext db = new CommandDbContext())
            {
                dataGridView1.DataSource = db.Commands.Where(s => s.command.StartsWith(keyword)).ToList();
            }
        }

        private void commandNameSearchTb_TextChanged(object sender, EventArgs e)
        {
            var keyword = commandNameSearchTb.Text.Trim();
            using (CommandDbContext db = new CommandDbContext())
            {
                dataGridView1.DataSource = db.Commands.Where(s => s.commandName.StartsWith(keyword)).ToList();
            }
        }

        private void mainCb_KeyUp(object sender, KeyEventArgs e)
        {
            using (CommandDbContext db = new CommandDbContext())
            {
                try
                {
                    Command command = db.Commands.FirstOrDefault(c => c.alias == mainCb.Text.Trim());
                    if (command != null)
                    {
                        statusLb.Text = command.command + Environment.NewLine + command.commandName;
                    }
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
