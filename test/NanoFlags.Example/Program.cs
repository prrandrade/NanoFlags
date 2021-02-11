namespace NanoFlags.Example
{
    using System;
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
        }
    }
}
