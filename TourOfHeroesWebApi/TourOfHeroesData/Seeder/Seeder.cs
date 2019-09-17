﻿using System.Collections.Generic;
using System.Linq;
using TourOfHeroesData.Models;
using TourOfHeroesData.Seeder.Contracts;

namespace TourOfHeroesData.Seeder
{
    public class Seeder : ISeeder
    {
        private readonly TourOfHeroesDbContext _dbContext;

        public Seeder(TourOfHeroesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SeedDatabase()
        {
            var heroList = new List<Hero>();

            if (!_dbContext.Heroes.Any())
            {
                var cptAmerica = new Hero
                {
                    Name = "Captain America",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vel eros orci. Integer dictum pretium imperdiet. In tellus ligula, vestibulum vel orci et, dictum accumsan magna. Sed porttitor ligula sit amet sem tristique aliquet. Sed porta magna non enim fringilla placerat. Praesent volutpat congue purus, at ullamcorper magna aliquet ut. Vestibulum at pellentesque sapien. Phasellus eu mattis mauris. Sed pharetra maximus dolor ut rutrum. Quisque commodo magna a enim pulvinar sollicitudin.",
                    Image = "https://res.cloudinary.com/goofy5752/image/upload/v1568707816/HeroUploads/cpt_america_img_h3vbyt.jpg",
                    CoverImage = "https://res.cloudinary.com/goofy5752/image/upload/v1568707816/HeroUploads/cpt_america_cover_c0v4og.png"
                };

                heroList.Add(cptAmerica);

                var spiderman = new Hero
                {
                    Name = "Spider-Man",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vel eros orci. Integer dictum pretium imperdiet. In tellus ligula, vestibulum vel orci et, dictum accumsan magna. Sed porttitor ligula sit amet sem tristique aliquet. Sed porta magna non enim fringilla placerat. Praesent volutpat congue purus, at ullamcorper magna aliquet ut. Vestibulum at pellentesque sapien. Phasellus eu mattis mauris. Sed pharetra maximus dolor ut rutrum. Quisque commodo magna a enim pulvinar sollicitudin.",
                    Image = "https://res.cloudinary.com/goofy5752/image/upload/v1568707690/HeroUploads/spiderman-img_vcfskb.jpg",
                    CoverImage = "https://res.cloudinary.com/goofy5752/image/upload/v1568707690/HeroUploads/spiderman-cover_akceyp.jpg"
                };

                heroList.Add(spiderman);

                var thor = new Hero
                {
                    Name = "Thor",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vel eros orci. Integer dictum pretium imperdiet. In tellus ligula, vestibulum vel orci et, dictum accumsan magna. Sed porttitor ligula sit amet sem tristique aliquet. Sed porta magna non enim fringilla placerat. Praesent volutpat congue purus, at ullamcorper magna aliquet ut. Vestibulum at pellentesque sapien. Phasellus eu mattis mauris. Sed pharetra maximus dolor ut rutrum. Quisque commodo magna a enim pulvinar sollicitudin.",
                    Image = "https://res.cloudinary.com/goofy5752/image/upload/v1568707791/HeroUploads/thor-img_aeb3pa.jpg",
                    CoverImage = "https://res.cloudinary.com/goofy5752/image/upload/v1568707792/HeroUploads/thor-cover_ab0mdt.jpg"
                };

                heroList.Add(thor);

                var hulk = new Hero
                {
                    Name = "Hulk",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vel eros orci. Integer dictum pretium imperdiet. In tellus ligula, vestibulum vel orci et, dictum accumsan magna. Sed porttitor ligula sit amet sem tristique aliquet. Sed porta magna non enim fringilla placerat. Praesent volutpat congue purus, at ullamcorper magna aliquet ut. Vestibulum at pellentesque sapien. Phasellus eu mattis mauris. Sed pharetra maximus dolor ut rutrum. Quisque commodo magna a enim pulvinar sollicitudin.",
                    Image = "https://res.cloudinary.com/goofy5752/image/upload/v1568707689/HeroUploads/hulk-img_dauwaa.jpg",
                    CoverImage = "https://res.cloudinary.com/goofy5752/image/upload/v1568707690/HeroUploads/hulk-cover_mgxrcq.jpg"
                };

                heroList.Add(hulk);

                var ironman = new Hero
                {
                    Name = "Iron Man",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vel eros orci. Integer dictum pretium imperdiet. In tellus ligula, vestibulum vel orci et, dictum accumsan magna. Sed porttitor ligula sit amet sem tristique aliquet. Sed porta magna non enim fringilla placerat. Praesent volutpat congue purus, at ullamcorper magna aliquet ut. Vestibulum at pellentesque sapien. Phasellus eu mattis mauris. Sed pharetra maximus dolor ut rutrum. Quisque commodo magna a enim pulvinar sollicitudin.",
                    Image = "https://res.cloudinary.com/goofy5752/image/upload/v1568707689/HeroUploads/ironman-img_kvxuvy.jpg",
                    CoverImage = "https://res.cloudinary.com/goofy5752/image/upload/v1568707689/HeroUploads/ironman-cover_kvdzuy.jpg"
                };

                heroList.Add(ironman);

                var hawkeye = new Hero
                {
                    Name = "Hawkeye",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vel eros orci. Integer dictum pretium imperdiet. In tellus ligula, vestibulum vel orci et, dictum accumsan magna. Sed porttitor ligula sit amet sem tristique aliquet. Sed porta magna non enim fringilla placerat. Praesent volutpat congue purus, at ullamcorper magna aliquet ut. Vestibulum at pellentesque sapien. Phasellus eu mattis mauris. Sed pharetra maximus dolor ut rutrum. Quisque commodo magna a enim pulvinar sollicitudin.",
                    Image = "https://res.cloudinary.com/goofy5752/image/upload/v1568707690/HeroUploads/hawkeye-img_lvvkth.jpg",
                    CoverImage = "https://res.cloudinary.com/goofy5752/image/upload/v1568707690/HeroUploads/hawkeye-cover_dpzgsd.jpg"
                };

                heroList.Add(hawkeye);

                var blackwidow = new Hero
                {
                    Name = "Black Widow",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vel eros orci. Integer dictum pretium imperdiet. In tellus ligula, vestibulum vel orci et, dictum accumsan magna. Sed porttitor ligula sit amet sem tristique aliquet. Sed porta magna non enim fringilla placerat. Praesent volutpat congue purus, at ullamcorper magna aliquet ut. Vestibulum at pellentesque sapien. Phasellus eu mattis mauris. Sed pharetra maximus dolor ut rutrum. Quisque commodo magna a enim pulvinar sollicitudin.",
                    Image = "https://res.cloudinary.com/goofy5752/image/upload/v1568712498/HeroUploads/blackwidow-img_kvu6ch.jpg",
                    CoverImage = "https://res.cloudinary.com/goofy5752/image/upload/v1568712498/HeroUploads/blackwidow-cover_kuhthy.jpg"
                };

                heroList.Add(blackwidow);

                var blackpanther = new Hero
                {
                    Name = "Black Panther",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vel eros orci. Integer dictum pretium imperdiet. In tellus ligula, vestibulum vel orci et, dictum accumsan magna. Sed porttitor ligula sit amet sem tristique aliquet. Sed porta magna non enim fringilla placerat. Praesent volutpat congue purus, at ullamcorper magna aliquet ut. Vestibulum at pellentesque sapien. Phasellus eu mattis mauris. Sed pharetra maximus dolor ut rutrum. Quisque commodo magna a enim pulvinar sollicitudin.",
                    Image = "https://res.cloudinary.com/goofy5752/image/upload/v1568712497/HeroUploads/black-panther-img_ea6z3e.jpg",
                    CoverImage = "https://res.cloudinary.com/goofy5752/image/upload/v1568712498/HeroUploads/black-panther-cover_gulfqb.jpg"
                };

                heroList.Add(blackpanther);

                _dbContext.Heroes.AddRange(heroList);
                _dbContext.SaveChangesAsync();
            }
        }
    }
}
