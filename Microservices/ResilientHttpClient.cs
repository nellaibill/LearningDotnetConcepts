namespace Microservices
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Polly;
    using Polly.CircuitBreaker;
    using Polly.Retry;

    public class ResilientHttpClient
    {
        private readonly HttpClient _httpClient;
        private readonly AsyncRetryPolicy<HttpResponseMessage> _retryPolicy;
        private readonly AsyncCircuitBreakerPolicy<HttpResponseMessage> _circuitBreakerPolicy;

        public ResilientHttpClient()
        {
            _httpClient = new HttpClient();

            // Define a retry policy: retry up to 3 times with a delay of 2 seconds between retries
            _retryPolicy = Policy
                .HandleResult<HttpResponseMessage>(r => !r.IsSuccessStatusCode)
                .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(5));

            // Define a circuit breaker policy: break the circuit after 2 consecutive failures, for 1 minute
            _circuitBreakerPolicy = Policy
                .HandleResult<HttpResponseMessage>(r => !r.IsSuccessStatusCode)
                .CircuitBreakerAsync(2, TimeSpan.FromMinutes(1));
        }

        public async Task<HttpResponseMessage> GetAsync(string uri)
        {
            // Execute the request within the defined policies
            return await _retryPolicy
                .WrapAsync(_circuitBreakerPolicy)
                .ExecuteAsync(() => _httpClient.GetAsync(uri));
        }
    }

}
