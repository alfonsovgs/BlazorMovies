using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public static class JSRuntimeExtensions
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("console.log", "Show info from console");
            return await js.InvokeAsync<bool>("confirm", message);
        }
    }
}