using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

[JsonConverter(typeof(StringEnumConverter))]
enum BlockNumber {
    [EnumMember(Value = "1")]
    Eins=1, 
    [EnumMember(Value = "2")]
    Zwei=2, 
    [EnumMember(Value = "3")]
    Drei=3, 
    [EnumMember(Value = "4")]
    Vier=4, 
    [EnumMember(Value = "5")]
    Fünf=5, 
    [EnumMember(Value = "6")]
    Sechs=6, 
    [EnumMember(Value = "7")]
    Sieben=7};