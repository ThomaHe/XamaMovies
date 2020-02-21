using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamaMovies.Models;
using Xamarin.Forms;

namespace XamaMovies
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public IList<Movie> Movies { get; private set; }
        public MainPage()
        {
            InitializeComponent();

            Movies = new List<Movie>();
            Movies.Add(new Movie
            {
                Title = "Spygame",
                Poster = "https://fr.web.img2.acsta.net/medias/nmedia/00/02/33/30/affspy.jpg",
            });
            Movies.Add(new Movie
            {
                Title = "Avengers",
                Poster = "https://fr.web.img2.acsta.net/pictures/19/04/04/09/04/0472053.jpg",
            });
            Movies.Add(new Movie
            {
                Title = "Borat",
                Poster = "https://images-na.ssl-images-amazon.com/images/I/91uhy-BN14L._AC_SY445_.jpg",
            });

            BindingContext = this;
            
        }

        private async Task<List<Movie>> SearchMoviesAsync(string title)
        {
            List<Movie> response = new List<Movie>();
            var baseAddr = new Uri("https://www.omdbapi.com");
            var client = new HttpClient { BaseAddress = baseAddr };

            var returnedJson = await client.GetStringAsync("/api/reviews");
            return response;
        }
        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Movie tappedItem = e.Item as Movie;
        }

    }
}
