namespace EventsAndDelegates
{
    public  class VideoEncoder
    {
        //1. define delegate
        //2. define event based on delegate
        //3. raise the event
        public delegate void VideoEncodedEventHandler(object source,EventArgs e);

        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video ...");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
