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

        public async Task<BlogPost> GetById(Guid id)
        {
            var blog = await _httpClient.GetFromJsonAsync<BlogPost>("api/blogPost");
            return blog;
        }
    }
}
