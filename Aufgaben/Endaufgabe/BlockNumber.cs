using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

[JsonConverter(typeof(StringEnumConverter))]
enum BlockNumber {
    [EnumMember(Value = "1")]
    One=1, 
    [EnumMember(Value = "2")]
    Two=2, 
    [EnumMember(Value = "3")]
    Three=3, 
    [EnumMember(Value = "4")]
    Four=4, 
    [EnumMember(Value = "5")]
    Five=5, 
    [EnumMember(Value = "6")]
    Six=6, 
    [EnumMember(Value = "7")]
    Seven=7};