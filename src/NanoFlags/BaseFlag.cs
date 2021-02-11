namespace NanoFlags
{
    using Interfaces;

    public abstract class BaseFlag<T> : IFlag<T>
    {
        private readonly IFlagRepository _flagRepository;

        protected BaseFlag(IFlagRepository flagRepository)
        {
            _flagRepository = flagRepository;
        }

        public T GetValue()
        {
            return _flagRepository.GetValue<T>(GetType().FullName);
        }

        public void SetValue(T value)
        {
            _flagRepository.SetValue(GetType().FullName, value);
        }
    }
}
