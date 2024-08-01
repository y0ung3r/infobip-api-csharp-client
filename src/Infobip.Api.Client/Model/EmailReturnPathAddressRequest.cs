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
    ///     EmailReturnPathAddressRequest
    /// </summary>
    [DataContract(Name = "EmailReturnPathAddressRequest")]
    public class EmailReturnPathAddressRequest : IEquatable<EmailReturnPathAddressRequest>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmailReturnPathAddressRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailReturnPathAddressRequest()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="EmailReturnPathAddressRequest" /> class.
        /// </summary>
        /// <param name="returnPathAddress">
        ///     Mailbox for return path, this mailbox should be based on the same domain. If you want
        ///     to disable custom return path and use our default return path address set the value to an empty string. (required).
        /// </param>
        public EmailReturnPathAddressRequest(string returnPathAddress = default)
        {
            // to ensure "returnPathAddress" is required (not null)
            ReturnPathAddress = returnPathAddress ?? throw new ArgumentNullException("returnPathAddress");
        }

        /// <summary>
        ///     Mailbox for return path, this mailbox should be based on the same domain. If you want to disable custom return path
        ///     and use our default return path address set the value to an empty string.
        /// </summary>
        /// <value>
        ///     Mailbox for return path, this mailbox should be based on the same domain. If you want to disable custom return
        ///     path and use our default return path address set the value to an empty string.
        /// </value>
        [DataMember(Name = "returnPathAddress", IsRequired = true, EmitDefaultValue = false)]
        public string ReturnPathAddress { get; set; }

        /// <summary>
        ///     Returns true if EmailReturnPathAddressRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailReturnPathAddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailReturnPathAddressRequest input)
        {
            if (input == null)
                return false;

            return
                ReturnPathAddress == input.ReturnPathAddress ||
                (ReturnPathAddress != null &&
                 ReturnPathAddress.Equals(input.ReturnPathAddress));
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailReturnPathAddressRequest {\n");
            sb.Append("  ReturnPathAddress: ").Append(ReturnPathAddress).Append("\n");
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
            return Equals(input as EmailReturnPathAddressRequest);
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
                if (ReturnPathAddress != null)
                    hashCode = hashCode * 59 + ReturnPathAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}