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
    ///     Region-specific parameters, often imposed by local laws. Use this, if country or region that you are sending an SMS
    ///     to requires additional information.
    /// </summary>
    [DataContract(Name = "SmsRegionalOptions")]
    public class SmsRegionalOptions : IEquatable<SmsRegionalOptions>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SmsRegionalOptions" /> class.
        /// </summary>
        /// <param name="indiaDlt">indiaDlt.</param>
        /// <param name="turkeyIys">turkeyIys.</param>
        /// <param name="southKorea">southKorea.</param>
        public SmsRegionalOptions(SmsIndiaDltOptions indiaDlt = default, SmsTurkeyIysOptions turkeyIys = default,
            SmsSouthKoreaOptions southKorea = default)
        {
            IndiaDlt = indiaDlt;
            TurkeyIys = turkeyIys;
            SouthKorea = southKorea;
        }

        /// <summary>
        ///     Gets or Sets IndiaDlt
        /// </summary>
        [DataMember(Name = "indiaDlt", EmitDefaultValue = false)]
        public SmsIndiaDltOptions IndiaDlt { get; set; }

        /// <summary>
        ///     Gets or Sets TurkeyIys
        /// </summary>
        [DataMember(Name = "turkeyIys", EmitDefaultValue = false)]
        public SmsTurkeyIysOptions TurkeyIys { get; set; }

        /// <summary>
        ///     Gets or Sets SouthKorea
        /// </summary>
        [DataMember(Name = "southKorea", EmitDefaultValue = false)]
        public SmsSouthKoreaOptions SouthKorea { get; set; }

        /// <summary>
        ///     Returns true if SmsRegionalOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsRegionalOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsRegionalOptions input)
        {
            if (input == null)
                return false;

            return
                (
                    IndiaDlt == input.IndiaDlt ||
                    (IndiaDlt != null &&
                     IndiaDlt.Equals(input.IndiaDlt))
                ) &&
                (
                    TurkeyIys == input.TurkeyIys ||
                    (TurkeyIys != null &&
                     TurkeyIys.Equals(input.TurkeyIys))
                ) &&
                (
                    SouthKorea == input.SouthKorea ||
                    (SouthKorea != null &&
                     SouthKorea.Equals(input.SouthKorea))
                );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsRegionalOptions {\n");
            sb.Append("  IndiaDlt: ").Append(IndiaDlt).Append("\n");
            sb.Append("  TurkeyIys: ").Append(TurkeyIys).Append("\n");
            sb.Append("  SouthKorea: ").Append(SouthKorea).Append("\n");
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
            return Equals(input as SmsRegionalOptions);
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
                if (IndiaDlt != null)
                    hashCode = hashCode * 59 + IndiaDlt.GetHashCode();
                if (TurkeyIys != null)
                    hashCode = hashCode * 59 + TurkeyIys.GetHashCode();
                if (SouthKorea != null)
                    hashCode = hashCode * 59 + SouthKorea.GetHashCode();
                return hashCode;
            }
        }
    }
}