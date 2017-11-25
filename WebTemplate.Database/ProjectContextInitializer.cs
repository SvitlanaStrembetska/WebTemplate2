﻿using System.Data.Entity;

namespace WebTemplate.Database
{
    using System.Collections.Generic;

    using WebTemplate.Database.Models;

    public class WebTemplateContextInitializer : DropCreateDatabaseIfModelChanges<WebTemplateContext>
    {
        protected override void Seed(WebTemplateContext context)
        {
            var category1 = new Category { Name = "Category 1" };
            var category2 = new Category { Name = "Category 2" };

            var news11 = new News { Name = "News 11", Price = 11 };
            var news12 = new News { Name = "News 12", Price = 12 };
            var news21 = new News { Name = "News 21", Price = 21 };
            var news22 = new News { Name = "News 22", Price = 22 };

            category1.News = new List<News> { news11, news12 };
            category2.News = new List<News> { news21, news22 };

            var tag1 = new Tag { Name = "Tag 1" };
            var tag2 = new Tag { Name = "Tag 2" };

            news11.Tags = new List<Tag> { tag1 };
            news12.Tags = new List<Tag> { tag2 };

            news21.Tags = new List<Tag> { tag1, tag2 };
            news22.Tags = new List<Tag> { tag1, tag2 };


            context.Categories.Add(category1);
            context.Categories.Add(category2);
            context.SaveChanges();
        }
    }
}