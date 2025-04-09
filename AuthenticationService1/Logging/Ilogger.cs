namespace AuthenticationService1.Logging
{
    public interface ILogger
    {
        public void WriteEvent(string eventMessage);
        public void WriteError(string errorMessage);
    }
}
