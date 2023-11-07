namespace ex02
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate request;
        

        public CustomMiddleware(RequestDelegate request)
        {
            this.request = request;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            Console.WriteLine("ggggfffff");
            await request(httpContext);
            await httpContext.Response.WriteAsync("    kkkkkaaaaaaa");
        }
    }
}
