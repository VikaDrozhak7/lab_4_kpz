public class ConcreteHandler4 : AbstractHandler
{
    public override object Handle(object request)
    {
        if ((request as string) == "4")
        {
            return $"ConcreteHandler4: Handled {request.ToString()}\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}
