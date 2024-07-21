using InterviewProjectApi.Entities;
using InterviewProjectApi.Services.Abstract;
using Microsoft.AspNetCore.Http.Features;
using System.Linq.Expressions;

namespace InterviewProjectApi.Services.Concrete
{
    public class BlogPostService : IBlogPostService
    {
        public static List<BlogPost> GetBlogPosts()
        {
            return new List<BlogPost>()
        {
            new BlogPost
            {
                Id = 1,
                Title = "Exploring the New Features of .NET 6",
                Author = "Jane Doe",
                PublishDate = new DateTime(2024, 5, 7),
                Content = "In this post, we'll explore the new and improved features in .NET 6, focusing on minimal APIs, hot reload, and improved Blazor performance."
            },
            new BlogPost
            {
                Id = 2,
                Title = "Understanding Dependency Injection in .NET",
                Author = "John Smith",
                PublishDate = new DateTime(2024, 4, 22),
                Content = "Dependency Injection is a key component of modern software design. This article dives deep into how it works in the .NET ecosystem."
            },
            new BlogPost
            {
                Id = 3,
                Title = "Best Practices for Asynchronous Programming in C#",
                Author = "Emily White",
                PublishDate = new DateTime(2024, 3, 15),
                Content = "Asynchronous programming can make your applications more responsive. Learn the best practices to effectively use async and await in C#."
            },
            new BlogPost
            {
                Id = 3,
                Title = "Integrating AI with .NET Applications",
                Author = "Michael Brown",
                PublishDate = new DateTime(2024, 5, 1),
                Content = "Artificial Intelligence is becoming more accessible. Learn how to integrate AI capabilities into your .NET applications using various libraries and APIs."
            },
            new BlogPost
            {
                Id = 4,
                Title = "Migrating from .NET Framework to .NET Core",
                Author = "Samantha Reed",
                PublishDate = new DateTime(2024, 4, 18),
                Content = "Is it time to migrate? This post will guide you through the process and considerations for moving from .NET Framework to .NET Core."
            },
            new BlogPost
            {
                Id =5,
                Title = "Securing Web APIs in .NET",
                Author = "Liam Wilson",
                PublishDate = new DateTime(2024, 4, 5),
                Content = "Security is crucial for your APIs. Explore the best practices for securing your .NET Web APIs against common threats and vulnerabilities."
            },
            new BlogPost
            {
                Id = 6,
                Title = "Advanced LINQ Tips and Tricks",
                Author = "Olivia Johnson",
                PublishDate = new DateTime(2024, 3, 28),
                Content = "LINQ is a powerful tool. Enhance your queries with these advanced tips and tricks for getting the most out of LINQ in .NET."
            },
            new BlogPost
            {
                Id = 7,
                Title = "Using SignalR for Real-Time Communication in .NET",
                Author = "Ethan Martinez",
                PublishDate = new DateTime(2024, 3, 21),
                Content = "Learn how to use SignalR in .NET to add real-time web functionality to your applications, enabling live chat features and more."
            },
            new BlogPost
            {
                Id = 8,
                Title = "Performance Optimization in .NET Applications",
                Author = "Ava Taylor",
                PublishDate = new DateTime(2024, 3, 10),
                Content = "Optimize the performance of your .NET applications with these essential tips and techniques for maximizing efficiency."
            },
            new BlogPost
            {
                Id = 9,
                Title = "Building Microservices with .NET",
                Author = "Noah Lee",
                PublishDate = new DateTime(2024, 2, 27),
                Content = "Microservices architecture is trending. Learn how to design, build, and deploy microservices using .NET technologies."
            }
        };
        }

        public void CreateBlogPost(BlogPost newBlogPost)
        {
            GetBlogPosts().Add(newBlogPost);
        }

        public IEnumerable<BlogPost> GetAll()
        {
            var items = GetBlogPosts();
            return items;
        }

        public BlogPost GetById(int id)
        {
            var items = GetBlogPosts();
            var item = items.FirstOrDefault(i=>i.Id.ToString()==id.ToString());
            return item;
        }

    }
}
