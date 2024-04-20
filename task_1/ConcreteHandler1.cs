public class ConcreteHandler1 : AbstractHandler
{
    public override object Handle(object request)
    {
        if ((request as string) == "1")
        {
            return $"ConcreteHandler1: Handled {request.ToString()}\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}
