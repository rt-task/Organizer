using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Shared.Helpers;

public static class RestApiHelper
{
    public static async Task<TRes> ExecuteAsync<T, TRes>(
        Func<T, TRes> cta,
        Func<Task<T>> controllerAction,
        ILogger logger)
    {
        try
        {
            return cta(await controllerAction());
        }
        catch (Exception ex)
        {
            logger.StandardLog(LogLevel.Critical, ex);
            throw;
        }
    }

    public static async Task<TRes> ExecuteAsync<TRes>(
        Func<TRes> cta,
        Func<Task> controllerAction,
        ILogger logger)
    {
        try
        {
            await controllerAction();
            return cta();
        }
        catch (Exception ex)
        {
            logger.StandardLog(LogLevel.Critical, ex);
            throw;
        }
    }

    public static async Task<IActionResult> ExecuteAsync<T, TRes, TEx, TErr, TErrRes>(
        Func<T, TRes> cta,
        Func<Task<T>> controllerAction,
        Func<TErr, TErrRes> errCta,
        Func<TErr> controllerErrAction,
        ILogger logger)
        where TEx : Exception
        where TRes : IActionResult
        where TErrRes : IActionResult
    {
        try
        {
            return cta(await controllerAction());
        }
        catch (TEx ex)
        {
            logger.StandardLog(LogLevel.Error, ex);
            return errCta(controllerErrAction());
        }
        catch (Exception ex)
        {
            logger.StandardLog(LogLevel.Critical, ex);
            throw;
        }
    }
}
