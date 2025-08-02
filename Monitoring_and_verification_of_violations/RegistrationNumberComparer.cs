using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace Monitoring_and_verification_of_violations
{
    internal class RegistrationNumberComparer
    {
        static readonly Dictionary<char, char> RussianToLatinMap = new Dictionary<char, char>
        {
            {'А', 'A'}, {'В', 'B'}, {'С', 'C'}, {'Е', 'E'}, {'Н', 'H'},
            {'К', 'K'}, {'М', 'M'}, {'О', 'O'}, {'Р', 'P'}, {'Т', 'T'},
            {'Х', 'X'}, {'У', 'Y'}
        };
        
        public static async Task<bool> CheckVehicleRegAsync()
        {
            string apiUrl = $"http://{Main_UI.IPadress_Recognition}/appearance/api/Capabilities";

            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromSeconds(1);

                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var serializer = new JavaScriptSerializer();
                    var datajson = serializer.Deserialize<Dictionary<string, dynamic>>(jsonResponse);

                    if (datajson.TryGetValue("vehicleRegId", out object value))
                    {
                        return (bool)value;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        
        public static async Task<bool> Compare(Main_UI.Car_Metadata data)
        {
            if (Main_UI.Recognition && Main_UI.VehicleReg)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
                        client.Timeout = TimeSpan.FromSeconds(30);

                        using (MultipartFormDataContent formData = new MultipartFormDataContent())
                        {
                            byte[] fileBytes = Convert.FromBase64String(data.photo_grz);

                            int imageWidth, imageHeight;
                            using (var memoryStream = new MemoryStream(fileBytes))
                            using (var image = System.Drawing.Image.FromStream(memoryStream))
                            {
                                imageWidth = image.Width;
                                imageHeight = image.Height;
                            }
                            string url = $"http://{Main_UI.IPadress_Recognition}/appearance/api/Temp/RecognizeRegIdByPhoto?x=0&y=0&width={imageWidth}&height={imageHeight}";

                            ByteArrayContent fileContent = new ByteArrayContent(fileBytes);
                            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
                            formData.Add(fileContent, "file", Path.GetFileName("image.jpg"));

                            HttpResponseMessage response = await client.PostAsync(url, formData).ConfigureAwait(false);

                            if (response.IsSuccessStatusCode)
                            {
                                string result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                                var serializer = new JavaScriptSerializer();
                                var datajson = serializer.Deserialize<Dictionary<string, dynamic>>(result);

                                if (datajson.TryGetValue("value", out object value))
                                {
                                    return Compare_Number(data.regno, value.ToString());
                                }
                            }
                        }
                    }
                    return false;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        
        static bool Compare_Number(string number1, string number2)
        {
            if (string.IsNullOrEmpty(number1) && string.IsNullOrEmpty(number2)) return true;
            if (string.IsNullOrEmpty(number1) || string.IsNullOrEmpty(number2)) return false;

            return Normalize(number1).Equals(Normalize(number2), StringComparison.Ordinal);
        }
        
        static string Normalize(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;

            StringBuilder sb = new StringBuilder(input.Length);
            foreach (char c in input.ToUpperInvariant())
            {
                if (RussianToLatinMap.TryGetValue(c, out char latinChar))
                    sb.Append(latinChar);
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
