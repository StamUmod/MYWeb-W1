using MYWeb_W1.Models;

namespace MYWeb_W1.Services;

public class MeMeServicess
{
    private string url = "https://memes.tw/wtf/api";
    public async Task<List<MeMeModels>> List(int c)
    {
        List<MeMeModels> result = new List<MeMeModels>();
        
        try
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url+"?contest="+c);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadFromJsonAsync<List<MeMeModels>>();
            }    
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
            throw;
        }
        return result;
    }
}