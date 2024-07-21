using InterviewProjectApi.Entities;
using System.Linq.Expressions;

namespace InterviewProjectApi.Services.Abstract
{
    public interface IBlogPostService
    {
        IEnumerable<BlogPost> GetAll();
        BlogPost GetById(int id);
        void CreateBlogPost(BlogPost newBlogPost);
    }
}
