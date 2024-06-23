
using OpenTelemetry;
using OpenTelemetry.Trace;
using System;
using System.IO;
using System.Net;

class Program
{
    //static List<string> lst = null;
    static void Main(string[] args)
    {
        /* using var openTelemetry = Sdk.CreateTracerProviderBuilder()
             .AddSource("OpenTelemetrySampleSource")
             .AddConsoleExporter()
             .Build();
         Console.WriteLine("Start Blsting .... ");
         Console.Read();
         DisplayGenCounters();
         HugeLoop();
         DisplayGenCounters();
        */
        //string ftpUrl = "ftp://ftp.jurongpoint.com.sg/test2.txt";
        string ftpUrl = "ftp://ftp.jurongpoint.com.sg";
        string ftpUsername = "1030300";
        string ftpPassword = "apetqf2e";
        string localFilePath = @"D:\Learning\test2.txt";

        try
        {
            //UploadFileToFtp(ftpUrl, localFilePath, ftpUsername, ftpPassword);
            ListDirectoryContentsActiveMode(ftpUrl, ftpUsername, ftpPassword);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void UploadFileToFtp(string ftpUrl, string localFilePath, string username, string password)
    {
        FileInfo fileInfo = new FileInfo(localFilePath);
        

        // Create FTP request
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);
        request.Method = WebRequestMethods.Ftp.UploadFile;
        request.Credentials = new NetworkCredential(username, password);
        request.UsePassive = false;
        request.UseBinary = true;
        request.KeepAlive = false;

        // Read the file data
        byte[] fileContents;
        using (FileStream fs = fileInfo.OpenRead())
        {
            fileContents = new byte[fs.Length];
            fs.Read(fileContents, 0, (int)fs.Length);
        }

        // Upload the file
        using (Stream requestStream = request.GetRequestStream())
        {
            requestStream.Write(fileContents, 0, fileContents.Length);
        }

        // Get response from FTP server
        using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
        {
            Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
        }
    }
    static void ListDirectoryContentsActiveMode(string ftpUrl, string username, string password)
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);
        request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
        request.Credentials = new NetworkCredential(username, password);
        request.UsePassive = false; // Use active mode
        request.UseBinary = true;
        request.KeepAlive = false;

        using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
        using (Stream responseStream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(responseStream))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine($"Directory List Complete, status {response.StatusDescription}");
        }
    }
    static void DisplayGenCounters()
    {
        GC.Collect();
        int gen0Count = GC.CollectionCount(0);
        int gen1Count = GC.CollectionCount(1);
        int gen2Count = GC.CollectionCount(2);
        Console.WriteLine($"Gen 0  {gen0Count}");
        Console.WriteLine($"Gen 1  {gen1Count}");
        Console.WriteLine($"Gen 2  {gen2Count}");
    }


    static void ListDirectoryContents(string ftpUrl, string username, string password)
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);
        request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
        request.Credentials = new NetworkCredential(username, password);
        request.UsePassive = true;
        request.UseBinary = true;
        request.KeepAlive = false;

        using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
        using (Stream responseStream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(responseStream))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine($"Directory List Complete, status {response.StatusDescription}");
        }
    }
    static void HugeLoop()
    {
       // lst = new List<string>();
        for (double i = 0; i <= 10000; i++)
        {
            Customer cust = new Customer();
            cust.Name = DateTime.Now.ToString();
            //cust.Dispose(); // If we call dispose destructor will not call , if developer miss the best practices then destructor will call and clean up the memory
            //lst.Add(DateTime.Now.ToString());
            //Thread.Sleep(1000);
        }
    }
}

class Customer :IDisposable
{
    public string Name { get; set; }

    ~Customer()
    {
        Dispose();
    }
    private void CleanUpUnusedMemory()
    {

    }
    public void Dispose()
    {
        GC.SuppressFinalize(this);
        CleanUpUnusedMemory();
        //throw new NotImplementedException();
    }
}

