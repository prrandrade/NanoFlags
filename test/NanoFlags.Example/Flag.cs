namespace NanoFlags.Example
{
    using System;
    using Interfaces;
    
    public class ExampleBooleanFlag : BaseFlag<bool> 
    {
        public ExampleBooleanFlag(IFlagRepository flagRepository) : base(flagRepository) { }
    }

    public class ExampleIntFlag : BaseFlag<int>
    {
        public ExampleIntFlag(IFlagRepository flagRepository) : base(flagRepository) { }
    }

    public class ExampleDoubleFlag : BaseFlag<double>
    {
        public ExampleDoubleFlag(IFlagRepository flagRepository) : base(flagRepository) { }
    }

    public class ExampleStringFlag : BaseFlag<string>
    {
        public ExampleStringFlag(IFlagRepository flagRepository) : base(flagRepository) { }
    }

    public class ExampleDateTimeFlag : BaseFlag<DateTime>
    {
        public ExampleDateTimeFlag(IFlagRepository flagRepository) : base(flagRepository) { }
    }
}
