/*
 * Infobip Client API Libraries OpenAPI Specification
 * OpenAPI specification containing public endpoints supported in client API libraries.
 *
 * Contact: support@infobip.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit the class manually.
 */


using System.Threading;
using System.Threading.Tasks;

namespace Infobip.Api.Client
{
    /// <summary>
    ///     Contract for Asynchronous RESTful API interactions.
    ///     This interface allows consumers to provide a custom API accessor client.
    /// </summary>
    public interface IAsynchronousClient
    {
        /// <summary>
        ///     Executes a non-blocking call to some <paramref name="path" /> using the DELETE http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}" /></returns>
        Task<ApiResponse<T>> DeleteAsync<T>(string path, RequestOptions options,
            IReadableConfiguration configuration = null, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Executes a non-blocking call to some <paramref name="path" /> using the GET http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}" /></returns>
        Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options,
            IReadableConfiguration configuration = null, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Executes a non-blocking call to some <paramref name="path" /> using the HEAD http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}" /></returns>
        Task<ApiResponse<T>> HeadAsync<T>(string path, RequestOptions options,
            IReadableConfiguration configuration = null, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Executes a non-blocking call to some <paramref name="path" /> using the OPTIONS http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}" /></returns>
        Task<ApiResponse<T>> OptionsAsync<T>(string path, RequestOptions options,
            IReadableConfiguration configuration = null, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Executes a non-blocking call to some <paramref name="path" /> using the POST http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}" /></returns>
        Task<ApiResponse<T>> PostAsync<T>(string path, RequestOptions options,
            IReadableConfiguration configuration = null, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Executes a non-blocking call to some <paramref name="path" /> using the PATCH http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}" /></returns>
        Task<ApiResponse<T>> PatchAsync<T>(string path, RequestOptions options,
            IReadableConfiguration configuration = null, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Executes a non-blocking call to some <paramref name="path" /> using the PUT http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <param name="configuration">Per-request configurable settings.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>A task eventually representing the response data, decorated with <see cref="ApiResponse{T}" /></returns>
        Task<ApiResponse<T>> PutAsync<T>(string path, RequestOptions options,
            IReadableConfiguration configuration = null, CancellationToken cancellationToken = default);
    }
}