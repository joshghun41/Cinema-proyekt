using Cinema_proyekt.Commands;
using Cinema_proyekt.Models;

using MovieApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Cinema_proyekt.ViewModels
{
    public  class MainViewModel:BaseViewModel
    {
        private List<Movie> movies;
        public List<Movie> Movies
        {
            get
            {
                if (movies == null)
                {
                    return MovieService.GetMovies("movie");
                }
                return MovieService.GetMovies(SearchText);
            }
            set { movies = value; OnPropertyChanged(); }
        }
        public RelayCommand SearchCommand { get; set; }
        private string searchText;
        private string name;
        private string surname;

        public RelayCommand BuyTicketCommand { get; set; }

        public string SearchText
        {
            get { return searchText; }
            set { searchText = value; OnPropertyChanged(); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }


        public string Surname
        {
            get { return surname; }
            set {surname = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            SearchCommand = new RelayCommand((e) =>
            {
                var movies = MovieService.GetMovies(SearchText);
                Movies = movies;
            });

            BuyTicketCommand = new RelayCommand((e) =>
            {
                MessageBox.Show($@"{name} {surname} Buy Ticked");
            });
        }

    }
}
