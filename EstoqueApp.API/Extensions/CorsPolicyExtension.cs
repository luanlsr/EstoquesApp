﻿namespace EstoqueApp.API.Extensions
{
    public static class CorsPolicyExtension
    {
        private static string _policyName = "DefaultPolicy";
        public static IServiceCollection AddCorsPolicy(this IServiceCollection services)
        {
            services.AddCors(
                s => s.AddPolicy("", builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                }));
            return services;
        }
        public static IApplicationBuilder UseCorsPolicy(this IApplicationBuilder app)
        {
            app.UseCors(_policyName);
            return app;
        }
    }
}
