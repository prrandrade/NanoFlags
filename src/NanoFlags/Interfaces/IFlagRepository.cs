namespace NanoFlags.Interfaces
{
    public interface IFlagRepository
    {
        void SetValue<T>(string name, T value);

        T GetValue<T>(string name);
    }
}
