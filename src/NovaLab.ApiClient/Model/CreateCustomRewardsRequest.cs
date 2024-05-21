/*
 * NovaLab API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = NovaLab.ApiClient.Client.OpenAPIDateConverter;

namespace NovaLab.ApiClient.Model
{
    /// <summary>
    /// CreateCustomRewardsRequest
    /// </summary>
    [DataContract(Name = "CreateCustomRewardsRequest")]
    public partial class CreateCustomRewardsRequest : IEquatable<CreateCustomRewardsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomRewardsRequest" /> class.
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
        public CreateCustomRewardsRequest(string title = default(string), string prompt = default(string), int cost = default(int), bool isEnabled = default(bool), string backgroundColor = default(string), bool isUserInputRequired = default(bool), bool isMaxPerStreamEnabled = default(bool), int? maxPerStream = default(int?), bool isMaxPerUserPerStreamEnabled = default(bool), int? maxPerUserPerStream = default(int?), bool isGlobalCooldownEnabled = default(bool), int? globalCooldownSeconds = default(int?), bool shouldRedemptionsSkipRequestQueue = default(bool))
        {
            this.Title = title;
            this.Prompt = prompt;
            this.Cost = cost;
            this.IsEnabled = isEnabled;
            this.BackgroundColor = backgroundColor;
            this.IsUserInputRequired = isUserInputRequired;
            this.IsMaxPerStreamEnabled = isMaxPerStreamEnabled;
            this.MaxPerStream = maxPerStream;
            this.IsMaxPerUserPerStreamEnabled = isMaxPerUserPerStreamEnabled;
            this.MaxPerUserPerStream = maxPerUserPerStream;
            this.IsGlobalCooldownEnabled = isGlobalCooldownEnabled;
            this.GlobalCooldownSeconds = globalCooldownSeconds;
            this.ShouldRedemptionsSkipRequestQueue = shouldRedemptionsSkipRequestQueue;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Prompt
        /// </summary>
        [DataMember(Name = "prompt", EmitDefaultValue = true)]
        public string Prompt { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name = "cost", EmitDefaultValue = false)]
        public int Cost { get; set; }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "isEnabled", EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundColor
        /// </summary>
        [DataMember(Name = "backgroundColor", EmitDefaultValue = true)]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Gets or Sets IsUserInputRequired
        /// </summary>
        [DataMember(Name = "isUserInputRequired", EmitDefaultValue = true)]
        public bool IsUserInputRequired { get; set; }

        /// <summary>
        /// Gets or Sets IsMaxPerStreamEnabled
        /// </summary>
        [DataMember(Name = "isMaxPerStreamEnabled", EmitDefaultValue = true)]
        public bool IsMaxPerStreamEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MaxPerStream
        /// </summary>
        [DataMember(Name = "maxPerStream", EmitDefaultValue = true)]
        public int? MaxPerStream { get; set; }

        /// <summary>
        /// Gets or Sets IsMaxPerUserPerStreamEnabled
        /// </summary>
        [DataMember(Name = "isMaxPerUserPerStreamEnabled", EmitDefaultValue = true)]
        public bool IsMaxPerUserPerStreamEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MaxPerUserPerStream
        /// </summary>
        [DataMember(Name = "maxPerUserPerStream", EmitDefaultValue = true)]
        public int? MaxPerUserPerStream { get; set; }

        /// <summary>
        /// Gets or Sets IsGlobalCooldownEnabled
        /// </summary>
        [DataMember(Name = "isGlobalCooldownEnabled", EmitDefaultValue = true)]
        public bool IsGlobalCooldownEnabled { get; set; }

        /// <summary>
        /// Gets or Sets GlobalCooldownSeconds
        /// </summary>
        [DataMember(Name = "globalCooldownSeconds", EmitDefaultValue = true)]
        public int? GlobalCooldownSeconds { get; set; }

        /// <summary>
        /// Gets or Sets ShouldRedemptionsSkipRequestQueue
        /// </summary>
        [DataMember(Name = "shouldRedemptionsSkipRequestQueue", EmitDefaultValue = true)]
        public bool ShouldRedemptionsSkipRequestQueue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCustomRewardsRequest);
        }

        /// <summary>
        /// Returns true if CreateCustomRewardsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCustomRewardsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCustomRewardsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Prompt == input.Prompt ||
                    (this.Prompt != null &&
                    this.Prompt.Equals(input.Prompt))
                ) && 
                (
                    this.Cost == input.Cost ||
                    this.Cost.Equals(input.Cost)
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.BackgroundColor == input.BackgroundColor ||
                    (this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(input.BackgroundColor))
                ) && 
                (
                    this.IsUserInputRequired == input.IsUserInputRequired ||
                    this.IsUserInputRequired.Equals(input.IsUserInputRequired)
                ) && 
                (
                    this.IsMaxPerStreamEnabled == input.IsMaxPerStreamEnabled ||
                    this.IsMaxPerStreamEnabled.Equals(input.IsMaxPerStreamEnabled)
                ) && 
                (
                    this.MaxPerStream == input.MaxPerStream ||
                    (this.MaxPerStream != null &&
                    this.MaxPerStream.Equals(input.MaxPerStream))
                ) && 
                (
                    this.IsMaxPerUserPerStreamEnabled == input.IsMaxPerUserPerStreamEnabled ||
                    this.IsMaxPerUserPerStreamEnabled.Equals(input.IsMaxPerUserPerStreamEnabled)
                ) && 
                (
                    this.MaxPerUserPerStream == input.MaxPerUserPerStream ||
                    (this.MaxPerUserPerStream != null &&
                    this.MaxPerUserPerStream.Equals(input.MaxPerUserPerStream))
                ) && 
                (
                    this.IsGlobalCooldownEnabled == input.IsGlobalCooldownEnabled ||
                    this.IsGlobalCooldownEnabled.Equals(input.IsGlobalCooldownEnabled)
                ) && 
                (
                    this.GlobalCooldownSeconds == input.GlobalCooldownSeconds ||
                    (this.GlobalCooldownSeconds != null &&
                    this.GlobalCooldownSeconds.Equals(input.GlobalCooldownSeconds))
                ) && 
                (
                    this.ShouldRedemptionsSkipRequestQueue == input.ShouldRedemptionsSkipRequestQueue ||
                    this.ShouldRedemptionsSkipRequestQueue.Equals(input.ShouldRedemptionsSkipRequestQueue)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Prompt != null)
                {
                    hashCode = (hashCode * 59) + this.Prompt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Cost.GetHashCode();
                hashCode = (hashCode * 59) + this.IsEnabled.GetHashCode();
                if (this.BackgroundColor != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundColor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsUserInputRequired.GetHashCode();
                hashCode = (hashCode * 59) + this.IsMaxPerStreamEnabled.GetHashCode();
                if (this.MaxPerStream != null)
                {
                    hashCode = (hashCode * 59) + this.MaxPerStream.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsMaxPerUserPerStreamEnabled.GetHashCode();
                if (this.MaxPerUserPerStream != null)
                {
                    hashCode = (hashCode * 59) + this.MaxPerUserPerStream.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsGlobalCooldownEnabled.GetHashCode();
                if (this.GlobalCooldownSeconds != null)
                {
                    hashCode = (hashCode * 59) + this.GlobalCooldownSeconds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShouldRedemptionsSkipRequestQueue.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
