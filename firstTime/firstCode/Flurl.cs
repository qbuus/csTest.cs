using Flurl.Http;

namespace Project
{   
    public class FlursClass
    {
        public static async Task FlurMethods()
        {
            var postsJson = await "https://jsonplaceholder.typicode.com/posts".GetAsync()
            .ReceiveJson<List<ApiResponseBody>>();

            var selected = postsJson.First(p => p.Id == 30);

                selected.Title = "title";
                selected.Body = "body";

                Console.WriteLine(selected.Title);
                Console.WriteLine(selected.Body);

                var postsJsonAsync = await "https://jsonplaceholder.typicode.com/posts"
                .WithHeaders(new
                    {
                        header = "value"
                    }, true
                ).SetQueryParams(new 
                {
                    postId = 1
                })
                .PostJsonAsync(selected);
                Console.WriteLine(postsJsonAsync.StatusCode);            
        }   
    }
}