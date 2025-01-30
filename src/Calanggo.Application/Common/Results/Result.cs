namespace Calango.Application.Common.Results;

public class Result<T>
{
    public bool IsSuccess { get; }
    public T? Value { get; }
    public Error? Error { get; }

    protected internal Result(T? value, bool isSuccess, Error? error)
    {
        IsSuccess = isSuccess;
        Value = value;
        Error = error;
    }

    public static Result<T> Success(T value)
    {
        return new Result<T>(value, true, default);
    }

    public static Result<T> Failure(Error error)
    {
        return new Result<T>(default, false, error);
    }
}

public class Result
{
    public bool IsSuccess { get; }
    public Error? Error { get; }

    private Result(bool isSuccess, Error? error)
    {
        IsSuccess = isSuccess;
        Error = error;
    }

    public static Result Success()
    {
        return new Result(true, default);
    }

    public static Result Failure(Error error)
    {
        return new Result(false, error);
    }
}