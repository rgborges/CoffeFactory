internal enum ServiceReult
{
    Ok,
    Fail,
    Timeout
}

internal interface IServiceResult
{
    ServiceReult GetResult();
}