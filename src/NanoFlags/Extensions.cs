namespace NanoFlags
{
    using System;
    using System.Linq;
    using Interfaces;
    using Microsoft.Extensions.DependencyInjection;

    public static class Extensions
    {
        public static void AddNanoFlags(this ServiceCollection @this)
        {
            @this.AddSingleton<IFlagRepository, FlagRepository>();

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var mytype in assembly.GetTypes().Where(mytype => mytype.GetInterfaces().Contains(typeof(IFlag))))
                {
                    if (mytype.IsInterface || mytype.IsAbstract) continue;
                    @this.AddSingleton(mytype);
                }
            }
        }
    }
}
