using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mindfulness_Hub_V3.Models;
using Mindfulness_Hub_V3.Service;

namespace Mindfulness_Hub_V3
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Init();
        }
    }
}
