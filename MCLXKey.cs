using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MCLXKey
{
    public class MCLXKeyAuth
    {
        private static readonly HttpClient client = new HttpClient();

        public class AuthRequest
        {
            public string name { get; set; }
            public string pass { get; set; }
            public string hwid { get; set; }
            public string projectsecretid { get; set; }
            public string userid { get; set; }
            public string special_token { get; set; }
            public string type { get; set; }
        }

        public class AuthResponse
        {
            public bool success { get; set; }
            public User user { get; set; }
            public Project project { get; set; }
            public string message { get; set; }
            public string error { get; set; }
        }

        public class User
        {
            public string id { get; set; }
            public string name { get; set; }
            public string username { get; set; }
            public string expireDate { get; set; }
            public string hwid { get; set; }
            public string lastLogin { get; set; }
        }

        public class Project
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public static async Task<AuthResponse> AuthenticateAsync(
            string name,
            string pass,
            string hwid)
        {
            try
            {
                var request = new AuthRequest
                {
                    name = name,
                    pass = pass,
                    hwid = hwid,
                    projectsecretid = "737a0a50fb7a4451ec5f476e3e571113",
                    userid = "687bb018225ff98025e361d1",
                    special_token = "ad8985011eef8f0f1470b8a76af85cecd9d439859961d77808b32673e09325ae",
                    type = "login"
                };

                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://mclxkey.vercel.app/api", content);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<AuthResponse>(responseContent);
                }
                else
                {
                    var errorResponse = JsonConvert.DeserializeObject<AuthResponse>(responseContent);
                    return new AuthResponse
                    {
                        success = false,
                        error = errorResponse?.error ?? $"HTTP {(int)response.StatusCode}",
                        message = errorResponse?.message ?? "Authentication failed"
                    };
                }
            }
            catch (Exception ex)
            {
                return new AuthResponse
                {
                    success = false,
                    error = $"Network error: {ex.Message}",
                    message = "Connection failed"
                };
            }
        }
    }
}

