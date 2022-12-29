using Newtonsoft.Json.Serialization;
using NJsonSchema;
using NJsonSchema.Generation;

namespace SchemaGenerator;
public static class JsonSchemaGenerator
{
	public static string GenerateSchema<T>()
	{
		var contractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() };
		var settings = new JsonSchemaGeneratorSettings { SerializerSettings = new() { ContractResolver = contractResolver } };
		var schema = JsonSchema.FromType<T>(settings);
		return schema.ToJson();
	}
}
