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
            
            
            var flagTest0 = serviceProvider.GetService<TestFlag0>();
            var flagTest1 = serviceProvider.GetService<TestFlag1>();
            var flagTest2 = serviceProvider.GetService<TestFlag2>();
            var flagTest3 = serviceProvider.GetService<TestFlag3>();
            var flagTest4 = serviceProvider.GetService<TestFlag4>();
            var flagTest5 = serviceProvider.GetService<TestFlag5>();
            var flagTest6 = serviceProvider.GetService<TestFlag6>();
            var flagTest7 = serviceProvider.GetService<TestFlag7>();
            var flagTest8 = serviceProvider.GetService<TestFlag8>();
            var flagTest9 = serviceProvider.GetService<TestFlag9>();

            var l = new List<Task>();

            
            // flagTest0
            for (var i = 0; i < 100; i++)
            {
                var j = i;
                l.Add(Task.Factory.StartNew(() =>
                {
                    flagTest0.SetValue(j % 2 == 0);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} - {nameof(flagTest0)} is changed!");
                }));
            }
            
            // flagTest1
            for (var i = 0; i < 100; i++)
            {
                var j = i;
                l.Add(Task.Factory.StartNew(() =>
                {
                    flagTest1.SetValue(j % 2 == 0);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} - {nameof(flagTest1)} is changed!");
                }));
            }
            
            // flagTest2
            for (var i = 0; i < 100; i++)
            {
                var j = i;
                l.Add(Task.Factory.StartNew(() =>
                {
                    flagTest2.SetValue(j % 2 == 0);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} - {nameof(flagTest2)} is changed!");
                }));
            }
            
            // flagTest3
            for (var i = 0; i < 100; i++)
            {
                var j = i;
                l.Add(Task.Factory.StartNew(() =>
                {
                    flagTest3.SetValue(j % 2 == 0);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} - {nameof(flagTest3)} is changed!");
                }));
            }
            
            // flagTest4
            for (var i = 0; i < 100; i++)
            {
                var j = i;
                l.Add(Task.Factory.StartNew(() =>
                {
                    flagTest4.SetValue(j % 2 == 0);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} - {nameof(flagTest4)} is changed!");
                }));
            }
            
            // flagTest5
            for (var i = 0; i < 100; i++)
            {
                var j = i;
                l.Add(Task.Factory.StartNew(() =>
                {
                    flagTest5.SetValue(j % 2 == 0);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} - {nameof(flagTest5)} is changed!");
                }));
            }
            
            // flagTest6
            for (var i = 0; i < 100; i++)
            {
                var j = i;
                l.Add(Task.Factory.StartNew(() =>
                {
                    flagTest6.SetValue(j % 2 == 0);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} - {nameof(flagTest6)} is changed!");
                }));
            }
            
            // flagTest7
            for (var i = 0; i < 100; i++)
            {
                var j = i;
                l.Add(Task.Factory.StartNew(() =>
                {
                    flagTest7.SetValue(j % 2 == 0);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} - {nameof(flagTest7)} is changed!");
                }));
            }
            
            // flagTest8
            for (var i = 0; i < 100; i++)
            {
                var j = i;
                l.Add(Task.Factory.StartNew(() =>
                {
                    flagTest8.SetValue(j % 2 == 0);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} - {nameof(flagTest8)} is changed!");
                }));
            }
            
            // flagTest9
            for (var i = 0; i < 100; i++)
            {
                var j = i;
                l.Add(Task.Factory.StartNew(() =>
                {
                    flagTest9.SetValue(j % 2 == 0);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss.ffff} - {nameof(flagTest9)} is changed!");
                }));
            }

            Task.WaitAll(l.ToArray());
        }
    }
}
