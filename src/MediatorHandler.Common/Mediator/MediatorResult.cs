namespace MediatorHandler.Common.Mediator;

public class MediatorResult
{
    public List<String> Errors { get; set; }
    public Object Response { get; set; }

    public MediatorResult()
    {
        Errors = new List<String>();
        Response = null;
    }

    public bool IsValid()
    {
        return !Errors.Any();
    }
}
