using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    class Program
    {
        public string Shortcut { set; get; }
        public string Path { set; get; }

        public Program()
        {
            Shortcut = "";
            Path = "";
        }

        public Program(string shortcut, string path)
        {
            Shortcut = shortcut;
            Path = path;
        }
    };

    class ProgramList : List<Program>
    {
        public Program Get(string shortcut)
        {
            return Find(p => p.Shortcut == shortcut);
        }
    }
}
