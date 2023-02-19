using System;
using System.Text.Json;

namespace SystemCore.Log
{

    public sealed class Log
    {
        public string nameOfLog { get; set; }
        public string description { get; set; }
        public Log(string nameOfLog, string description)
        {
            this.nameOfLog = nameOfLog;
            this.description = description;

        }
  
        public override string ToString() // Я не уверен, что ToString Должен возвращать сериализацию объекта, но пусть будет как фича.
        {
            return JsonSerializer.Serialize(this);
        }
        public string SelfSerialize()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
