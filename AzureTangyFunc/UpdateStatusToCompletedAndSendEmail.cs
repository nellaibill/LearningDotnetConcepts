using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using AzureTangyFunc.Data;
using AzureTangyFunc.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using SendGrid.Helpers.Mail;

namespace AzureTangyFunc
{
    public class UpdateStatusToCompletedAndSendEmail
    {
        private readonly AzureTangyDbContext _db;
        public UpdateStatusToCompletedAndSendEmail(AzureTangyDbContext db)
        {
            _db = db;
        }

        [FunctionName("UpdateStatusToCompletedAndSendEmail")]
        public async Task  Run([TimerTrigger("0 */10 * * * *")]TimerInfo myTimer,
              [SendGrid(ApiKey = "CustomSendGridKeyAppSettingName")] IAsyncCollector<SendGridMessage> messageCollector, 
              ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            IEnumerable<SalesRequest> salesRequestFromDb = _db.SalesRequests.Where(u => u.Status == "Image Processed");
            foreach (var salesReq in salesRequestFromDb)
            {
                //for each request update status
                salesReq.Status = "Completed";
            }

            _db.UpdateRange(salesRequestFromDb);
            _db.SaveChanges();
            var message = new SendGridMessage();
            message.AddTo("nellaibill@gmail.com");
            message.AddContent("text/html", $"Processing completed for {salesRequestFromDb.Count()} records");
            message.SetFrom(new EmailAddress("msaleem@acy7lab.com"));
            message.SetSubject("Azure Tangy Processing Successful");
            await messageCollector.AddAsync(message);
        }
    }
}
