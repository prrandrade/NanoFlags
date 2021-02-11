namespace NanoFlags.Example
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;

    internal class Program
    {
        private static void Main()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddNanoFlags();
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var flagBool = serviceProvider.GetService<ExampleBooleanFlag>();
            var flagDouble = serviceProvider.GetService<ExampleDoubleFlag>();
            var flagInt = serviceProvider.GetService<ExampleIntFlag>();
            var flagString = serviceProvider.GetService<ExampleStringFlag>();
            var flagDateTime = serviceProvider.GetService<ExampleDateTimeFlag>();

            flagBool.SetValue(true);
            flagDouble.SetValue(3.2454159212312321);
            flagInt.SetValue(723425);
            flagString.SetValue("y3fgdfg");
            flagDateTime.SetValue(new DateTime(1986, 1, 5, 8, 0, 0));

            var valueBool = flagBool.GetValue();
            var valueDouble = flagDouble.GetValue();
            var valueInt = flagInt.GetValue();
            var valueString = flagString.GetValue();
            var valueDateTime = flagDateTime.GetValue();


            var flagTest = serviceProvider.GetService<ExampleBooleanFlag>();

            var l = new List<Task>();

            for (var i = 0; i < 10; i++)
            {
                l.Add(Task.Factory.StartNew(() =>
                {
                    flagTest.SetValue(false);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} - Value is now false");
                }));
            }

            for (var i = 0; i < 10; i++)
            {
                l.Add(Task.Factory.StartNew(() =>
                {
                    flagTest.SetValue(true);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} -Value is now true");
                }));
            }

            Task.WaitAll(l.ToArray());
        }
    }
}
