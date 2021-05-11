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

namespace Infobip.Api.Client.Model
{
    /// <summary>
    ///     TfaVerifyPinResponse
    /// </summary>
    [DataContract(Name = "TfaVerifyPinResponse")]
    public class TfaVerifyPinResponse : IEquatable<TfaVerifyPinResponse>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TfaVerifyPinResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TfaVerifyPinResponse()
        {
        }

        /// <summary>
        ///     Number of remaining PIN attempts.
        /// </summary>
        /// <value>Number of remaining PIN attempts.</value>
        [DataMember(Name = "attemptsRemaining", EmitDefaultValue = false)]
        public int AttemptsRemaining { get; private set; }

        /// <summary>
        ///     Phone number (&#x60;MSISDN&#x60;) to which the 2FA message was sent.
        /// </summary>
        /// <value>Phone number (&#x60;MSISDN&#x60;) to which the 2FA message was sent.</value>
        [DataMember(Name = "msisdn", EmitDefaultValue = false)]
        public string Msisdn { get; private set; }

        /// <summary>
        ///     Indicates if any error occurs during PIN verification.
        /// </summary>
        /// <value>Indicates if any error occurs during PIN verification.</value>
        [DataMember(Name = "pinError", EmitDefaultValue = false)]
        public string PinError { get; private set; }

        /// <summary>
        ///     Sent PIN code ID.
        /// </summary>
        /// <value>Sent PIN code ID.</value>
        [DataMember(Name = "pinId", EmitDefaultValue = false)]
        public string PinId { get; private set; }

        /// <summary>
        ///     Indicates if the phone number (&#x60;MSISDN&#x60;) was successfully verified.
        /// </summary>
        /// <value>Indicates if the phone number (&#x60;MSISDN&#x60;) was successfully verified.</value>
        [DataMember(Name = "verified", EmitDefaultValue = true)]
        public bool Verified { get; private set; }

        /// <summary>
        ///     Returns false as AttemptsRemaining should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttemptsRemaining()
        {
            return false;
        }

        /// <summary>
        ///     Returns false as Msisdn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMsisdn()
        {
            return false;
        }

        /// <summary>
        ///     Returns false as PinError should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePinError()
        {
            return false;
        }

        /// <summary>
        ///     Returns false as PinId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePinId()
        {
            return false;
        }

        /// <summary>
        ///     Returns false as Verified should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVerified()
        {
            return false;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TfaVerifyPinResponse {\n");
            sb.Append("  AttemptsRemaining: ").Append(AttemptsRemaining).Append("\n");
            sb.Append("  Msisdn: ").Append(Msisdn).Append("\n");
            sb.Append("  PinError: ").Append(PinError).Append("\n");
            sb.Append("  PinId: ").Append(PinId).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
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
            return Equals(input as TfaVerifyPinResponse);
        }

        /// <summary>
        ///     Returns true if TfaVerifyPinResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TfaVerifyPinResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TfaVerifyPinResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    AttemptsRemaining == input.AttemptsRemaining ||
                    AttemptsRemaining.Equals(input.AttemptsRemaining)
                ) &&
                (
                    Msisdn == input.Msisdn ||
                    Msisdn != null &&
                    Msisdn.Equals(input.Msisdn)
                ) &&
                (
                    PinError == input.PinError ||
                    PinError != null &&
                    PinError.Equals(input.PinError)
                ) &&
                (
                    PinId == input.PinId ||
                    PinId != null &&
                    PinId.Equals(input.PinId)
                ) &&
                (
                    Verified == input.Verified ||
                    Verified.Equals(input.Verified)
                );
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + AttemptsRemaining.GetHashCode();
                if (Msisdn != null)
                    hashCode = hashCode * 59 + Msisdn.GetHashCode();
                if (PinError != null)
                    hashCode = hashCode * 59 + PinError.GetHashCode();
                if (PinId != null)
                    hashCode = hashCode * 59 + PinId.GetHashCode();
                hashCode = hashCode * 59 + Verified.GetHashCode();
                return hashCode;
            }
        }
    }
}