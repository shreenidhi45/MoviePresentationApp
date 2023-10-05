using MyMovieStoreAppClassLibrary;
namespace MoviePresentationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieController controller = new MovieController();
            controller.Start();
        }
    }
}