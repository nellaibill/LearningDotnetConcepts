namespace Microservices
{
    using Polly.CircuitBreaker;
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class MyMicroservice
    {
        private readonly ResilientHttpClient _resilientHttpClient;

        public MyMicroservice()
        {
            _resilientHttpClient = new ResilientHttpClient();
        }

        public async Task<string> GetDataFromAnotherService()
        {
            try
            {
                HttpResponseMessage response = await _resilientHttpClient.GetAsync("https://dummy.restapiexample.com/api/v1/Employee");

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    return data; // Return data as string
                }
                else
                {
                    // Handle failure case (optional)
                    Console.WriteLine("Request failed with status code: " + response.StatusCode);
                    return null; // Or handle failure appropriately
                }
            }
            catch (BrokenCircuitException)
            {
                Console.WriteLine("Circuit is open; requests are not being sent.");
                throw; // Rethrow the exception or handle it as needed
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                throw; // Rethrow the exception or handle it as needed
            }
        }
    }
}
