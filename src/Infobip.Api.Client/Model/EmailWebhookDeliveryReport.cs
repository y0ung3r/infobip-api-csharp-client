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
    ///     EmailWebhookDeliveryReport
    /// </summary>
    [DataContract(Name = "EmailWebhookDeliveryReport")]
    public class EmailWebhookDeliveryReport : IEquatable<EmailWebhookDeliveryReport>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmailWebhookDeliveryReport" /> class.
        /// </summary>
        /// <param name="bulkId">
        ///     The ID that uniquely identifies a list of email messages. This is either defined by user in the
        ///     request or auto generated..
        /// </param>
        /// <param name="messageId">The ID that uniquely identifies the email sent to the recipient..</param>
        /// <param name="to">Destination email address..</param>
        /// <param name="sentAt">Send date and time. Has the following format: &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="doneAt">Delivery date and time..</param>
        /// <param name="smsCount">The number of emails sent..</param>
        /// <param name="callbackData">Callback data sent through &#x60;callbackData&#x60; field in fully featured email..</param>
        /// <param name="price">price.</param>
        /// <param name="status">status.</param>
        /// <param name="error">error.</param>
        /// <param name="browserLink">
        ///     Contains the link to the HTML sent to recipient. This will be present only if the _view in
        ///     browser_ feature is used in the email. (*Please note that this feature is not activated automatically for Email
        ///     traffic sent over API. If you would like to utilize it please reach out to your Infobip person of contact.).
        /// </param>
        public EmailWebhookDeliveryReport(string bulkId = default, string messageId = default, string to = default,
            DateTimeOffset sentAt = default, DateTimeOffset doneAt = default, int smsCount = default,
            string callbackData = default, MessagePrice price = default, MessageStatus status = default,
            MessageError error = default, string browserLink = default)
        {
            BulkId = bulkId;
            MessageId = messageId;
            To = to;
            SentAt = sentAt;
            DoneAt = doneAt;
            SmsCount = smsCount;
            CallbackData = callbackData;
            Price = price;
            Status = status;
            Error = error;
            BrowserLink = browserLink;
        }

        /// <summary>
        ///     The ID that uniquely identifies a list of email messages. This is either defined by user in the request or auto
        ///     generated.
        /// </summary>
        /// <value>
        ///     The ID that uniquely identifies a list of email messages. This is either defined by user in the request or auto
        ///     generated.
        /// </value>
        [DataMember(Name = "bulkId", EmitDefaultValue = false)]
        public string BulkId { get; set; }

        /// <summary>
        ///     The ID that uniquely identifies the email sent to the recipient.
        /// </summary>
        /// <value>The ID that uniquely identifies the email sent to the recipient.</value>
        [DataMember(Name = "messageId", EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        ///     Destination email address.
        /// </summary>
        /// <value>Destination email address.</value>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        ///     Send date and time. Has the following format: &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>Send date and time. Has the following format: &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "sentAt", EmitDefaultValue = false)]
        public DateTimeOffset SentAt { get; set; }

        /// <summary>
        ///     Delivery date and time.
        /// </summary>
        /// <value>Delivery date and time.</value>
        [DataMember(Name = "doneAt", EmitDefaultValue = false)]
        public DateTimeOffset DoneAt { get; set; }

        /// <summary>
        ///     The number of emails sent.
        /// </summary>
        /// <value>The number of emails sent.</value>
        [DataMember(Name = "smsCount", EmitDefaultValue = false)]
        public int SmsCount { get; set; }

        /// <summary>
        ///     Callback data sent through &#x60;callbackData&#x60; field in fully featured email.
        /// </summary>
        /// <value>Callback data sent through &#x60;callbackData&#x60; field in fully featured email.</value>
        [DataMember(Name = "callbackData", EmitDefaultValue = false)]
        public string CallbackData { get; set; }

        /// <summary>
        ///     Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public MessagePrice Price { get; set; }

        /// <summary>
        ///     Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public MessageStatus Status { get; set; }

        /// <summary>
        ///     Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public MessageError Error { get; set; }

        /// <summary>
        ///     Contains the link to the HTML sent to recipient. This will be present only if the _view in browser_ feature is used
        ///     in the email. (*Please note that this feature is not activated automatically for Email traffic sent over API. If
        ///     you would like to utilize it please reach out to your Infobip person of contact.)
        /// </summary>
        /// <value>
        ///     Contains the link to the HTML sent to recipient. This will be present only if the _view in browser_ feature is
        ///     used in the email. (*Please note that this feature is not activated automatically for Email traffic sent over API.
        ///     If you would like to utilize it please reach out to your Infobip person of contact.)
        /// </value>
        [DataMember(Name = "browserLink", EmitDefaultValue = false)]
        public string BrowserLink { get; set; }

        /// <summary>
        ///     Returns true if EmailWebhookDeliveryReport instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailWebhookDeliveryReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailWebhookDeliveryReport input)
        {
            if (input == null)
                return false;

            return
                (
                    BulkId == input.BulkId ||
                    (BulkId != null &&
                     BulkId.Equals(input.BulkId))
                ) &&
                (
                    MessageId == input.MessageId ||
                    (MessageId != null &&
                     MessageId.Equals(input.MessageId))
                ) &&
                (
                    To == input.To ||
                    (To != null &&
                     To.Equals(input.To))
                ) &&
                (
                    SentAt == input.SentAt ||
                    (SentAt != null &&
                     SentAt.Equals(input.SentAt))
                ) &&
                (
                    DoneAt == input.DoneAt ||
                    (DoneAt != null &&
                     DoneAt.Equals(input.DoneAt))
                ) &&
                (
                    SmsCount == input.SmsCount ||
                    SmsCount.Equals(input.SmsCount)
                ) &&
                (
                    CallbackData == input.CallbackData ||
                    (CallbackData != null &&
                     CallbackData.Equals(input.CallbackData))
                ) &&
                (
                    Price == input.Price ||
                    (Price != null &&
                     Price.Equals(input.Price))
                ) &&
                (
                    Status == input.Status ||
                    (Status != null &&
                     Status.Equals(input.Status))
                ) &&
                (
                    Error == input.Error ||
                    (Error != null &&
                     Error.Equals(input.Error))
                ) &&
                (
                    BrowserLink == input.BrowserLink ||
                    (BrowserLink != null &&
                     BrowserLink.Equals(input.BrowserLink))
                );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailWebhookDeliveryReport {\n");
            sb.Append("  BulkId: ").Append(BulkId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  SentAt: ").Append(SentAt).Append("\n");
            sb.Append("  DoneAt: ").Append(DoneAt).Append("\n");
            sb.Append("  SmsCount: ").Append(SmsCount).Append("\n");
            sb.Append("  CallbackData: ").Append(CallbackData).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  BrowserLink: ").Append(BrowserLink).Append("\n");
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
            return Equals(input as EmailWebhookDeliveryReport);
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
                if (BulkId != null)
                    hashCode = hashCode * 59 + BulkId.GetHashCode();
                if (MessageId != null)
                    hashCode = hashCode * 59 + MessageId.GetHashCode();
                if (To != null)
                    hashCode = hashCode * 59 + To.GetHashCode();
                if (SentAt != null)
                    hashCode = hashCode * 59 + SentAt.GetHashCode();
                if (DoneAt != null)
                    hashCode = hashCode * 59 + DoneAt.GetHashCode();
                hashCode = hashCode * 59 + SmsCount.GetHashCode();
                if (CallbackData != null)
                    hashCode = hashCode * 59 + CallbackData.GetHashCode();
                if (Price != null)
                    hashCode = hashCode * 59 + Price.GetHashCode();
                if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                if (BrowserLink != null)
                    hashCode = hashCode * 59 + BrowserLink.GetHashCode();
                return hashCode;
            }
        }
    }
}