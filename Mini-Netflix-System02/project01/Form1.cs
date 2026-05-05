using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project01
{
    public partial class Form1 : Form
    {
        List<Movie> movies = new List<Movie>();

        // FIXED: use YOUR User class
        User user = new User("Shahad");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Welcome " + user.Name;

            movies.Add(new Movie("Clouds", "Drama"));
            movies.Add(new Movie("Five Feet Apart", "Romance"));
            movies.Add(new Movie("Uncharted", "Action"));
            movies.Add(new Movie("Deep Water", "Thriller"));
            movies.Add(new Movie("Now You See Me", "Crime"));

            foreach (Movie m in movies)
                comboBoxMovies.Items.Add(m.Title);

            for (int i = 1; i <= 10; i++)
                comboBoxRate.Items.Add(i);

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Movie";
            dataGridView1.Columns[1].Name = "Genre";
            dataGridView1.Columns[2].Name = "Rating";
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            if (comboBoxMovies.SelectedItem == null)
            {
                MessageBox.Show("Select a movie first!");
                return;
            }

            string title = comboBoxMovies.SelectedItem.ToString();
            Movie movie = movies.Find(m => m.Title == title);

            // safety check
            if (movie == null)
            {
                MessageBox.Show("Movie not found!");
                return;
            }

            user.WatchMovie(movie);

            MessageBox.Show("You watched: " + movie.Title);
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            if (comboBoxMovies.SelectedItem == null)
            {
                MessageBox.Show("Select a movie first!");
                return;
            }

            if (comboBoxRate.SelectedItem == null)
            {
                MessageBox.Show("Select a rating!");
                return;
            }

            string title = comboBoxMovies.SelectedItem.ToString();
            Movie movie = movies.Find(m => m.Title == title);

            if (movie == null)
            {
                MessageBox.Show("Movie not found!");
                return;
            }

            if (!user.HasWatched(movie))
            {
                MessageBox.Show("You must watch the movie first!");
                return;
            }

            int rate = Convert.ToInt32(comboBoxRate.SelectedItem);
            movie.Rating = rate;

            // update if already exists
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == movie.Title)
                {
                    row.Cells[2].Value = movie.Rating;
                    return;
                }
            }

            dataGridView1.Rows.Add(movie.Title, movie.Genre, movie.Rating);
        }
    }
}