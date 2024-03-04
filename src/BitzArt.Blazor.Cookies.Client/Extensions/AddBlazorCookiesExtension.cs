﻿using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BitzArt.Blazor.Cookies;

public static class AddBlazorCookiesExtension
{
    public static WebAssemblyHostBuilder AddBlazorCookies(this WebAssemblyHostBuilder builder)
    {
        builder.Services.AddScoped<ICookieService, BrowserCookieService>();
        return builder;
    }
}
