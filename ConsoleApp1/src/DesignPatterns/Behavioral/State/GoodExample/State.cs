using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.State.GoodExample
{
    public interface IState
    {
        void Publish();

        // A real Document would have more state-dependent methods, such as Render() -- but we'll keep it simple with one method for this example.
    }
}