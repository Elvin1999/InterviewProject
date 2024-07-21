using InterviewProject.Models;

namespace InterviewProject.Components.Services
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogPost>> GetAll();
        Task<BlogPost> GetById(int id);
        Task CreateBlogPost(BlogPost newBlogPost);
    }
}
