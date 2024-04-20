public class ConcreteHandler3 : AbstractHandler
{
    public override object Handle(object request)
    {
        if ((request as string) == "3")
        {
            return $"ConcreteHandler3: Handled {request.ToString()}\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}
