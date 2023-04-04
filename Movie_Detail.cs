using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class Movie_Detail : Form
    {
        String MovieTitle;
        public Movie_Detail()
        {
            InitializeComponent();
            
        }
        public Movie_Detail(string movieTitle)
        {
            InitializeComponent();
            MovieTitle = movieTitle;
            lbl1.Text = MovieTitle;
        }
        
    }
}
