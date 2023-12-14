using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    struct parameter
    {
        public string key;
        public object value;

        public parameter(string key, object value)
        {
            this.key = key;
            this.value = value;
        }
    }

    class command
    {
        public static List<command> commands = new List<command>();

        public string Command;
        public List<parameter> Parameters = new List<parameter>();

        public command(string Command)
        {
            this.Command = Command;

            commands.Add(this);
        }
    }
}
