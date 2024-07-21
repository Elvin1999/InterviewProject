using AutoMapper;
using InterviewProjectApi.Dtos;
using InterviewProjectApi.Entities;
using InterviewProjectApi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InterviewProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostService _blogPostService;
        private readonly IMapper _mapper;

        public BlogPostController(IBlogPostService blogPostService, IMapper mapper)
        {
            _blogPostService = blogPostService;
            _mapper = mapper;
        }

        // GET: api/<BlogPostController>
        [HttpGet]
        public IEnumerable<BlogPostDto> Get()
        {
            var items=_blogPostService.GetAll();
            var dtos = _mapper.Map<List<BlogPostDto>>(items);
            return dtos;
        }

        // GET api/<BlogPostController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BlogPost>> Get(int id)
        {
            var item = _blogPostService.GetById(id);
            if(item == null)
            {
                return NotFound();
            }
            var dto = _mapper.Map<BlogPostDto>(item);
            return Ok(dto);
        }

        [HttpPost]
        public ActionResult<BlogPost> Create(BlogPost newBlogPost)
        {
            _blogPostService.CreateBlogPost(newBlogPost);
            return CreatedAtAction(nameof(Get), new { id = newBlogPost.Id }, newBlogPost);
        }

        // PUT api/<BlogPostController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BlogPostController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
