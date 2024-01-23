using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ExtendedGridLayout.Data {
    public class LocalStorageHelper {
        private readonly IJSRuntime _JSRuntime;
        public LocalStorageHelper(IJSRuntime JSRuntime) {
            _JSRuntime = JSRuntime;
        }
        public  async Task<string> GetItemAsync(string key) {
            try {
                return await _JSRuntime.InvokeAsync<string>("localStorage.getItem", key);
            }
            catch {
                // Mute exceptions
                return "";
            }
        }
        public async Task SetItemAsync(string key, string value) {
            try {
                await _JSRuntime.InvokeVoidAsync("localStorage.setItem", key, value);
            }
            catch {
                // Mute exceptions
            }
        }
    }
}
