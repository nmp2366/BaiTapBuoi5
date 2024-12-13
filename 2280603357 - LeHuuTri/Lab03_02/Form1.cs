using System.Drawing.Text;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbVanBan.Clear();

            rtbVanBan.Font = new Font("Tahoma", 12);
            rtbVanBan.ForeColor = Color.Black;

            rtbVanBan.SelectionAlignment = HorizontalAlignment.Left;
        }


        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbVanBan.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|RichText file (*.rtf)|*.rtf";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                try
                {
                    if (Path.GetExtension(selectedFileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        rtbVanBan.LoadFile(selectedFileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        rtbVanBan.LoadFile(selectedFileName, RichTextBoxStreamType.RichText);
                    }

                    MessageBox.Show("Tập tin đã được mở thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình mở tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|RichText files (*.rtf)|*.rtf";
            saveFileDialog.Title = "Lưu Tập Tin Văn Bản";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedFileName = saveFileDialog.FileName;

                    if (Path.GetExtension(selectedFileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        rtbVanBan.SaveFile(selectedFileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        rtbVanBan.SaveFile(selectedFileName, RichTextBoxStreamType.RichText);
                    }

                    MessageBox.Show("Tập tin đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                rtbVanBan.ForeColor = fontDlg.Color;
                rtbVanBan.Font = fontDlg.Font;
            }
        }

        private void btn_indam_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                FontStyle style = rtbVanBan.SelectionFont.Style;
                if (rtbVanBan.SelectionFont.Bold)
                {
                    style &= ~FontStyle.Bold;
                }
                else
                {
                    style |= FontStyle.Bold;
                }

                rtbVanBan.SelectionFont = new Font(rtbVanBan.SelectionFont, style);
            }
        }

        private void loadfont_Click(object sender, EventArgs e)
        {
            foreach (FontFamily fontFamily in new InstalledFontCollection().Families)
            {
                cmbFont.Items.Add(fontFamily.Name);
            }
            cmbFont.SelectedItem = "Tahoma";
        }

        private void loadsize_Click(object sender, EventArgs e)
        {
            int[] sizeValues = new int[] { 8, 9, 10, 11, 12, 13, 14, 15, 16, 18, 20, 22, 24, 26, 28, 30, 36, 48, 72 };
            cmbsize.ComboBox.DataSource = sizeValues;
            cmbsize.SelectedItem = 14;
        }

        private void btn_gacchchan_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                FontStyle style = rtbVanBan.SelectionFont.Style;
                if (rtbVanBan.SelectionFont.Underline)
                {
                    style &= ~FontStyle.Underline;
                }
                else
                {
                    style |= FontStyle.Underline;
                }

                rtbVanBan.SelectionFont = new Font(rtbVanBan.SelectionFont, style);
            }
        }

        private void btn_innghien_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                FontStyle style = rtbVanBan.SelectionFont.Style;
                if (rtbVanBan.SelectionFont.Italic)
                {
                    style &= ~FontStyle.Italic;
                }
                else
                {
                    style |= FontStyle.Italic;
                }

                rtbVanBan.SelectionFont = new Font(rtbVanBan.SelectionFont, style);
            }
        }

        private void btn_TaoFileMoi_Click(object sender, EventArgs e)
        {
            rtbVanBan.Clear();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|RichText files (*.rtf)|*.rtf";
            saveFileDialog.Title = "Lưu Tập Tin Mới";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedFileName = saveFileDialog.FileName;

                    if (Path.GetExtension(selectedFileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        rtbVanBan.SaveFile(selectedFileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        rtbVanBan.SaveFile(selectedFileName, RichTextBoxStreamType.RichText);
                    }

                    MessageBox.Show("Tập tin mới đã được tạo và lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình tạo file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_luuFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|RichText files (*.rtf)|*.rtf";
            saveFileDialog.Title = "Lưu Tập Tin";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedFileName = saveFileDialog.FileName;

                    if (Path.GetExtension(selectedFileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        rtbVanBan.SaveFile(selectedFileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        rtbVanBan.SaveFile(selectedFileName, RichTextBoxStreamType.RichText);
                    }

                    MessageBox.Show("Tập tin đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
