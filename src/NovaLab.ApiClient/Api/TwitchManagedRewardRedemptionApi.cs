/*
 * NovaLab API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace NovaLab.ApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITwitchManagedRewardRedemptionApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="rewardId"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TwitchManagedRewardRedemptionApiResult</returns>
        TwitchManagedRewardRedemptionApiResult GetRedemptions(string userId, Guid? rewardId = default(Guid?), DateTime? after = default(DateTime?), int? limit = default(int?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="rewardId"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TwitchManagedRewardRedemptionApiResult</returns>
        ApiResponse<TwitchManagedRewardRedemptionApiResult> GetRedemptionsWithHttpInfo(string userId, Guid? rewardId = default(Guid?), DateTime? after = default(DateTime?), int? limit = default(int?), int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="twitchManagedRewardRedemptionDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResult</returns>
        ApiResult PostRedemption(string userId, TwitchManagedRewardRedemptionDto? twitchManagedRewardRedemptionDto = default(TwitchManagedRewardRedemptionDto?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="twitchManagedRewardRedemptionDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiResult</returns>
        ApiResponse<ApiResult> PostRedemptionWithHttpInfo(string userId, TwitchManagedRewardRedemptionDto? twitchManagedRewardRedemptionDto = default(TwitchManagedRewardRedemptionDto?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITwitchManagedRewardRedemptionApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="rewardId"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TwitchManagedRewardRedemptionApiResult</returns>
        System.Threading.Tasks.Task<TwitchManagedRewardRedemptionApiResult> GetRedemptionsAsync(string userId, Guid? rewardId = default(Guid?), DateTime? after = default(DateTime?), int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="rewardId"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TwitchManagedRewardRedemptionApiResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<TwitchManagedRewardRedemptionApiResult>> GetRedemptionsWithHttpInfoAsync(string userId, Guid? rewardId = default(Guid?), DateTime? after = default(DateTime?), int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="twitchManagedRewardRedemptionDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResult</returns>
        System.Threading.Tasks.Task<ApiResult> PostRedemptionAsync(string userId, TwitchManagedRewardRedemptionDto? twitchManagedRewardRedemptionDto = default(TwitchManagedRewardRedemptionDto?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="twitchManagedRewardRedemptionDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResult>> PostRedemptionWithHttpInfoAsync(string userId, TwitchManagedRewardRedemptionDto? twitchManagedRewardRedemptionDto = default(TwitchManagedRewardRedemptionDto?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITwitchManagedRewardRedemptionApi : ITwitchManagedRewardRedemptionApiSync, ITwitchManagedRewardRedemptionApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TwitchManagedRewardRedemptionApi : ITwitchManagedRewardRedemptionApi
    {
        private NovaLab.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TwitchManagedRewardRedemptionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TwitchManagedRewardRedemptionApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwitchManagedRewardRedemptionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TwitchManagedRewardRedemptionApi(string basePath)
        {
            this.Configuration = NovaLab.ApiClient.Client.Configuration.MergeConfigurations(
                NovaLab.ApiClient.Client.GlobalConfiguration.Instance,
                new NovaLab.ApiClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new NovaLab.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new NovaLab.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = NovaLab.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwitchManagedRewardRedemptionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TwitchManagedRewardRedemptionApi(NovaLab.ApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = NovaLab.ApiClient.Client.Configuration.MergeConfigurations(
                NovaLab.ApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new NovaLab.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new NovaLab.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = NovaLab.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwitchManagedRewardRedemptionApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TwitchManagedRewardRedemptionApi(NovaLab.ApiClient.Client.ISynchronousClient client, NovaLab.ApiClient.Client.IAsynchronousClient asyncClient, NovaLab.ApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = NovaLab.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public NovaLab.ApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public NovaLab.ApiClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public NovaLab.ApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public NovaLab.ApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="rewardId"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TwitchManagedRewardRedemptionApiResult</returns>
        public TwitchManagedRewardRedemptionApiResult GetRedemptions(string userId, Guid? rewardId = default(Guid?), DateTime? after = default(DateTime?), int? limit = default(int?), int operationIndex = 0)
        {
            NovaLab.ApiClient.Client.ApiResponse<TwitchManagedRewardRedemptionApiResult> localVarResponse = GetRedemptionsWithHttpInfo(userId, rewardId, after, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="rewardId"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TwitchManagedRewardRedemptionApiResult</returns>
        public NovaLab.ApiClient.Client.ApiResponse<TwitchManagedRewardRedemptionApiResult> GetRedemptionsWithHttpInfo(string userId, Guid? rewardId = default(Guid?), DateTime? after = default(DateTime?), int? limit = default(int?), int operationIndex = 0)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new NovaLab.ApiClient.Client.ApiException(400, "Missing required parameter 'userId' when calling TwitchManagedRewardRedemptionApi->GetRedemptions");
            }

            NovaLab.ApiClient.Client.RequestOptions localVarRequestOptions = new NovaLab.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = NovaLab.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = NovaLab.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("userId", NovaLab.ApiClient.Client.ClientUtils.ParameterToString(userId)); // path parameter
            if (rewardId != null)
            {
                localVarRequestOptions.QueryParameters.Add(NovaLab.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "reward-id", rewardId));
            }
            if (after != null)
            {
                localVarRequestOptions.QueryParameters.Add(NovaLab.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "after", after));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(NovaLab.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }

            localVarRequestOptions.Operation = "TwitchManagedRewardRedemptionApi.GetRedemptions";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<TwitchManagedRewardRedemptionApiResult>("/api/{userId}/twitch/managed-rewards-redemptions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRedemptions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="rewardId"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TwitchManagedRewardRedemptionApiResult</returns>
        public async System.Threading.Tasks.Task<TwitchManagedRewardRedemptionApiResult> GetRedemptionsAsync(string userId, Guid? rewardId = default(Guid?), DateTime? after = default(DateTime?), int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NovaLab.ApiClient.Client.ApiResponse<TwitchManagedRewardRedemptionApiResult> localVarResponse = await GetRedemptionsWithHttpInfoAsync(userId, rewardId, after, limit, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="rewardId"> (optional)</param>
        /// <param name="after"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TwitchManagedRewardRedemptionApiResult)</returns>
        public async System.Threading.Tasks.Task<NovaLab.ApiClient.Client.ApiResponse<TwitchManagedRewardRedemptionApiResult>> GetRedemptionsWithHttpInfoAsync(string userId, Guid? rewardId = default(Guid?), DateTime? after = default(DateTime?), int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new NovaLab.ApiClient.Client.ApiException(400, "Missing required parameter 'userId' when calling TwitchManagedRewardRedemptionApi->GetRedemptions");
            }


            NovaLab.ApiClient.Client.RequestOptions localVarRequestOptions = new NovaLab.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = NovaLab.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = NovaLab.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("userId", NovaLab.ApiClient.Client.ClientUtils.ParameterToString(userId)); // path parameter
            if (rewardId != null)
            {
                localVarRequestOptions.QueryParameters.Add(NovaLab.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "reward-id", rewardId));
            }
            if (after != null)
            {
                localVarRequestOptions.QueryParameters.Add(NovaLab.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "after", after));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(NovaLab.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }

            localVarRequestOptions.Operation = "TwitchManagedRewardRedemptionApi.GetRedemptions";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<TwitchManagedRewardRedemptionApiResult>("/api/{userId}/twitch/managed-rewards-redemptions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRedemptions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="twitchManagedRewardRedemptionDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResult</returns>
        public ApiResult PostRedemption(string userId, TwitchManagedRewardRedemptionDto? twitchManagedRewardRedemptionDto = default(TwitchManagedRewardRedemptionDto?), int operationIndex = 0)
        {
            NovaLab.ApiClient.Client.ApiResponse<ApiResult> localVarResponse = PostRedemptionWithHttpInfo(userId, twitchManagedRewardRedemptionDto);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="twitchManagedRewardRedemptionDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiResult</returns>
        public NovaLab.ApiClient.Client.ApiResponse<ApiResult> PostRedemptionWithHttpInfo(string userId, TwitchManagedRewardRedemptionDto? twitchManagedRewardRedemptionDto = default(TwitchManagedRewardRedemptionDto?), int operationIndex = 0)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new NovaLab.ApiClient.Client.ApiException(400, "Missing required parameter 'userId' when calling TwitchManagedRewardRedemptionApi->PostRedemption");
            }

            NovaLab.ApiClient.Client.RequestOptions localVarRequestOptions = new NovaLab.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = NovaLab.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = NovaLab.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("userId", NovaLab.ApiClient.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.Data = twitchManagedRewardRedemptionDto;

            localVarRequestOptions.Operation = "TwitchManagedRewardRedemptionApi.PostRedemption";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<ApiResult>("/api/{userId}/twitch/managed-rewards-redemptions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostRedemption", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="twitchManagedRewardRedemptionDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResult</returns>
        public async System.Threading.Tasks.Task<ApiResult> PostRedemptionAsync(string userId, TwitchManagedRewardRedemptionDto? twitchManagedRewardRedemptionDto = default(TwitchManagedRewardRedemptionDto?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NovaLab.ApiClient.Client.ApiResponse<ApiResult> localVarResponse = await PostRedemptionWithHttpInfoAsync(userId, twitchManagedRewardRedemptionDto, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="twitchManagedRewardRedemptionDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiResult)</returns>
        public async System.Threading.Tasks.Task<NovaLab.ApiClient.Client.ApiResponse<ApiResult>> PostRedemptionWithHttpInfoAsync(string userId, TwitchManagedRewardRedemptionDto? twitchManagedRewardRedemptionDto = default(TwitchManagedRewardRedemptionDto?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new NovaLab.ApiClient.Client.ApiException(400, "Missing required parameter 'userId' when calling TwitchManagedRewardRedemptionApi->PostRedemption");
            }


            NovaLab.ApiClient.Client.RequestOptions localVarRequestOptions = new NovaLab.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = NovaLab.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = NovaLab.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("userId", NovaLab.ApiClient.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.Data = twitchManagedRewardRedemptionDto;

            localVarRequestOptions.Operation = "TwitchManagedRewardRedemptionApi.PostRedemption";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ApiResult>("/api/{userId}/twitch/managed-rewards-redemptions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostRedemption", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
