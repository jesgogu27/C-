
public class TimeMiddelware
{
    readonly RequestDelegate next;

    public TimeMiddelware(RequestDelegate nextRequest)
    {
        next= nextRequest;
    }

    public async Task Invoke(HttpContext context)
    {
        await next(context);

        if(context.Request.Query.Any(p=> p.Key == "time"))
        {
            await context.Response.WriteAsync(DateTime.Now.ToShortTimeString());
        }
    }

}

public static class TimeMiddelwareExtension
    {
        public static IApplicationBuilder UseTimeMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TimeMiddelware>();
        }
    }

