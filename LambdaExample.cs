using System;
using Amazon.Lambda.Core;
using Newtonsoft.Json;

namespace Example
{
    public class LambdaExample
    {

        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public Person FunctionHandler(ILambdaContext context)
        {
            Console.WriteLine("Hello World!");

            context.Logger.LogLine("Hello world");
            return new Person("Uilque Messias", 25);
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

    }

}
