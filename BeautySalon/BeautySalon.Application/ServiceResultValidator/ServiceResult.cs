namespace BeautySalon.Application.ServiceResultValidator;

public class ServiceResult<T> : ServiceResult
{
    internal T? Data { get; set; }

    public ServiceResult(string str)
    {
        ErrorMessages.Add(str);
        HasError = true;
    }

    public ServiceResult(T data)
    {
        Data = data;
    }
}

public class ServiceResult
{
    internal ICollection<string> ErrorMessages { get; set; } = [];
    internal bool HasError { get; set; } = false;

    public ServiceResult()
    {
    }
}