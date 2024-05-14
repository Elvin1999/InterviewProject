using InterviewProjectApi.Entities;
using System.Linq.Expressions;

namespace InterviewProjectApi.Services.Abstract
{
    public interface IBlogPostService
    {
        IEnumerable<BlogPost> GetAll();
        BlogPost GetById(Guid id);
    }
}
