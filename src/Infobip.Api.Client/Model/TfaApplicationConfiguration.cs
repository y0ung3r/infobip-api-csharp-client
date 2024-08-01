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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Infobip.Api.Client.Model
{
    /// <summary>
    ///     Created 2FA application configuration.
    /// </summary>
    [DataContract(Name = "TfaApplicationConfiguration")]
    public class TfaApplicationConfiguration : IEquatable<TfaApplicationConfiguration>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TfaApplicationConfiguration" /> class.
        /// </summary>
        /// <param name="allowMultiplePinVerifications">Indicates whether multiple PIN verification is allowed. (default to true).</param>
        /// <param name="pinAttempts">Number of possible PIN attempts. (default to 10).</param>
        /// <param name="pinTimeToLive">
        ///     Validity period of PIN in specified time unit. Required format: &#x60;
        ///     {timeLength}{timeUnit}&#x60;. &#x60;timeLength&#x60; is optional with a default value of 1. &#x60;timeUnit&#x60;
        ///     can be set to: &#x60;ms&#x60;, &#x60;s&#x60;, &#x60;m&#x60;, &#x60;h&#x60; or &#x60;d&#x60; representing
        ///     milliseconds, seconds, minutes, hours, and days respectively. Must not exceed one year, although much lower value
        ///     is recommended. (default to &quot;15m&quot;).
        /// </param>
        /// <param name="sendPinPerApplicationLimit">
        ///     Overall number of requests over a specififed time period for generating a PIN
        ///     and sending an SMS using a single application. Required format: &#x60;{attempts}/{timeLength}{timeUnit}&#x60;.
        ///     &#x60;attempts&#x60; and &#x60;timeunit&#x60; are mandatory and &#x60;timeLength&#x60; is optional with a default
        ///     value of 1. &#x60;timeUnit&#x60; is one of: &#x60;ms&#x60;, &#x60;s&#x60;, &#x60;m&#x60;, &#x60;h&#x60; or &#x60;d
        ///     &#x60; representing milliseconds, seconds, minutes, hours, and days respectively. Must not exceed one year,
        ///     although much lower value is recommended. (default to &quot;10000/1d&quot;).
        /// </param>
        /// <param name="sendPinPerPhoneNumberLimit">
        ///     Number of requests over a specififed time period for generating a PIN and
        ///     sending an SMS to one phone number (MSISDN). Required format: &#x60;{attempts}/{timeLength}{timeUnit}&#x60;. &#x60;
        ///     attempts&#x60; and &#x60;timeunit&#x60; are mandatory and &#x60;timeLength&#x60; is optional with a default value
        ///     of 1. &#x60;timeUnit&#x60; is one of: &#x60;ms&#x60;, &#x60;s&#x60;, &#x60;m&#x60;, &#x60;h&#x60; or &#x60;d&#x60;
        ///     representing milliseconds, seconds, minutes, hours, and days respectively. Must not exceed one year, although much
        ///     lower value is recommended. (default to &quot;3/1d&quot;).
        /// </param>
        /// <param name="verifyPinLimit">
        ///     The number of PIN verification requests over a specififed time period from one phone
        ///     number (MSISDN). Required format: &#x60;{attempts}/{timeLength}{timeUnit}&#x60;. &#x60;attempts&#x60; and &#x60;
        ///     timeunit&#x60; are mandatory and &#x60;timeLength&#x60; is optional with a default value of 1. &#x60;timeUnit&#x60;
        ///     is one of: &#x60;ms&#x60;, &#x60;s&#x60;, &#x60;m&#x60;, &#x60;h&#x60; or &#x60;d&#x60; representing milliseconds,
        ///     seconds, minutes, hours, and days respectively. Must not exceed one day, although much lower value is recommended.
        ///     (default to &quot;1/3s&quot;).
        /// </param>
        public TfaApplicationConfiguration(bool allowMultiplePinVerifications = true, int pinAttempts = 10,
            string pinTimeToLive = "15m", string sendPinPerApplicationLimit = "10000/1d",
            string sendPinPerPhoneNumberLimit = "3/1d", string verifyPinLimit = "1/3s")
        {
            AllowMultiplePinVerifications = allowMultiplePinVerifications;
            PinAttempts = pinAttempts;
            // use default value if no "pinTimeToLive" provided
            PinTimeToLive = pinTimeToLive ?? "15m";
            // use default value if no "sendPinPerApplicationLimit" provided
            SendPinPerApplicationLimit = sendPinPerApplicationLimit ?? "10000/1d";
            // use default value if no "sendPinPerPhoneNumberLimit" provided
            SendPinPerPhoneNumberLimit = sendPinPerPhoneNumberLimit ?? "3/1d";
            // use default value if no "verifyPinLimit" provided
            VerifyPinLimit = verifyPinLimit ?? "1/3s";
        }

        /// <summary>
        ///     Indicates whether multiple PIN verification is allowed.
        /// </summary>
        /// <value>Indicates whether multiple PIN verification is allowed.</value>
        [DataMember(Name = "allowMultiplePinVerifications", EmitDefaultValue = true)]
        public bool AllowMultiplePinVerifications { get; set; }

        /// <summary>
        ///     Number of possible PIN attempts.
        /// </summary>
        /// <value>Number of possible PIN attempts.</value>
        [DataMember(Name = "pinAttempts", EmitDefaultValue = false)]
        public int PinAttempts { get; set; }

        /// <summary>
        ///     Validity period of PIN in specified time unit. Required format: &#x60;{timeLength}{timeUnit}&#x60;. &#x60;
        ///     timeLength&#x60; is optional with a default value of 1. &#x60;timeUnit&#x60; can be set to: &#x60;ms&#x60;, &#x60;s
        ///     &#x60;, &#x60;m&#x60;, &#x60;h&#x60; or &#x60;d&#x60; representing milliseconds, seconds, minutes, hours, and days
        ///     respectively. Must not exceed one year, although much lower value is recommended.
        /// </summary>
        /// <value>
        ///     Validity period of PIN in specified time unit. Required format: &#x60;{timeLength}{timeUnit}&#x60;. &#x60;
        ///     timeLength&#x60; is optional with a default value of 1. &#x60;timeUnit&#x60; can be set to: &#x60;ms&#x60;, &#x60;s
        ///     &#x60;, &#x60;m&#x60;, &#x60;h&#x60; or &#x60;d&#x60; representing milliseconds, seconds, minutes, hours, and days
        ///     respectively. Must not exceed one year, although much lower value is recommended.
        /// </value>
        [DataMember(Name = "pinTimeToLive", EmitDefaultValue = false)]
        public string PinTimeToLive { get; set; }

        /// <summary>
        ///     Overall number of requests over a specififed time period for generating a PIN and sending an SMS using a single
        ///     application. Required format: &#x60;{attempts}/{timeLength}{timeUnit}&#x60;. &#x60;attempts&#x60; and &#x60;
        ///     timeunit&#x60; are mandatory and &#x60;timeLength&#x60; is optional with a default value of 1. &#x60;timeUnit&#x60;
        ///     is one of: &#x60;ms&#x60;, &#x60;s&#x60;, &#x60;m&#x60;, &#x60;h&#x60; or &#x60;d&#x60; representing milliseconds,
        ///     seconds, minutes, hours, and days respectively. Must not exceed one year, although much lower value is recommended.
        /// </summary>
        /// <value>
        ///     Overall number of requests over a specififed time period for generating a PIN and sending an SMS using a single
        ///     application. Required format: &#x60;{attempts}/{timeLength}{timeUnit}&#x60;. &#x60;attempts&#x60; and &#x60;
        ///     timeunit&#x60; are mandatory and &#x60;timeLength&#x60; is optional with a default value of 1. &#x60;timeUnit&#x60;
        ///     is one of: &#x60;ms&#x60;, &#x60;s&#x60;, &#x60;m&#x60;, &#x60;h&#x60; or &#x60;d&#x60; representing milliseconds,
        ///     seconds, minutes, hours, and days respectively. Must not exceed one year, although much lower value is recommended.
        /// </value>
        [DataMember(Name = "sendPinPerApplicationLimit", EmitDefaultValue = false)]
        public string SendPinPerApplicationLimit { get; set; }

        /// <summary>
        ///     Number of requests over a specififed time period for generating a PIN and sending an SMS to one phone number
        ///     (MSISDN). Required format: &#x60;{attempts}/{timeLength}{timeUnit}&#x60;. &#x60;attempts&#x60; and &#x60;timeunit
        ///     &#x60; are mandatory and &#x60;timeLength&#x60; is optional with a default value of 1. &#x60;timeUnit&#x60; is one
        ///     of: &#x60;ms&#x60;, &#x60;s&#x60;, &#x60;m&#x60;, &#x60;h&#x60; or &#x60;d&#x60; representing milliseconds,
        ///     seconds, minutes, hours, and days respectively. Must not exceed one year, although much lower value is recommended.
        /// </summary>
        /// <value>
        ///     Number of requests over a specififed time period for generating a PIN and sending an SMS to one phone number
        ///     (MSISDN). Required format: &#x60;{attempts}/{timeLength}{timeUnit}&#x60;. &#x60;attempts&#x60; and &#x60;timeunit
        ///     &#x60; are mandatory and &#x60;timeLength&#x60; is optional with a default value of 1. &#x60;timeUnit&#x60; is one
        ///     of: &#x60;ms&#x60;, &#x60;s&#x60;, &#x60;m&#x60;, &#x60;h&#x60; or &#x60;d&#x60; representing milliseconds,
        ///     seconds, minutes, hours, and days respectively. Must not exceed one year, although much lower value is recommended.
        /// </value>
        [DataMember(Name = "sendPinPerPhoneNumberLimit", EmitDefaultValue = false)]
        public string SendPinPerPhoneNumberLimit { get; set; }

        /// <summary>
        ///     The number of PIN verification requests over a specififed time period from one phone number (MSISDN). Required
        ///     format: &#x60;{attempts}/{timeLength}{timeUnit}&#x60;. &#x60;attempts&#x60; and &#x60;timeunit&#x60; are mandatory
        ///     and &#x60;timeLength&#x60; is optional with a default value of 1. &#x60;timeUnit&#x60; is one of: &#x60;ms&#x60;,
        ///     &#x60;s&#x60;, &#x60;m&#x60;, &#x60;h&#x60; or &#x60;d&#x60; representing milliseconds, seconds, minutes, hours,
        ///     and days respectively. Must not exceed one day, although much lower value is recommended.
        /// </summary>
        /// <value>
        ///     The number of PIN verification requests over a specififed time period from one phone number (MSISDN). Required
        ///     format: &#x60;{attempts}/{timeLength}{timeUnit}&#x60;. &#x60;attempts&#x60; and &#x60;timeunit&#x60; are mandatory
        ///     and &#x60;timeLength&#x60; is optional with a default value of 1. &#x60;timeUnit&#x60; is one of: &#x60;ms&#x60;,
        ///     &#x60;s&#x60;, &#x60;m&#x60;, &#x60;h&#x60; or &#x60;d&#x60; representing milliseconds, seconds, minutes, hours,
        ///     and days respectively. Must not exceed one day, although much lower value is recommended.
        /// </value>
        [DataMember(Name = "verifyPinLimit", EmitDefaultValue = false)]
        public string VerifyPinLimit { get; set; }

        /// <summary>
        ///     Returns true if TfaApplicationConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of TfaApplicationConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TfaApplicationConfiguration input)
        {
            if (input == null)
                return false;

            return
                (
                    AllowMultiplePinVerifications == input.AllowMultiplePinVerifications ||
                    AllowMultiplePinVerifications.Equals(input.AllowMultiplePinVerifications)
                ) &&
                (
                    PinAttempts == input.PinAttempts ||
                    PinAttempts.Equals(input.PinAttempts)
                ) &&
                (
                    PinTimeToLive == input.PinTimeToLive ||
                    (PinTimeToLive != null &&
                     PinTimeToLive.Equals(input.PinTimeToLive))
                ) &&
                (
                    SendPinPerApplicationLimit == input.SendPinPerApplicationLimit ||
                    (SendPinPerApplicationLimit != null &&
                     SendPinPerApplicationLimit.Equals(input.SendPinPerApplicationLimit))
                ) &&
                (
                    SendPinPerPhoneNumberLimit == input.SendPinPerPhoneNumberLimit ||
                    (SendPinPerPhoneNumberLimit != null &&
                     SendPinPerPhoneNumberLimit.Equals(input.SendPinPerPhoneNumberLimit))
                ) &&
                (
                    VerifyPinLimit == input.VerifyPinLimit ||
                    (VerifyPinLimit != null &&
                     VerifyPinLimit.Equals(input.VerifyPinLimit))
                );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TfaApplicationConfiguration {\n");
            sb.Append("  AllowMultiplePinVerifications: ").Append(AllowMultiplePinVerifications).Append("\n");
            sb.Append("  PinAttempts: ").Append(PinAttempts).Append("\n");
            sb.Append("  PinTimeToLive: ").Append(PinTimeToLive).Append("\n");
            sb.Append("  SendPinPerApplicationLimit: ").Append(SendPinPerApplicationLimit).Append("\n");
            sb.Append("  SendPinPerPhoneNumberLimit: ").Append(SendPinPerPhoneNumberLimit).Append("\n");
            sb.Append("  VerifyPinLimit: ").Append(VerifyPinLimit).Append("\n");
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
            return Equals(input as TfaApplicationConfiguration);
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
                hashCode = hashCode * 59 + AllowMultiplePinVerifications.GetHashCode();
                hashCode = hashCode * 59 + PinAttempts.GetHashCode();
                if (PinTimeToLive != null)
                    hashCode = hashCode * 59 + PinTimeToLive.GetHashCode();
                if (SendPinPerApplicationLimit != null)
                    hashCode = hashCode * 59 + SendPinPerApplicationLimit.GetHashCode();
                if (SendPinPerPhoneNumberLimit != null)
                    hashCode = hashCode * 59 + SendPinPerPhoneNumberLimit.GetHashCode();
                if (VerifyPinLimit != null)
                    hashCode = hashCode * 59 + VerifyPinLimit.GetHashCode();
                return hashCode;
            }
        }
    }
}