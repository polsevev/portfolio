using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.server.Pages
{
    public class counterClass: ComponentBase
    {
        public int currentCount = 0;
        public void incrementCount()
        {
            currentCount += 50000;
        }
    }
}
