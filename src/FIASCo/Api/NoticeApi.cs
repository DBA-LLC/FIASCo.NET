/*
 * SPAS API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using FIASCo.Client;
using FIASCo.Model;

namespace FIASCo.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INoticeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Добавление уведомления
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="notice"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AddNoticeResult</returns>
        AddNoticeResult ApiSpasV20AddNoticePost(Notice notice = default(Notice), int operationIndex = 0);

        /// <summary>
        /// Добавление уведомления
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="notice"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AddNoticeResult</returns>
        ApiResponse<AddNoticeResult> ApiSpasV20AddNoticePostWithHttpInfo(Notice notice = default(Notice), int operationIndex = 0);
        /// <summary>
        /// Получение списка уведомлений по условию
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticeFilterObject"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>NoticeItemsResult</returns>
        NoticeItemsResult ApiSpasV20GetNoticeItemsPost(NoticeFilterObject noticeFilterObject = default(NoticeFilterObject), int operationIndex = 0);

        /// <summary>
        /// Получение списка уведомлений по условию
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticeFilterObject"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of NoticeItemsResult</returns>
        ApiResponse<NoticeItemsResult> ApiSpasV20GetNoticeItemsPostWithHttpInfo(NoticeFilterObject noticeFilterObject = default(NoticeFilterObject), int operationIndex = 0);
        /// <summary>
        /// Получение статуса обработки уведомления
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetNoticeStatusResult</returns>
        GetNoticeStatusResult ApiSpasV20GetNoticeStatusGet(long? id = default(long?), int operationIndex = 0);

        /// <summary>
        /// Получение статуса обработки уведомления
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetNoticeStatusResult</returns>
        ApiResponse<GetNoticeStatusResult> ApiSpasV20GetNoticeStatusGetWithHttpInfo(long? id = default(long?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INoticeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Добавление уведомления
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="notice"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddNoticeResult</returns>
        System.Threading.Tasks.Task<AddNoticeResult> ApiSpasV20AddNoticePostAsync(Notice notice = default(Notice), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Добавление уведомления
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="notice"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddNoticeResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddNoticeResult>> ApiSpasV20AddNoticePostWithHttpInfoAsync(Notice notice = default(Notice), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Получение списка уведомлений по условию
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticeFilterObject"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of NoticeItemsResult</returns>
        System.Threading.Tasks.Task<NoticeItemsResult> ApiSpasV20GetNoticeItemsPostAsync(NoticeFilterObject noticeFilterObject = default(NoticeFilterObject), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Получение списка уведомлений по условию
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticeFilterObject"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (NoticeItemsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<NoticeItemsResult>> ApiSpasV20GetNoticeItemsPostWithHttpInfoAsync(NoticeFilterObject noticeFilterObject = default(NoticeFilterObject), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Получение статуса обработки уведомления
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetNoticeStatusResult</returns>
        System.Threading.Tasks.Task<GetNoticeStatusResult> ApiSpasV20GetNoticeStatusGetAsync(long? id = default(long?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Получение статуса обработки уведомления
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetNoticeStatusResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetNoticeStatusResult>> ApiSpasV20GetNoticeStatusGetWithHttpInfoAsync(long? id = default(long?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INoticeApi : INoticeApiSync, INoticeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NoticeApi : INoticeApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NoticeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NoticeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoticeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NoticeApi(string basePath)
        {
            this.Configuration = FIASCo.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.Client = new ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = FIASCo.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoticeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NoticeApi(Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = FIASCo.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ApiClient(this.Configuration.BasePath);
            ExceptionFactory = FIASCo.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoticeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public NoticeApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = FIASCo.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

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
        public IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
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
        /// Добавление уведомления 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="notice"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AddNoticeResult</returns>
        public AddNoticeResult ApiSpasV20AddNoticePost(Notice notice = default(Notice), int operationIndex = 0)
        {
            ApiResponse<AddNoticeResult> localVarResponse = ApiSpasV20AddNoticePostWithHttpInfo(notice);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Добавление уведомления 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="notice"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AddNoticeResult</returns>
        public ApiResponse<AddNoticeResult> ApiSpasV20AddNoticePostWithHttpInfo(Notice notice = default(Notice), int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = notice;

            localVarRequestOptions.Operation = "NoticeApi.ApiSpasV20AddNoticePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (master-token) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("master-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("master-token", this.Configuration.GetApiKeyWithPrefix("master-token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AddNoticeResult>("/api/spas/v2.0/AddNotice", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiSpasV20AddNoticePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Добавление уведомления 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="notice"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddNoticeResult</returns>
        public async System.Threading.Tasks.Task<AddNoticeResult> ApiSpasV20AddNoticePostAsync(Notice notice = default(Notice), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ApiResponse<AddNoticeResult> localVarResponse = await ApiSpasV20AddNoticePostWithHttpInfoAsync(notice, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Добавление уведомления 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="notice"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddNoticeResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddNoticeResult>> ApiSpasV20AddNoticePostWithHttpInfoAsync(Notice notice = default(Notice), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = notice;

            localVarRequestOptions.Operation = "NoticeApi.ApiSpasV20AddNoticePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (master-token) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("master-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("master-token", this.Configuration.GetApiKeyWithPrefix("master-token"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<AddNoticeResult>("/api/spas/v2.0/AddNotice", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiSpasV20AddNoticePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Получение списка уведомлений по условию 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticeFilterObject"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>NoticeItemsResult</returns>
        public NoticeItemsResult ApiSpasV20GetNoticeItemsPost(NoticeFilterObject noticeFilterObject = default(NoticeFilterObject), int operationIndex = 0)
        {
            ApiResponse<NoticeItemsResult> localVarResponse = ApiSpasV20GetNoticeItemsPostWithHttpInfo(noticeFilterObject);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Получение списка уведомлений по условию 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticeFilterObject"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of NoticeItemsResult</returns>
        public ApiResponse<NoticeItemsResult> ApiSpasV20GetNoticeItemsPostWithHttpInfo(NoticeFilterObject noticeFilterObject = default(NoticeFilterObject), int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = noticeFilterObject;

            localVarRequestOptions.Operation = "NoticeApi.ApiSpasV20GetNoticeItemsPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (master-token) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("master-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("master-token", this.Configuration.GetApiKeyWithPrefix("master-token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<NoticeItemsResult>("/api/spas/v2.0/GetNoticeItems", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiSpasV20GetNoticeItemsPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Получение списка уведомлений по условию 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticeFilterObject"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of NoticeItemsResult</returns>
        public async System.Threading.Tasks.Task<NoticeItemsResult> ApiSpasV20GetNoticeItemsPostAsync(NoticeFilterObject noticeFilterObject = default(NoticeFilterObject), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ApiResponse<NoticeItemsResult> localVarResponse = await ApiSpasV20GetNoticeItemsPostWithHttpInfoAsync(noticeFilterObject, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Получение списка уведомлений по условию 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticeFilterObject"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (NoticeItemsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NoticeItemsResult>> ApiSpasV20GetNoticeItemsPostWithHttpInfoAsync(NoticeFilterObject noticeFilterObject = default(NoticeFilterObject), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = noticeFilterObject;

            localVarRequestOptions.Operation = "NoticeApi.ApiSpasV20GetNoticeItemsPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (master-token) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("master-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("master-token", this.Configuration.GetApiKeyWithPrefix("master-token"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<NoticeItemsResult>("/api/spas/v2.0/GetNoticeItems", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiSpasV20GetNoticeItemsPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Получение статуса обработки уведомления 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetNoticeStatusResult</returns>
        public GetNoticeStatusResult ApiSpasV20GetNoticeStatusGet(long? id = default(long?), int operationIndex = 0)
        {
            ApiResponse<GetNoticeStatusResult> localVarResponse = ApiSpasV20GetNoticeStatusGetWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Получение статуса обработки уведомления 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetNoticeStatusResult</returns>
        public ApiResponse<GetNoticeStatusResult> ApiSpasV20GetNoticeStatusGetWithHttpInfo(long? id = default(long?), int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));
            }

            localVarRequestOptions.Operation = "NoticeApi.ApiSpasV20GetNoticeStatusGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (master-token) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("master-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("master-token", this.Configuration.GetApiKeyWithPrefix("master-token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GetNoticeStatusResult>("/api/spas/v2.0/GetNoticeStatus", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiSpasV20GetNoticeStatusGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Получение статуса обработки уведомления 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetNoticeStatusResult</returns>
        public async System.Threading.Tasks.Task<GetNoticeStatusResult> ApiSpasV20GetNoticeStatusGetAsync(long? id = default(long?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ApiResponse<GetNoticeStatusResult> localVarResponse = await ApiSpasV20GetNoticeStatusGetWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Получение статуса обработки уведомления 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetNoticeStatusResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetNoticeStatusResult>> ApiSpasV20GetNoticeStatusGetWithHttpInfoAsync(long? id = default(long?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));
            }

            localVarRequestOptions.Operation = "NoticeApi.ApiSpasV20GetNoticeStatusGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (master-token) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("master-token")))
            {
                localVarRequestOptions.HeaderParameters.Add("master-token", this.Configuration.GetApiKeyWithPrefix("master-token"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<GetNoticeStatusResult>("/api/spas/v2.0/GetNoticeStatus", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiSpasV20GetNoticeStatusGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}