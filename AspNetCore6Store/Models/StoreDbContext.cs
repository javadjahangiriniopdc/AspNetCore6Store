﻿using Microsoft.EntityFrameworkCore;

namespace AspNetCore6Store.Models
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        public StoreDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Category = "Mobile",
                    Name = "Apple iPhone 14 Pro Max",
                    Description = "The best iPhone ever, version 2022, size XL - we have the iPhone 14 Pro Max. The list of novelties this year includes the notch morphing into a pill, the introduction of an Always-On display, and an all-new primary camera - and while you can get all of that on the 14 Pro, the extra screen estate and longevity coupled with the Max's 'ultimate' status mean it has a market niche of its own.",
                    Price = 100_000_00
                },
                new Product
                {
                    Id = 2,
                    Category = "Mobile",
                    Name = "Nokia 110 4G (2023)",
                    Description = "Arguably one of the best little phones Nokia ever did was the little metal slightly angled beauty Nokia 6720 classic. Imagine a new version. Wowza",
                    Price = 2_000_000
                },
                new Product
                {
                    Id = 3,
                    Category = "Mobile",
                    Name = "Xiaomi Poco F5 Pro",
                    Description = "Do you remember how the Xiaomi 12S Ultra did not launch outside China even though it had the potential to become one of the bestselling smartphones? Yes, we are still bitter about that, too. But today, we have some sweet, sweet news! The Xiaomi 13 Pro, the company's most current flagship, is what the road to redemption looks like and everyone's chance to own an even better and more refined Ultra ",
                    Price = 10_000_000
                },
                new Product
                {
                    Id = 4,
                    Category = "Laptop",
                    Name = "ProArt Studiobook Pro 16 OLED (W7604)",
                    Description = "The new ProArt Studiobook Pro 16 OLED is a powerful mobile workstation that exceeds all expectations and goes far beyond the extraordinary. Its unstoppable 13th Gen Intel® Core™ i9-13980HX processor, pro-grade NVIDIA RTX™ 3000 Ada Generation Laptop GPU, vast amounts of memory and ultrafast storage will supercharge your content creation workflow and let your imagination do what it does best. The certified color-accurate 16-inch 3.2K 120 Hz OLED touchscreen will do full justice to your creative vision, and you'll enjoy unrivaled precision control of your apps with the large, stylus-compatible haptic touchpad and intuitive ASUS Dial rotary control. Take your creativity to the next level with ProArt Studiobook Pro 16 OLED.",
                    Price = 200_000_00
                },
                 new Product
                 {
                     Id = 5,
                     Category = "Laptop",
                     Name = "ProArt Studiobook 16 3D OLED (H7604)",
                     Description = "The new ProArt Studiobook 16 3D OLED mobile workstation transcends the ordinary, and goes far beyond the extraordinary. Its unstoppable 13th Gen Intel® Core™ i9 HX processor, NVIDIA® GeForce RTX™ 4070 graphics, vast amounts of memory and ultrafast storage will supercharge your content creation workflow and let your imagination do what it does best. The world’s first 16-inch 3.2K 120 Hz 3D OLED display with ASUS Spatial Vision technology provides you with an exceptional glasses-free 3D visual experience, and you’ll enjoy unrivaled precision control of your apps with the large, stylus-compatible haptic touchpad and intuitive ASUS Dial rotary control. Take your creativity beyond the limits with ProArt Studiobook 16 3D OLED",
                     Price = 300_000_000
                 }

                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
