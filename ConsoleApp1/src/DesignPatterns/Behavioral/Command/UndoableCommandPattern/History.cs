using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Command.UndoableCommandPattern
{
    // Class to keep track of the commands that we've applied.
    public class History
    {
        private List<IUndoableCommand> commands = new List<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            commands.Add(command);
        }

        public IUndoableCommand Pop()
        {
            var last = commands.Last();
            commands.Remove(last);
            return last;
        }

        public int Size()
        {
            return commands.Count;
        }
    }
}