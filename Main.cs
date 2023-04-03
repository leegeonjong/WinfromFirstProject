namespace TeamProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoginForm lg= new LoginForm();
            lg.Show();
        }
    }
}