using System.Collections.Generic;

namespace project01
{
    public class User
    {
        public string Name { get; set; }

        private int watchCount = 0;
        private List<string> watchedMovies = new List<string>();

        public User(string name)
        {
            Name = name;
        }

        public void WatchMovie(Movie movie)
        {
            watchCount++;
            watchedMovies.Add(movie.Title);
        }

        public bool HasWatched(Movie movie)
        {
            return watchedMovies.Contains(movie.Title);
        }
    }
}