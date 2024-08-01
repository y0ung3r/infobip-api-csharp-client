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
    ///     SmsPreviewResponse
    /// </summary>
    [DataContract(Name = "SmsPreviewResponse")]
    public class SmsPreviewResponse : IEquatable<SmsPreviewResponse>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SmsPreviewResponse" /> class.
        /// </summary>
        /// <param name="originalText">Message content supplied in the request..</param>
        /// <param name="previews">
        ///     Allows for previewing the original message content once additional language configuration has
        ///     been applied to it..
        /// </param>
        public SmsPreviewResponse(string originalText = default, List<SmsPreview> previews = default)
        {
            OriginalText = originalText;
            Previews = previews;
        }

        /// <summary>
        ///     Message content supplied in the request.
        /// </summary>
        /// <value>Message content supplied in the request.</value>
        [DataMember(Name = "originalText", EmitDefaultValue = false)]
        public string OriginalText { get; set; }

        /// <summary>
        ///     Allows for previewing the original message content once additional language configuration has been applied to it.
        /// </summary>
        /// <value>
        ///     Allows for previewing the original message content once additional language configuration has been applied to
        ///     it.
        /// </value>
        [DataMember(Name = "previews", EmitDefaultValue = false)]
        public List<SmsPreview> Previews { get; set; }

        /// <summary>
        ///     Returns true if SmsPreviewResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsPreviewResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsPreviewResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    OriginalText == input.OriginalText ||
                    (OriginalText != null &&
                     OriginalText.Equals(input.OriginalText))
                ) &&
                (
                    Previews == input.Previews ||
                    (Previews != null &&
                     input.Previews != null &&
                     Previews.SequenceEqual(input.Previews))
                );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsPreviewResponse {\n");
            sb.Append("  OriginalText: ").Append(OriginalText).Append("\n");
            sb.Append("  Previews: ").Append(Previews).Append("\n");
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
            return Equals(input as SmsPreviewResponse);
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
                if (OriginalText != null)
                    hashCode = hashCode * 59 + OriginalText.GetHashCode();
                if (Previews != null)
                    hashCode = hashCode * 59 + Previews.GetHashCode();
                return hashCode;
            }
        }
    }
}