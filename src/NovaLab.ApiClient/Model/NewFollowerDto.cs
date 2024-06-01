/*
 * NovaLab API
 *
 * An ASP.NET Core Web API for managing your streams
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
    /// NewFollowerDto
    /// </summary>
    [DataContract(Name = "NewFollowerDto")]
    public partial class NewFollowerDto : IEquatable<NewFollowerDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewFollowerDto" /> class.
        /// </summary>
        /// <param name="newFollowerId">newFollowerId.</param>
        /// <param name="followerGoalId">followerGoalId.</param>
        /// <param name="timeStamp">timeStamp.</param>
        /// <param name="followerTwitchUserId">followerTwitchUserId.</param>
        public NewFollowerDto(Guid newFollowerId = default(Guid), Guid followerGoalId = default(Guid), DateTime timeStamp = default(DateTime), string followerTwitchUserId = default(string))
        {
            this.NewFollowerId = newFollowerId;
            this.FollowerGoalId = followerGoalId;
            this.TimeStamp = timeStamp;
            this.FollowerTwitchUserId = followerTwitchUserId;
        }

        /// <summary>
        /// Gets or Sets NewFollowerId
        /// </summary>
        [DataMember(Name = "newFollowerId", EmitDefaultValue = false)]
        public Guid NewFollowerId { get; set; }

        /// <summary>
        /// Gets or Sets FollowerGoalId
        /// </summary>
        [DataMember(Name = "followerGoalId", EmitDefaultValue = false)]
        public Guid FollowerGoalId { get; set; }

        /// <summary>
        /// Gets or Sets TimeStamp
        /// </summary>
        [DataMember(Name = "timeStamp", EmitDefaultValue = false)]
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// Gets or Sets FollowerTwitchUserId
        /// </summary>
        [DataMember(Name = "followerTwitchUserId", EmitDefaultValue = true)]
        public string FollowerTwitchUserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NewFollowerDto {\n");
            sb.Append("  NewFollowerId: ").Append(NewFollowerId).Append("\n");
            sb.Append("  FollowerGoalId: ").Append(FollowerGoalId).Append("\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
            sb.Append("  FollowerTwitchUserId: ").Append(FollowerTwitchUserId).Append("\n");
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
            return this.Equals(input as NewFollowerDto);
        }

        /// <summary>
        /// Returns true if NewFollowerDto instances are equal
        /// </summary>
        /// <param name="input">Instance of NewFollowerDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewFollowerDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NewFollowerId == input.NewFollowerId ||
                    (this.NewFollowerId != null &&
                    this.NewFollowerId.Equals(input.NewFollowerId))
                ) && 
                (
                    this.FollowerGoalId == input.FollowerGoalId ||
                    (this.FollowerGoalId != null &&
                    this.FollowerGoalId.Equals(input.FollowerGoalId))
                ) && 
                (
                    this.TimeStamp == input.TimeStamp ||
                    (this.TimeStamp != null &&
                    this.TimeStamp.Equals(input.TimeStamp))
                ) && 
                (
                    this.FollowerTwitchUserId == input.FollowerTwitchUserId ||
                    (this.FollowerTwitchUserId != null &&
                    this.FollowerTwitchUserId.Equals(input.FollowerTwitchUserId))
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
                if (this.NewFollowerId != null)
                {
                    hashCode = (hashCode * 59) + this.NewFollowerId.GetHashCode();
                }
                if (this.FollowerGoalId != null)
                {
                    hashCode = (hashCode * 59) + this.FollowerGoalId.GetHashCode();
                }
                if (this.TimeStamp != null)
                {
                    hashCode = (hashCode * 59) + this.TimeStamp.GetHashCode();
                }
                if (this.FollowerTwitchUserId != null)
                {
                    hashCode = (hashCode * 59) + this.FollowerTwitchUserId.GetHashCode();
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
            yield break;
        }
    }

}
