#nullable enable
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Samhammer.AspNetCore.HealthChecks.Prtg.Contact;

namespace Samhammer.AspNetCore.HealthChecks.Prtg;

public class ChannelValueConverter : JsonConverter<PrtgResponseChannelValueBase>
{
    public override PrtgResponseChannelValueBase? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, PrtgResponseChannelValueBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
