using InterviewProject.Models;

namespace InterviewProject.Components.Services
{
    public class BlogService : IBlogService
    {
        private readonly HttpClient _httpClient;

        public BlogService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<BlogPost>> GetAll()
        {
            var blogs = await _httpClient.GetFromJsonAsync<IEnumerable<BlogPost>>("api/blogPost");
            return blogs;
        }

        public async Task CreateBlogPost(BlogPost newBlogPost)
        {
            var response = await _httpClient.PostAsJsonAsync("api/blogPost", newBlogPost);
            response.EnsureSuccessStatusCode();
        }

        public async Task<BlogPost> GetById(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/blogPost/{id}");
                response.EnsureSuccessStatusCode();
                var jsonString = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrEmpty(jsonString))
                {
                    // Log empty response or handle accordingly
                    return null;
                }

                var item = await response.Content.ReadFromJsonAsync<BlogPost>();
                return item;
            }
            catch (Exception ex)
            {
                // Log exception
                Console.WriteLine($"Exception in GetById: {ex.Message}");
                return null;
            }
        }
    }
}
