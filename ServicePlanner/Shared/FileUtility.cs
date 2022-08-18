using Microsoft.JSInterop;

namespace ServicePlanner.Shared
{
    public static class FileUtility
    {
        public static async Task SaveAs(IJSRuntime js, string filename, byte[] data)
        {
            await js.InvokeAsync<object>(
                "SaveAsFile",
                filename,
                Convert.ToBase64String(data));
        }
    }
}
