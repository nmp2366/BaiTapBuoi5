namespace _2280603357___LeHuuTri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToString("dd/MM/yyyy");
            var time = DateTime.Now.ToString("hh:mm:ss tt");
            this.toolStripStatusLabel.Text = $"Hôm nay là ngày: {date} - Bây giờ là: {time}";
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Video Files|*.mp4;*.avi;*.mkv;*.wmv"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
