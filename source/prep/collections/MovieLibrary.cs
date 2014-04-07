using System;
using System.Collections.Generic;

namespace prep.collections
{
  public class MovieLibrary
  {
    IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;
    }

    public IEnumerable<Movie> all_movies()
    {
      return this.movies;
    }

    public void add(Movie movie)
    {
      this.movies.Add(movie);
    }
    
    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
      IList<Movie>pixarMovies = new List<Movie>();
      foreach (var movie in movies)
      {
        if (movie.production_studio == ProductionStudio.Pixar)
        {
          pixarMovies.Add(movie);
        }
      }
      return pixarMovies;
    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
      IList<Movie> pixarOrDisneyMovies = new List<Movie>();
      foreach (var movie in movies)
      {
        if (movie.production_studio == ProductionStudio.Pixar ||
            movie.production_studio == ProductionStudio.Disney)
        {
          pixarOrDisneyMovies.Add(movie);
        }
      }
      return pixarOrDisneyMovies;
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
      IList<Movie> notPixarMovies = new List<Movie>();
      foreach (var movie in movies)
      {
        if (movie.production_studio != ProductionStudio.Pixar)
        {
          notPixarMovies.Add(movie);
        }
      }
      return notPixarMovies;
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
      IList<Movie> afterYearMovies = new List<Movie>();
      foreach (var movie in movies)
      {
        if (movie.date_published.Year > year)
        {
          afterYearMovies.Add(movie);
        }
      }
      return afterYearMovies;
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
      IList<Movie> betweenYearMovies = new List<Movie>();
      foreach (var movie in movies)
      {
        if (movie.date_published.Year >= startingYear &&
            movie.date_published.Year <= endingYear)
        {
          betweenYearMovies.Add(movie);
        }
      }
      return betweenYearMovies;
    }

    public IEnumerable<Movie> all_kid_movies()
    {
      IList<Movie> kidMovies = new List<Movie>();
      foreach (var movie in movies)
      {
        if (movie.genre == Genre.kids)
        {
          kidMovies.Add(movie);
        }
      }
      return kidMovies;
    }

    public IEnumerable<Movie> all_action_movies()
    {
      IList<Movie> actionMovies = new List<Movie>();
      foreach (var movie in movies)
      {
        if (movie.genre == Genre.action)
        {
          actionMovies.Add(movie);
        }
      }
      return actionMovies;
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }
  }
}
