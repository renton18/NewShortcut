using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 新ファイル名を指定して実行.Model
{
    public class Command
    {
        public Command()
        {
        }

        public Command(string alias, string command, string commandName, string commandDetail, int usedCount, DateTime updateDateTime, DateTime createDateTime)
        {
            this.alias = alias;
            this.command = command;
            this.commandName = commandName;
            this.commandDetail = commandDetail;
            this.usedCount = usedCount;
            this.updateDateTime = updateDateTime;
            this.createDateTime = createDateTime;
        }

        public int id { get; set; }
        public string alias { get; set; }
        public string command { get; set; }
        public string commandName { get; set; }
        public string commandDetail { get; set; }
        public int usedCount { get; set; }
        public DateTime updateDateTime { get; set; }
        public DateTime createDateTime { get; set; }

    }
}
