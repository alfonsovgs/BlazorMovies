using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorMovies.Client.Pages
{
    public class CounterBase : ComponentBase
    {
        [Inject] protected ServicioSingleton Singleton { get; set; }

        [Inject] protected ServicioTransient Transient { get; set; }

        [Inject] protected IJSRuntime Js { get; set; }

        protected int currentCount = 0;
        private static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            Singleton.Valor = currentCount;
            Transient.Valor = currentCount;
            currentCountStatic = currentCount;
            await Js.InvokeVoidAsync("dotnetCall"); //Call a method in js
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount() => Task.FromResult(currentCountStatic);

        protected async Task IncrementCountJs()
        {
            await Js.InvokeVoidAsync("dotnetMethodInstanceCall", DotNetObjectReference.Create(this));
        }
    }
}