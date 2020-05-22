using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Message {
    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public long? Code { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Director
    /// </summary>
    [DataMember(Name="director", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "director")]
    public string Director { get; set; }

    /// <summary>
    /// Gets or Sets Year
    /// </summary>
    [DataMember(Name="year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "year")]
    public long? Year { get; set; }

    /// <summary>
    /// Gets or Sets Cast
    /// </summary>
    [DataMember(Name="cast", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cast")]
    public string Cast { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Message {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Director: ").Append(Director).Append("\n");
      sb.Append("  Year: ").Append(Year).Append("\n");
      sb.Append("  Cast: ").Append(Cast).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
