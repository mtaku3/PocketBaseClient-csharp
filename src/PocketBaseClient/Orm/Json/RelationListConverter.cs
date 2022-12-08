﻿using PocketBaseClient.Services;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PocketBaseClient.Orm.Json
{
    public class RelationListConverter<L, T> : JsonConverter<L?>
        where L : IList<T>, new()
        where T : ItemBase, new()
    {
        public override L? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            L valueList = new();
            var strArray = JsonSerializer.Deserialize<string[]>(ref reader, options) ?? Array.Empty<string>();

            foreach (var str in strArray)
            {
                var value = DataServiceBase.GetCollection<T>()!.AddIdFromPb(str);
                if (value != null)
                    valueList.Add(value);
            }
            return valueList;
        }

        public override void Write(Utf8JsonWriter writer, L? value, JsonSerializerOptions options)
        {
            if (value is null)
                writer.WriteNullValue();
            else
            {
                writer.WriteStartArray();
                foreach (var val in value!)
                    writer.WriteStringValue(val.Id);
                writer.WriteEndArray();
            }
        }
    }
}