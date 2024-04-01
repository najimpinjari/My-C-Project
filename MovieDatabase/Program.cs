using System;
using System.Collections.Generic;
using System.Linq;

class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
    public int ReleaseYear { get; set; }
    public List<string> Cast { get; set; }

    public Movie(string title, string genre, string director, int releaseYear, List<string> cast)
    {
        Title = title;
        Genre = genre;
        Director = director;
        ReleaseYear = releaseYear;
        Cast = cast;
    }

    public override string ToString()
    {
        return $"Title: {Title}\nGenre: {Genre}\nDirector: {Director}\nRelease Year: {ReleaseYear}\nCast: {string.Join(", ", Cast)}\n";
    }
}

class MovieDatabase
{
    private List<Movie> movies;

    public MovieDatabase()
    {
        movies = new List<Movie>();
    }

    public void AddMovie(string title, string genre, string director, int releaseYear, List<string> cast)
    {
        movies.Add(new Movie(title, genre, director, releaseYear, cast));
        Console.WriteLine("Movie added successfully.");
    }

    public List<Movie> SearchByTitle(string title)
    {
        return movies.Where(movie => movie.Title.ToLower().Contains(title.ToLower())).ToList();
    }

    public List<Movie> SearchByGenre(string genre)
    {
        return movies.Where(movie => movie.Genre.ToLower().Contains(genre.ToLower())).ToList();
    }

    public void DisplayMovieDetails(List<Movie> movies)
    {
        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MovieDatabase database = new MovieDatabase();

        // Adding sample movies
        database.AddMovie("Inception", "Sci-Fi", "Christopher Nolan", 2010, new List<string> { "Leonardo DiCaprio", "Joseph Gordon-Levitt", "Ellen Page" });
        database.AddMovie("The Shawshank Redemption", "Drama", "Frank Darabont", 1994, new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton" });

        Console.WriteLine("Welcome to the Movie Database!");
        Console.WriteLine("1. Add a new movie");
        Console.WriteLine("2. Search movies by title");
        Console.WriteLine("3. Search movies by genre");
        Console.WriteLine("Enter your choice:");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter movie title: ");
                string title = Console.ReadLine();
                Console.Write("Enter movie genre: ");
                string genre = Console.ReadLine();
                Console.Write("Enter movie director: ");
                string director = Console.ReadLine();
                Console.Write("Enter release year: ");
                int releaseYear = int.Parse(Console.ReadLine());
                Console.Write("Enter cast members (comma-separated): ");
                List<string> cast = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
                database.AddMovie(title, genre, director, releaseYear, cast);
                break;
            case 2:
                Console.Write("Enter movie title to search: ");
                string searchTitle = Console.ReadLine();
                var moviesByTitle = database.SearchByTitle(searchTitle);
                database.DisplayMovieDetails(moviesByTitle);
                break;
            case 3:
                Console.Write("Enter movie genre to search: ");
                string searchGenre = Console.ReadLine();
                var moviesByGenre = database.SearchByGenre(searchGenre);
                database.DisplayMovieDetails(moviesByGenre);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
