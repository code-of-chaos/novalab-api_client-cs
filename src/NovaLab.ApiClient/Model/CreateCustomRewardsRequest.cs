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
///     CreateCustomRewardsRequest
/// </summary>
[DataContract(Name = "CreateCustomRewardsRequest")]
public class CreateCustomRewardsRequest : IEquatable<CreateCustomRewardsRequest>, IValidatableObject {
    /// <summary>
    ///     Initializes a new instance of the <see cref="CreateCustomRewardsRequest" /> class.
    /// </summary>
    /// <param name="title">title.</param>
    /// <param name="prompt">prompt.</param>
    /// <param name="cost">cost.</param>
    /// <param name="isEnabled">isEnabled.</param>
    /// <param name="backgroundColor">backgroundColor.</param>
    /// <param name="isUserInputRequired">isUserInputRequired.</param>
    /// <param name="isMaxPerStreamEnabled">isMaxPerStreamEnabled.</param>
    /// <param name="maxPerStream">maxPerStream.</param>
    /// <param name="isMaxPerUserPerStreamEnabled">isMaxPerUserPerStreamEnabled.</param>
    /// <param name="maxPerUserPerStream">maxPerUserPerStream.</param>
    /// <param name="isGlobalCooldownEnabled">isGlobalCooldownEnabled.</param>
    /// <param name="globalCooldownSeconds">globalCooldownSeconds.</param>
    /// <param name="shouldRedemptionsSkipRequestQueue">shouldRedemptionsSkipRequestQueue.</param>
    public CreateCustomRewardsRequest(string title = default, string prompt = default, int cost = default, bool isEnabled = default, string backgroundColor = default, bool isUserInputRequired = default, bool isMaxPerStreamEnabled = default, int? maxPerStream = default, bool isMaxPerUserPerStreamEnabled = default, int? maxPerUserPerStream = default, bool isGlobalCooldownEnabled = default, int? globalCooldownSeconds = default, bool shouldRedemptionsSkipRequestQueue = default) {
        Title = title;
        Prompt = prompt;
        Cost = cost;
        IsEnabled = isEnabled;
        BackgroundColor = backgroundColor;
        IsUserInputRequired = isUserInputRequired;
        IsMaxPerStreamEnabled = isMaxPerStreamEnabled;
        MaxPerStream = maxPerStream;
        IsMaxPerUserPerStreamEnabled = isMaxPerUserPerStreamEnabled;
        MaxPerUserPerStream = maxPerUserPerStream;
        IsGlobalCooldownEnabled = isGlobalCooldownEnabled;
        GlobalCooldownSeconds = globalCooldownSeconds;
        ShouldRedemptionsSkipRequestQueue = shouldRedemptionsSkipRequestQueue;
    }

    /// <summary>
    ///     Gets or Sets Title
    /// </summary>
    [DataMember(Name = "title", EmitDefaultValue = true)]
    public string Title { get; set; }

    /// <summary>
    ///     Gets or Sets Prompt
    /// </summary>
    [DataMember(Name = "prompt", EmitDefaultValue = true)]
    public string Prompt { get; set; }

    /// <summary>
    ///     Gets or Sets Cost
    /// </summary>
    [DataMember(Name = "cost", EmitDefaultValue = false)]
    public int Cost { get; set; }

    /// <summary>
    ///     Gets or Sets IsEnabled
    /// </summary>
    [DataMember(Name = "isEnabled", EmitDefaultValue = true)]
    public bool IsEnabled { get; set; }

    /// <summary>
    ///     Gets or Sets BackgroundColor
    /// </summary>
    [DataMember(Name = "backgroundColor", EmitDefaultValue = true)]
    public string BackgroundColor { get; set; }

    /// <summary>
    ///     Gets or Sets IsUserInputRequired
    /// </summary>
    [DataMember(Name = "isUserInputRequired", EmitDefaultValue = true)]
    public bool IsUserInputRequired { get; set; }

    /// <summary>
    ///     Gets or Sets IsMaxPerStreamEnabled
    /// </summary>
    [DataMember(Name = "isMaxPerStreamEnabled", EmitDefaultValue = true)]
    public bool IsMaxPerStreamEnabled { get; set; }

    /// <summary>
    ///     Gets or Sets MaxPerStream
    /// </summary>
    [DataMember(Name = "maxPerStream", EmitDefaultValue = true)]
    public int? MaxPerStream { get; set; }

    /// <summary>
    ///     Gets or Sets IsMaxPerUserPerStreamEnabled
    /// </summary>
    [DataMember(Name = "isMaxPerUserPerStreamEnabled", EmitDefaultValue = true)]
    public bool IsMaxPerUserPerStreamEnabled { get; set; }

    /// <summary>
    ///     Gets or Sets MaxPerUserPerStream
    /// </summary>
    [DataMember(Name = "maxPerUserPerStream", EmitDefaultValue = true)]
    public int? MaxPerUserPerStream { get; set; }

    /// <summary>
    ///     Gets or Sets IsGlobalCooldownEnabled
    /// </summary>
    [DataMember(Name = "isGlobalCooldownEnabled", EmitDefaultValue = true)]
    public bool IsGlobalCooldownEnabled { get; set; }

    /// <summary>
    ///     Gets or Sets GlobalCooldownSeconds
    /// </summary>
    [DataMember(Name = "globalCooldownSeconds", EmitDefaultValue = true)]
    public int? GlobalCooldownSeconds { get; set; }

    /// <summary>
    ///     Gets or Sets ShouldRedemptionsSkipRequestQueue
    /// </summary>
    [DataMember(Name = "shouldRedemptionsSkipRequestQueue", EmitDefaultValue = true)]
    public bool ShouldRedemptionsSkipRequestQueue { get; set; }

    /// <summary>
    ///     Returns true if CreateCustomRewardsRequest instances are equal
    /// </summary>
    /// <param name="input">Instance of CreateCustomRewardsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateCustomRewardsRequest input) {
        if (input == null) {
            return false;
        }
        return
            (
                Title == input.Title ||
                Title != null &&
                Title.Equals(input.Title)
            ) &&
            (
                Prompt == input.Prompt ||
                Prompt != null &&
                Prompt.Equals(input.Prompt)
            ) &&
            (
                Cost == input.Cost ||
                Cost.Equals(input.Cost)
            ) &&
            (
                IsEnabled == input.IsEnabled ||
                IsEnabled.Equals(input.IsEnabled)
            ) &&
            (
                BackgroundColor == input.BackgroundColor ||
                BackgroundColor != null &&
                BackgroundColor.Equals(input.BackgroundColor)
            ) &&
            (
                IsUserInputRequired == input.IsUserInputRequired ||
                IsUserInputRequired.Equals(input.IsUserInputRequired)
            ) &&
            (
                IsMaxPerStreamEnabled == input.IsMaxPerStreamEnabled ||
                IsMaxPerStreamEnabled.Equals(input.IsMaxPerStreamEnabled)
            ) &&
            (
                MaxPerStream == input.MaxPerStream ||
                MaxPerStream != null &&
                MaxPerStream.Equals(input.MaxPerStream)
            ) &&
            (
                IsMaxPerUserPerStreamEnabled == input.IsMaxPerUserPerStreamEnabled ||
                IsMaxPerUserPerStreamEnabled.Equals(input.IsMaxPerUserPerStreamEnabled)
            ) &&
            (
                MaxPerUserPerStream == input.MaxPerUserPerStream ||
                MaxPerUserPerStream != null &&
                MaxPerUserPerStream.Equals(input.MaxPerUserPerStream)
            ) &&
            (
                IsGlobalCooldownEnabled == input.IsGlobalCooldownEnabled ||
                IsGlobalCooldownEnabled.Equals(input.IsGlobalCooldownEnabled)
            ) &&
            (
                GlobalCooldownSeconds == input.GlobalCooldownSeconds ||
                GlobalCooldownSeconds != null &&
                GlobalCooldownSeconds.Equals(input.GlobalCooldownSeconds)
            ) &&
            (
                ShouldRedemptionsSkipRequestQueue == input.ShouldRedemptionsSkipRequestQueue ||
                ShouldRedemptionsSkipRequestQueue.Equals(input.ShouldRedemptionsSkipRequestQueue)
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
        sb.Append("class CreateCustomRewardsRequest {\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Prompt: ").Append(Prompt).Append("\n");
        sb.Append("  Cost: ").Append(Cost).Append("\n");
        sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
        sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
        sb.Append("  IsUserInputRequired: ").Append(IsUserInputRequired).Append("\n");
        sb.Append("  IsMaxPerStreamEnabled: ").Append(IsMaxPerStreamEnabled).Append("\n");
        sb.Append("  MaxPerStream: ").Append(MaxPerStream).Append("\n");
        sb.Append("  IsMaxPerUserPerStreamEnabled: ").Append(IsMaxPerUserPerStreamEnabled).Append("\n");
        sb.Append("  MaxPerUserPerStream: ").Append(MaxPerUserPerStream).Append("\n");
        sb.Append("  IsGlobalCooldownEnabled: ").Append(IsGlobalCooldownEnabled).Append("\n");
        sb.Append("  GlobalCooldownSeconds: ").Append(GlobalCooldownSeconds).Append("\n");
        sb.Append("  ShouldRedemptionsSkipRequestQueue: ").Append(ShouldRedemptionsSkipRequestQueue).Append("\n");
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
    public override bool Equals(object input) => Equals(input as CreateCustomRewardsRequest);

    /// <summary>
    ///     Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode() {
        unchecked// Overflow is fine, just wrap
        {
            int hashCode = 41;
            if (Title != null) {
                hashCode = hashCode * 59 + Title.GetHashCode();
            }
            if (Prompt != null) {
                hashCode = hashCode * 59 + Prompt.GetHashCode();
            }
            hashCode = hashCode * 59 + Cost.GetHashCode();
            hashCode = hashCode * 59 + IsEnabled.GetHashCode();
            if (BackgroundColor != null) {
                hashCode = hashCode * 59 + BackgroundColor.GetHashCode();
            }
            hashCode = hashCode * 59 + IsUserInputRequired.GetHashCode();
            hashCode = hashCode * 59 + IsMaxPerStreamEnabled.GetHashCode();
            if (MaxPerStream != null) {
                hashCode = hashCode * 59 + MaxPerStream.GetHashCode();
            }
            hashCode = hashCode * 59 + IsMaxPerUserPerStreamEnabled.GetHashCode();
            if (MaxPerUserPerStream != null) {
                hashCode = hashCode * 59 + MaxPerUserPerStream.GetHashCode();
            }
            hashCode = hashCode * 59 + IsGlobalCooldownEnabled.GetHashCode();
            if (GlobalCooldownSeconds != null) {
                hashCode = hashCode * 59 + GlobalCooldownSeconds.GetHashCode();
            }
            hashCode = hashCode * 59 + ShouldRedemptionsSkipRequestQueue.GetHashCode();
            return hashCode;
        }
    }
}
