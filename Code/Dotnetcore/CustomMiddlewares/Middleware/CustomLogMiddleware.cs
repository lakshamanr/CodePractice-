using CustomMiddlewares.Middleware;

namespace CustomMiddlewares.Middleware
{
    public class CustomLogMiddleware(RequestDelegate requestDelegates)
    {
        public readonly RequestDelegate _next = requestDelegates;

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("Custom Middleware executions");
            await _next.Invoke(context);
        }
    }
 
    public static class CustomLogExtensionClass
    {
        public static IApplicationBuilder UseCustomLogMessage(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CustomLogMiddleware>();
        }
    }
}
