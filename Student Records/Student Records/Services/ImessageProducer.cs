namespace Student_Records.Services;

public interface IMessageProducer
{
    public void SendMessage<T>(T message);

}
