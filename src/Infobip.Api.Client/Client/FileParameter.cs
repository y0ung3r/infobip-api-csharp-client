/*
 * Infobip Client API Libraries OpenAPI Specification
 * OpenAPI specification containing public endpoints supported in client API libraries.
 *
 * Contact: support@infobip.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit the class manually.
 */


using System.IO;

namespace Infobip.Api.Client.Client
{
    /// <summary>
    ///     Represents a File passed to the API as a Parameter, allows using different backends for files
    /// </summary>
    public class FileParameter
    {
        /// <summary>
        ///     Construct a FileParameter just from the contents, will extract the filename from a filestream
        /// </summary>
        /// <param name="content"> The file content </param>
        public FileParameter(Stream content)
        {
            if (content is FileStream fs)
                Name = Path.GetFileName(fs.Name);

            Content = content;
        }

        /// <summary>
        ///     Construct a FileParameter from name and content
        /// </summary>
        /// <param name="filename">The filename</param>
        /// <param name="content">The file content</param>
        public FileParameter(string filename, Stream content)
        {
            Content = content;
            Name = filename;
        }

        /// <summary>
        ///     Construct a FileParameter from name and content
        /// </summary>
        /// <param name="filename">The filename</param>
        /// <param name="contentType">The content type of the file</param>
        /// <param name="content">The file content</param>
        public FileParameter(string filename, string contentType, Stream content)
        {
            Content = content;
            ContentType = contentType;
            Name = filename;
        }

        /// <summary>
        ///     The content of the file
        /// </summary>
        public Stream Content { get; set; }

        /// <summary>
        ///     The content type of the file
        /// </summary>
        public string ContentType { get; set; } = "application/octet-stream";

        /// <summary>
        ///     The filename
        /// </summary>
        public string Name { get; set; } = "no_name_provided";

        /// <summary>
        ///     Implicit conversion of stream to file parameter. Useful for backwards compatibility.
        /// </summary>
        /// <param name="s">Stream to convert</param>
        /// <returns>FileParameter</returns>
        public static implicit operator FileParameter(Stream s)
        {
            return new FileParameter(s);
        }
    }
}