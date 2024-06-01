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
using System.Runtime.Serialization;
using System.Text;

namespace NovaLab.ApiClient.Model;

/// <summary>
///     PostManagedRewardDto
/// </summary>
[DataContract(Name = "PostManagedRewardDto")]
public class PostManagedRewardDto : IEquatable<PostManagedRewardDto>, IValidatableObject {
    /// <summary>
    ///     Initializes a new instance of the <see cref="PostManagedRewardDto" /> class.
    /// </summary>
    /// <param name="userId">userId.</param>
    /// <param name="twitchApiRequest">twitchApiRequest.</param>
    /// <param name="outputTemplatePerReward">outputTemplatePerReward.</param>
    /// <param name="outputTemplatePerRedemption">outputTemplatePerRedemption.</param>
    public PostManagedRewardDto(string userId = default, CreateCustomRewardsRequest twitchApiRequest = default, string outputTemplatePerReward = default, string outputTemplatePerRedemption = default) {
        UserId = userId;
        TwitchApiRequest = twitchApiRequest;
        OutputTemplatePerReward = outputTemplatePerReward;
        OutputTemplatePerRedemption = outputTemplatePerRedemption;
    }

    /// <summary>
    ///     Gets or Sets UserId
    /// </summary>
    [DataMember(Name = "userId", EmitDefaultValue = true)]
    public string UserId { get; set; }

    /// <summary>
    ///     Gets or Sets TwitchApiRequest
    /// </summary>
    [DataMember(Name = "twitchApiRequest", EmitDefaultValue = false)]
    public CreateCustomRewardsRequest TwitchApiRequest { get; set; }

    /// <summary>
    ///     Gets or Sets OutputTemplatePerReward
    /// </summary>
    [DataMember(Name = "outputTemplatePerReward", EmitDefaultValue = true)]
    public string OutputTemplatePerReward { get; set; }

    /// <summary>
    ///     Gets or Sets OutputTemplatePerRedemption
    /// </summary>
    [DataMember(Name = "outputTemplatePerRedemption", EmitDefaultValue = true)]
    public string OutputTemplatePerRedemption { get; set; }

    /// <summary>
    ///     Returns true if PostManagedRewardDto instances are equal
    /// </summary>
    /// <param name="input">Instance of PostManagedRewardDto to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PostManagedRewardDto input) {
        if (input == null) {
            return false;
        }
        return
            (
                UserId == input.UserId ||
                UserId != null &&
                UserId.Equals(input.UserId)
            ) &&
            (
                TwitchApiRequest == input.TwitchApiRequest ||
                TwitchApiRequest != null &&
                TwitchApiRequest.Equals(input.TwitchApiRequest)
            ) &&
            (
                OutputTemplatePerReward == input.OutputTemplatePerReward ||
                OutputTemplatePerReward != null &&
                OutputTemplatePerReward.Equals(input.OutputTemplatePerReward)
            ) &&
            (
                OutputTemplatePerRedemption == input.OutputTemplatePerRedemption ||
                OutputTemplatePerRedemption != null &&
                OutputTemplatePerRedemption.Equals(input.OutputTemplatePerRedemption)
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
        sb.Append("class PostManagedRewardDto {\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  TwitchApiRequest: ").Append(TwitchApiRequest).Append("\n");
        sb.Append("  OutputTemplatePerReward: ").Append(OutputTemplatePerReward).Append("\n");
        sb.Append("  OutputTemplatePerRedemption: ").Append(OutputTemplatePerRedemption).Append("\n");
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
    public override bool Equals(object input) => Equals(input as PostManagedRewardDto);

    /// <summary>
    ///     Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode() {
        unchecked// Overflow is fine, just wrap
        {
            int hashCode = 41;
            if (UserId != null) {
                hashCode = hashCode * 59 + UserId.GetHashCode();
            }
            if (TwitchApiRequest != null) {
                hashCode = hashCode * 59 + TwitchApiRequest.GetHashCode();
            }
            if (OutputTemplatePerReward != null) {
                hashCode = hashCode * 59 + OutputTemplatePerReward.GetHashCode();
            }
            if (OutputTemplatePerRedemption != null) {
                hashCode = hashCode * 59 + OutputTemplatePerRedemption.GetHashCode();
            }
            return hashCode;
        }
    }
}
