namespace task5
{
    public interface IPhone
    {
        string Model { get; set; }
        void Call(string number);
        void SendMessage(string number, string message);
    }
}