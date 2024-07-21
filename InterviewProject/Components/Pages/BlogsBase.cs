using InterviewProject.Components.Services;
using InterviewProject.Models;
using Microsoft.AspNetCore.Components;

namespace InterviewProject.Components.Pages
{
    public class BlogsBase : ComponentBase
    {
        [Inject]
        public IBlogService BlogService { get; set; }

        public IEnumerable<BlogPost> Blogs { get; set; }
        public BlogPost Item { get; set; }

        public async Task<BlogPost> GetById(int id)
        {
            var item = await BlogService.GetById(id);
            return item;
        }

        public async Task CreateNewBlog(BlogPost item)
        {
            await BlogService.CreateBlogPost(item);
        }

        protected override async Task OnInitializedAsync()
        {
            Blogs = await BlogService.GetAll();
        }
    }

}
