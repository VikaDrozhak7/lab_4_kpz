public class ConcreteHandler2 : AbstractHandler
{
    public override object Handle(object request)
    {
        if ((request as string) == "2")
        {
            return $"ConcreteHandler2: Handled {request.ToString()}\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}
