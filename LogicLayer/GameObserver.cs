using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    /// <summary>
    /// Observer of game observable
    /// </summary>
    public interface GameObserver
    {
        /// <summary>
        /// Notify game changes (evolution done)
        /// </summary>
        void ChangeState();
    }
}
