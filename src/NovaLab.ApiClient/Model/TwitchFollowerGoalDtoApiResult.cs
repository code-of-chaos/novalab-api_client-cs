/*
 * NovaLab API
 *
 * An ASP.NET Core Web API for managing your streams
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace NovaLab.ApiClient.Model;

/// <summary>
///     TwitchFollowerGoalDtoApiResult
/// </summary>
[DataContract(Name = "TwitchFollowerGoalDtoApiResult")]
public class TwitchFollowerGoalDtoApiResult : IEquatable<TwitchFollowerGoalDtoApiResult>, IValidatableObject {
    /// <summary>
    ///     Initializes a new instance of the <see cref="TwitchFollowerGoalDtoApiResult" /> class.
    /// </summary>
    /// <param name="status">status.</param>
    /// <param name="message">message.</param>
    /// <param name="data">data.</param>
    public TwitchFollowerGoalDtoApiResult(HttpStatusCode? status = default, string message = default, List<TwitchFollowerGoalDto> data = default) {
        Status = status;
        Message = message;
        Data = data;
    }

    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public HttpStatusCode? Status { get; set; }

    /// <summary>
    ///     Gets or Sets Message
    /// </summary>
    [DataMember(Name = "message", EmitDefaultValue = true)]
    public string Message { get; set; }

    /// <summary>
    ///     Gets or Sets Data
    /// </summary>
    [DataMember(Name = "data", EmitDefaultValue = true)]
    public List<TwitchFollowerGoalDto> Data { get; set; }

    /// <summary>
    ///     Returns true if TwitchFollowerGoalDtoApiResult instances are equal
    /// </summary>
    /// <param name="input">Instance of TwitchFollowerGoalDtoApiResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TwitchFollowerGoalDtoApiResult input) {
        if (input == null) {
            return false;
        }
        return
            (
                Status == input.Status ||
                Status.Equals(input.Status)
            ) &&
            (
                Message == input.Message ||
                Message != null &&
                Message.Equals(input.Message)
            ) &&
            (
                Data == input.Data ||
                Data != null &&
                input.Data != null &&
                Data.SequenceEqual(input.Data)
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
        yield break;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString() {
        var sb = new StringBuilder();
        sb.Append("class TwitchFollowerGoalDtoApiResult {\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    ///     Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);

    /// <summary>
    ///     Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object input) => Equals(input as TwitchFollowerGoalDtoApiResult);

    /// <summary>
    ///     Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode() {
        unchecked// Overflow is fine, just wrap
        {
            int hashCode = 41;
            hashCode = hashCode * 59 + Status.GetHashCode();
            if (Message != null) {
                hashCode = hashCode * 59 + Message.GetHashCode();
            }
            if (Data != null) {
                hashCode = hashCode * 59 + Data.GetHashCode();
            }
            return hashCode;
        }
    }
}
