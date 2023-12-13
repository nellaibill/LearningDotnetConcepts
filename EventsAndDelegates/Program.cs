using EventsAndDelegates;

public class Program
{
    static void Main(String[] args)
    {
        var video = new Video() { Title = "Raja" };
        VideoEncoder encoder = new VideoEncoder(); // publisher
        MailService mailService = new MailService();//subscriber
        MessageService messageService = new MessageService(); //subscriber2
        encoder.VideoEncoded += mailService.OnVideoEncoded;
        encoder.VideoEncoded += messageService.OnVideoDecoded;
        encoder.Encode(video);
    }
}

public class MailService
{
    public void OnVideoEncoded(object source, EventArgs e)
    {
        Console.WriteLine("Mail Service -Sending an Email");
    }
}

public  class MessageService
{
    public void OnVideoDecoded(object source, EventArgs e)
    {
        Console.WriteLine("Message Service - Sending a text service");
    }
}