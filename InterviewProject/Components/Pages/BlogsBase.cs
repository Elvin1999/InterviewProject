using InterviewProject.Components.Services;
using InterviewProject.Models;
using Microsoft.AspNetCore.Components;

namespace InterviewProject.Components.Pages
{
    public class BlogsBase:ComponentBase
    {
        [Inject]
        public IBlogService BlogService { get; set; }
        public IEnumerable<BlogPost> Blogs { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Blogs=await BlogService.GetAll();
        }
    }
}
