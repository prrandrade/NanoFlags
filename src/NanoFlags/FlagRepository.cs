namespace NanoFlags
{
    using System;
    using Interfaces;
    using LiteDB;

    internal class FlagRepository : IFlagRepository
    {
        private readonly ILiteCollection<FlagValue> _flagCollection;

        public FlagRepository()
        {
            var db = new LiteDatabase(@"flags.db");
            _flagCollection = db.GetCollection<FlagValue>();
        }

        public void SetValue<T>(string name, T value)
        {
            var currentFlag = GetFlagValue<T>(name);
            if (currentFlag != null)
            {
                _flagCollection.Upsert(new FlagValue
                {
                    Id = currentFlag.Id,
                    Name = name, 
                    Type = typeof(T).ToString(), 
                    Value = Convert.ToString(value)
                });
            }
            else
            {
                _flagCollection.Insert(new FlagValue
                {
                    Name = name, 
                    Type = typeof(T).ToString(), 
                    Value = Convert.ToString(value)
                });
            }
        }
        
        public T GetValue<T>(string name)
        {
            var flagValue = GetFlagValue<T>(name);
            return (T) Convert.ChangeType(flagValue.Value, typeof(T));
        }

        private FlagValue GetFlagValue<T>(string name)
        {
            return _flagCollection.FindOne(x => x.Name == name && x.Type == typeof(T).ToString());
        }
    }
}
