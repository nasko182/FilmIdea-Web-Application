﻿namespace FilmIdea.Data.Seed;

using Models;

public class ReviewSeeder
{
    public ICollection<Review> GenerateReviews()
    {
        return new HashSet<Review>()
        {
            new Review()
            {
                MovieId = 2,
                Content = "I like the movie",
                CriticId = Guid.Parse("BCC5C503-128B-4BA6-A736-6EFBEDA1EE34"),
                Rating = 9
            }
        };
    }
}
