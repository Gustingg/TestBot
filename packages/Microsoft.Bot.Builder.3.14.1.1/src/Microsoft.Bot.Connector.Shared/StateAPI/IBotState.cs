// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Connector
{
    using Microsoft.Rest;
    
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// BotState operations.
    /// </summary>
    public partial interface IBotState
    {
        /// <summary>
        /// GetUserData
        /// </summary>
        /// <remarks>
        /// Get a bots data for the user across all conversations
        /// </remarks>
        /// <param name='channelId'>
        /// channelId
        /// </param>
        /// <param name='userId'>
        /// id for the user on the channel
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete()]
        Task<HttpOperationResponse<BotData>> GetUserDataWithHttpMessagesAsync(string channelId, string userId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// SetUserData
        /// </summary>
        /// <remarks>
        /// Update the bot's data for a user
        /// </remarks>
        /// <param name='channelId'>
        /// channelId
        /// </param>
        /// <param name='userId'>
        /// id for the user on the channel
        /// </param>
        /// <param name='botData'>
        /// the new botdata
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete()]
        Task<HttpOperationResponse<BotData>> SetUserDataWithHttpMessagesAsync(string channelId, string userId, BotData botData, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// DeleteStateForUser
        /// </summary>
        /// <remarks>
        /// Delete all data for a user in a channel (UserData and
        /// PrivateConversationData)
        /// </remarks>
        /// <param name='channelId'>
        /// channelId
        /// </param>
        /// <param name='userId'>
        /// id for the user on the channel
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete()]
        Task<HttpOperationResponse<IList<string>>> DeleteStateForUserWithHttpMessagesAsync(string channelId, string userId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// GetConversationData
        /// </summary>
        /// <remarks>
        /// get the bots data for all users in a conversation
        /// </remarks>
        /// <param name='channelId'>
        /// the channelId
        /// </param>
        /// <param name='conversationId'>
        /// The id for the conversation on the channel
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete()]
        Task<HttpOperationResponse<BotData>> GetConversationDataWithHttpMessagesAsync(string channelId, string conversationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// SetConversationData
        /// </summary>
        /// <remarks>
        /// Update the bot's data for all users in a conversation
        /// </remarks>
        /// <param name='channelId'>
        /// channelId
        /// </param>
        /// <param name='conversationId'>
        /// The id for the conversation on the channel
        /// </param>
        /// <param name='botData'>
        /// the new botdata
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete()]
        Task<HttpOperationResponse<BotData>> SetConversationDataWithHttpMessagesAsync(string channelId, string conversationId, BotData botData, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// GetPrivateConversationData
        /// </summary>
        /// <remarks>
        /// get bot's data for a single user in a conversation
        /// </remarks>
        /// <param name='channelId'>
        /// channelId
        /// </param>
        /// <param name='conversationId'>
        /// The id for the conversation on the channel
        /// </param>
        /// <param name='userId'>
        /// id for the user on the channel
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete()]
        Task<HttpOperationResponse<BotData>> GetPrivateConversationDataWithHttpMessagesAsync(string channelId, string conversationId, string userId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// SetPrivateConversationData
        /// </summary>
        /// <remarks>
        /// Update the bot's data for a single user in a conversation
        /// </remarks>
        /// <param name='channelId'>
        /// channelId
        /// </param>
        /// <param name='conversationId'>
        /// The id for the conversation on the channel
        /// </param>
        /// <param name='userId'>
        /// id for the user on the channel
        /// </param>
        /// <param name='botData'>
        /// the new botdata
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete()]
        Task<HttpOperationResponse<BotData>> SetPrivateConversationDataWithHttpMessagesAsync(string channelId, string conversationId, string userId, BotData botData, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}