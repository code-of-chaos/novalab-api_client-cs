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
    public interface ITwitchManagedRewardApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResult</returns>
        ApiResult GetManagedRewards(string userId, int? limit = default(int?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiResult</returns>
        ApiResponse<ApiResult> GetManagedRewardsWithHttpInfo(string userId, int? limit = default(int?), int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="createCustomRewardsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TwitchManagedRewardApiResult</returns>
        TwitchManagedRewardApiResult PostManagedReward(string userId, CreateCustomRewardsRequest? createCustomRewardsRequest = default(CreateCustomRewardsRequest?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="createCustomRewardsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TwitchManagedRewardApiResult</returns>
        ApiResponse<TwitchManagedRewardApiResult> PostManagedRewardWithHttpInfo(string userId, CreateCustomRewardsRequest? createCustomRewardsRequest = default(CreateCustomRewardsRequest?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITwitchManagedRewardApiAsync : IApiAccessor
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
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResult</returns>
        System.Threading.Tasks.Task<ApiResult> GetManagedRewardsAsync(string userId, int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResult>> GetManagedRewardsWithHttpInfoAsync(string userId, int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="createCustomRewardsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TwitchManagedRewardApiResult</returns>
        System.Threading.Tasks.Task<TwitchManagedRewardApiResult> PostManagedRewardAsync(string userId, CreateCustomRewardsRequest? createCustomRewardsRequest = default(CreateCustomRewardsRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="createCustomRewardsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TwitchManagedRewardApiResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<TwitchManagedRewardApiResult>> PostManagedRewardWithHttpInfoAsync(string userId, CreateCustomRewardsRequest? createCustomRewardsRequest = default(CreateCustomRewardsRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITwitchManagedRewardApi : ITwitchManagedRewardApiSync, ITwitchManagedRewardApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TwitchManagedRewardApi : ITwitchManagedRewardApi
    {
        private NovaLab.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TwitchManagedRewardApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TwitchManagedRewardApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwitchManagedRewardApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TwitchManagedRewardApi(string basePath)
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
        /// Initializes a new instance of the <see cref="TwitchManagedRewardApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TwitchManagedRewardApi(NovaLab.ApiClient.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="TwitchManagedRewardApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TwitchManagedRewardApi(NovaLab.ApiClient.Client.ISynchronousClient client, NovaLab.ApiClient.Client.IAsynchronousClient asyncClient, NovaLab.ApiClient.Client.IReadableConfiguration configuration)
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
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResult</returns>
        public ApiResult GetManagedRewards(string userId, int? limit = default(int?), int operationIndex = 0)
        {
            NovaLab.ApiClient.Client.ApiResponse<ApiResult> localVarResponse = GetManagedRewardsWithHttpInfo(userId, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiResult</returns>
        public NovaLab.ApiClient.Client.ApiResponse<ApiResult> GetManagedRewardsWithHttpInfo(string userId, int? limit = default(int?), int operationIndex = 0)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new NovaLab.ApiClient.Client.ApiException(400, "Missing required parameter 'userId' when calling TwitchManagedRewardApi->GetManagedRewards");
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
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(NovaLab.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }

            localVarRequestOptions.Operation = "TwitchManagedRewardApi.GetManagedRewards";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<ApiResult>("/api/{userId}/twitch/managed-rewards", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetManagedRewards", localVarResponse);
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
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResult</returns>
        public async System.Threading.Tasks.Task<ApiResult> GetManagedRewardsAsync(string userId, int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NovaLab.ApiClient.Client.ApiResponse<ApiResult> localVarResponse = await GetManagedRewardsWithHttpInfoAsync(userId, limit, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiResult)</returns>
        public async System.Threading.Tasks.Task<NovaLab.ApiClient.Client.ApiResponse<ApiResult>> GetManagedRewardsWithHttpInfoAsync(string userId, int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new NovaLab.ApiClient.Client.ApiException(400, "Missing required parameter 'userId' when calling TwitchManagedRewardApi->GetManagedRewards");
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
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(NovaLab.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }

            localVarRequestOptions.Operation = "TwitchManagedRewardApi.GetManagedRewards";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApiResult>("/api/{userId}/twitch/managed-rewards", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetManagedRewards", localVarResponse);
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
        /// <param name="createCustomRewardsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TwitchManagedRewardApiResult</returns>
        public TwitchManagedRewardApiResult PostManagedReward(string userId, CreateCustomRewardsRequest? createCustomRewardsRequest = default(CreateCustomRewardsRequest?), int operationIndex = 0)
        {
            NovaLab.ApiClient.Client.ApiResponse<TwitchManagedRewardApiResult> localVarResponse = PostManagedRewardWithHttpInfo(userId, createCustomRewardsRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="createCustomRewardsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TwitchManagedRewardApiResult</returns>
        public NovaLab.ApiClient.Client.ApiResponse<TwitchManagedRewardApiResult> PostManagedRewardWithHttpInfo(string userId, CreateCustomRewardsRequest? createCustomRewardsRequest = default(CreateCustomRewardsRequest?), int operationIndex = 0)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new NovaLab.ApiClient.Client.ApiException(400, "Missing required parameter 'userId' when calling TwitchManagedRewardApi->PostManagedReward");
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
            localVarRequestOptions.Data = createCustomRewardsRequest;

            localVarRequestOptions.Operation = "TwitchManagedRewardApi.PostManagedReward";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<TwitchManagedRewardApiResult>("/api/{userId}/twitch/managed-rewards", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostManagedReward", localVarResponse);
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
        /// <param name="createCustomRewardsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TwitchManagedRewardApiResult</returns>
        public async System.Threading.Tasks.Task<TwitchManagedRewardApiResult> PostManagedRewardAsync(string userId, CreateCustomRewardsRequest? createCustomRewardsRequest = default(CreateCustomRewardsRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            NovaLab.ApiClient.Client.ApiResponse<TwitchManagedRewardApiResult> localVarResponse = await PostManagedRewardWithHttpInfoAsync(userId, createCustomRewardsRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NovaLab.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="createCustomRewardsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TwitchManagedRewardApiResult)</returns>
        public async System.Threading.Tasks.Task<NovaLab.ApiClient.Client.ApiResponse<TwitchManagedRewardApiResult>> PostManagedRewardWithHttpInfoAsync(string userId, CreateCustomRewardsRequest? createCustomRewardsRequest = default(CreateCustomRewardsRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new NovaLab.ApiClient.Client.ApiException(400, "Missing required parameter 'userId' when calling TwitchManagedRewardApi->PostManagedReward");
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
            localVarRequestOptions.Data = createCustomRewardsRequest;

            localVarRequestOptions.Operation = "TwitchManagedRewardApi.PostManagedReward";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<TwitchManagedRewardApiResult>("/api/{userId}/twitch/managed-rewards", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostManagedReward", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
