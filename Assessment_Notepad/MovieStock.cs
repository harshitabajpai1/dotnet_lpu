//MovieStock
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//movie class
class Movie{
	public string Title{get; set;}
	public string Artist{get;set;}
	public string Genre{get; set;}
	public int Ratings{get; set;}
}


//program class
class Program{
	public static List<Movie> MovieList = new List<Movie>();
	public void AddMovie(string movieDetails){
		//Accept the comma seperated list and then convert it into movie object
		string[] details = movieDetails.Split(',');
		Movie movieDetail = new Movie(){
			Title = details[0],
			Artist = details[1],
			Genre = details[2],
			Ratings = int.Parse(details[3])
		};
		MovieList.Add(movieDetail);
	}
	public List<Movie> ViewMovieByGenre(string genre){
		var movieByGenre = MovieList.Where( m => m.Genre == genre).ToList();
		return movieByGenre;
		
	}
	public List<Movie> ViewMovieByRatings(){
		var movieByRating = MovieList.OrderBy(m => m.Ratings).ToList();
		return movieByRating;
		
		
	}
	public static void Main(string[] args){
		Program program = new Program();
		
        Console.WriteLine("How many movies do you want to add?");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter movie {i + 1} details in format: Title,Artist,Genre,Ratings");
            string input = Console.ReadLine();
            program.AddMovie(input);
        }

        // View by Genre
        Console.WriteLine("Enter a genre to filter movies:");
        string genreInput = Console.ReadLine();
        var genreMovies = program.ViewMovieByGenre(genreInput);
        Console.WriteLine($"\nMovies in {genreInput} genre:");
        foreach (var movie in genreMovies)
        {
            Console.WriteLine($"{movie.Title} by {movie.Artist}, Rating: {movie.Ratings}");
        }

        // View by Ratings
        var moviesByRatings = program.ViewMovieByRatings();
        Console.WriteLine("Movies sorted by Ratings in ascending order:");
        foreach (var movie in moviesByRatings)
        {
            Console.WriteLine($"{movie.Title} - {movie.Ratings}");
        }

		
		
	}
}