using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UISwitcher.UIState
{
    interface IUIState
    {
        public void Enter();

        public void Exit();
    }
}
