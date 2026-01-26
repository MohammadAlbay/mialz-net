namespace ITStage.Net.IMAP
{
    public interface IMapServer
    {
        void Connect(string server, int port);
        void Authenticate(string username, string password);
        void Disconnect();
        // Other IMAP server related methods
    }
}