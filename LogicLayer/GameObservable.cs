using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    /// <summary>
    /// Observable
    /// </summary>
    public class GameObservable
    {
        private List<GameObserver> observers = new List<GameObserver>();

        /// <summary>
        /// Add an observer
        /// </summary>
        /// <param name="observer">observer to add</param>
        public void AddObserver(GameObserver observer)
        {
            observers.Add(observer);
        }

    
        protected void NotifyEvolveDone()
        {
            foreach(GameObserver obs in observers)
            {
                obs.ChangeState();    
            }
        }

    }
}
