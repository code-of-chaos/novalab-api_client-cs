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
    /// TwitchManagedRewardRedemption
    /// </summary>
    [DataContract(Name = "TwitchManagedRewardRedemption")]
    public partial class TwitchManagedRewardRedemption : IEquatable<TwitchManagedRewardRedemption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitchManagedRewardRedemption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TwitchManagedRewardRedemption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitchManagedRewardRedemption" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="twitchManagedReward">twitchManagedReward (required).</param>
        /// <param name="timeStamp">timeStamp.</param>
        /// <param name="username">username (required).</param>
        /// <param name="message">message.</param>
        public TwitchManagedRewardRedemption(Guid id = default(Guid), TwitchManagedReward twitchManagedReward = default(TwitchManagedReward), DateTime timeStamp = default(DateTime), string username = default(string), string message = default(string))
        {
            // to ensure "twitchManagedReward" is required (not null)
            if (twitchManagedReward == null)
            {
                throw new ArgumentNullException("twitchManagedReward is a required property for TwitchManagedRewardRedemption and cannot be null");
            }
            this.TwitchManagedReward = twitchManagedReward;
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new ArgumentNullException("username is a required property for TwitchManagedRewardRedemption and cannot be null");
            }
            this.Username = username;
            this.Id = id;
            this.TimeStamp = timeStamp;
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets TwitchManagedReward
        /// </summary>
        [DataMember(Name = "twitchManagedReward", IsRequired = true, EmitDefaultValue = true)]
        public TwitchManagedReward TwitchManagedReward { get; set; }

        /// <summary>
        /// Gets or Sets TimeStamp
        /// </summary>
        [DataMember(Name = "timeStamp", EmitDefaultValue = false)]
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", IsRequired = true, EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TwitchManagedRewardRedemption {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TwitchManagedReward: ").Append(TwitchManagedReward).Append("\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as TwitchManagedRewardRedemption);
        }

        /// <summary>
        /// Returns true if TwitchManagedRewardRedemption instances are equal
        /// </summary>
        /// <param name="input">Instance of TwitchManagedRewardRedemption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwitchManagedRewardRedemption input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TwitchManagedReward == input.TwitchManagedReward ||
                    (this.TwitchManagedReward != null &&
                    this.TwitchManagedReward.Equals(input.TwitchManagedReward))
                ) && 
                (
                    this.TimeStamp == input.TimeStamp ||
                    (this.TimeStamp != null &&
                    this.TimeStamp.Equals(input.TimeStamp))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.TwitchManagedReward != null)
                {
                    hashCode = (hashCode * 59) + this.TwitchManagedReward.GetHashCode();
                }
                if (this.TimeStamp != null)
                {
                    hashCode = (hashCode * 59) + this.TimeStamp.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
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
            // Username (string) maxLength
            if (this.Username != null && this.Username.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be less than 128.", new [] { "Username" });
            }

            // Username (string) minLength
            if (this.Username != null && this.Username.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be greater than 1.", new [] { "Username" });
            }

            // Message (string) maxLength
            if (this.Message != null && this.Message.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be less than 255.", new [] { "Message" });
            }

            yield break;
        }
    }

}
