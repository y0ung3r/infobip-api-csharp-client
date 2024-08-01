/*
 * Infobip Client API Libraries OpenAPI Specification
 * OpenAPI specification containing public endpoints supported in client API libraries.
 *
 * Contact: support@infobip.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit the class manually.
 */


using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Infobip.Api.Client
{
    /// <summary>
    ///     A container for generalized request inputs. This type allows consumers to extend the request functionality
    ///     by abstracting away from the default (built-in) request framework (e.g. RestSharp).
    /// </summary>
    public class RequestOptions
    {
        /// <summary>
        ///     Constructs a new instance of <see cref="RequestOptions" />
        /// </summary>
        public RequestOptions()
        {
            Cookies = new List<Cookie>();
            FileParameters = new Dictionary<string, Stream>();
            FormParameters = new Dictionary<string, string>();
            HeaderParameters = new Multimap<string, string>();
            PathParameters = new Dictionary<string, string>();
            QueryParameters = new Multimap<string, string>();
        }

        /// <summary>
        ///     Cookies to be sent along with the request.
        /// </summary>
        public IEnumerable<Cookie> Cookies { get; set; }

        /// <summary>
        ///     Any data associated with a request body.
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        ///     File parameters to be sent along with the request.
        /// </summary>
        public IDictionary<string, Stream> FileParameters { get; set; }

        /// <summary>
        ///     Form parameters to be sent along with the request.
        /// </summary>
        public IDictionary<string, string> FormParameters { get; set; }

        /// <summary>
        ///     Header parameters to be applied to to the request.
        ///     Keys may have 1 or more values associated.
        /// </summary>
        public Multimap<string, string> HeaderParameters { get; set; }

        /// <summary>
        ///     Parameters to be bound to path parts of the Request's URL.
        /// </summary>
        public IDictionary<string, string> PathParameters { get; set; }

        /// <summary>
        ///     Query parameters to be applied to the request.
        ///     Keys may have 1 or more values associated.
        /// </summary>
        public Multimap<string, string> QueryParameters { get; set; }
    }
}