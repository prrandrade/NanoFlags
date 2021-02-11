namespace NanoFlags.Interfaces
{
    public interface IFlag { }
    
    public interface IFlag<T> : IFlag
    {
        T GetValue();

        void SetValue(T value);
    }
}
