/*
 * Infobip Client API Libraries OpenAPI Specification
 * OpenAPI specification containing public endpoints supported in client API libraries.
 *
 * Contact: support@infobip.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Infobip.Api.Client.Model
{
    /// <summary>
    ///     EmailBulkScheduleResponse
    /// </summary>
    [DataContract(Name = "EmailBulkScheduleResponse")]
    public class EmailBulkScheduleResponse : IEquatable<EmailBulkScheduleResponse>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmailBulkScheduleResponse" /> class.
        /// </summary>
        /// <param name="externalBulkId">externalBulkId.</param>
        /// <param name="bulks">bulks.</param>
        public EmailBulkScheduleResponse(string externalBulkId = default, List<EmailBulkInfo> bulks = default)
        {
            ExternalBulkId = externalBulkId;
            Bulks = bulks;
        }

        /// <summary>
        ///     Gets or Sets ExternalBulkId
        /// </summary>
        [DataMember(Name = "externalBulkId", EmitDefaultValue = false)]
        public string ExternalBulkId { get; set; }

        /// <summary>
        ///     Gets or Sets Bulks
        /// </summary>
        [DataMember(Name = "bulks", EmitDefaultValue = false)]
        public List<EmailBulkInfo> Bulks { get; set; }

        /// <summary>
        ///     Returns true if EmailBulkScheduleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailBulkScheduleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailBulkScheduleResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    ExternalBulkId == input.ExternalBulkId ||
                    (ExternalBulkId != null &&
                     ExternalBulkId.Equals(input.ExternalBulkId))
                ) &&
                (
                    Bulks == input.Bulks ||
                    (Bulks != null &&
                     input.Bulks != null &&
                     Bulks.SequenceEqual(input.Bulks))
                );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailBulkScheduleResponse {\n");
            sb.Append("  ExternalBulkId: ").Append(ExternalBulkId).Append("\n");
            sb.Append("  Bulks: ").Append(Bulks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as EmailBulkScheduleResponse);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (ExternalBulkId != null)
                    hashCode = hashCode * 59 + ExternalBulkId.GetHashCode();
                if (Bulks != null)
                    hashCode = hashCode * 59 + Bulks.GetHashCode();
                return hashCode;
            }
        }
    }
}