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

namespace Infobip.Api.Client
{
    /// <summary>
    ///     API Exception
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ApiException" /> class.
        /// </summary>
        public ApiException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApiException" /> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        public ApiException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApiException" /> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorContent">Error content.</param>
        /// <param name="headers">HTTP Headers.</param>
        public ApiException(int errorCode, string message, object errorContent = null,
            Multimap<string, string> headers = null) : base(message)
        {
            ErrorCode = errorCode;
            ErrorContent = errorContent;
            Headers = headers;
        }

        /// <summary>
        ///     Gets or sets the error code (HTTP status code).
        /// </summary>
        /// <value>The error code (HTTP status code).</value>
        public int ErrorCode { get; set; }

        /// <summary>
        ///     Gets or sets the error content (body json object).
        /// </summary>
        /// <value>The error content (Http response body).</value>
        public object ErrorContent { get; }

        /// <summary>
        ///     Gets or sets the HTTP headers.
        /// </summary>
        /// <value>HTTP headers</value>
        public Multimap<string, string> Headers { get; }
    }
}