using Class07_Prep.Models.Characters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Class07_Prep.Data;

public class CharacterBaseConverter : JsonConverter<CharacterBase>
{
    public override CharacterBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            var root = doc.RootElement;
            var typeProperty = root.GetProperty("$type").GetString();
            Type type = typeProperty switch
            {
                "Class07_Prep.Models.Player" => typeof(Player),
                "Class07_Prep.Models.Goblin" => typeof(Goblin),
                "Class07_Prep.Models.Ghost" => typeof(Ghost),
                _ => throw new NotSupportedException($"Type {typeProperty} is not supported")
            };
            return (CharacterBase)JsonSerializer.Deserialize(root.GetRawText(), type, options);
        }
    }

    public override void Write(Utf8JsonWriter writer, CharacterBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, (object)value, options);
    }
}