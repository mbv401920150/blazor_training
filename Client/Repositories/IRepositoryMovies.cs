using blazor_training.Shared.Entities;

namespace blazor_training.Client.Repositories
{
    public interface IRepositoryMovies
    {
        List<Movie> GetMovies();
    }
}
