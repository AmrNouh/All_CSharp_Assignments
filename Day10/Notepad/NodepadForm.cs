namespace Notepad
{
    public partial class Frm_Home : Form
    {
        string path = null;
        public Frm_Home()
        {
            InitializeComponent();
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            if (txt_area.Text != "")
            {
                Btn_Save_Click(null, null);
            }
            txt_area.Text = "";
            path = null;
        }

        private void Btn_newWindow_Click(object sender, EventArgs e)
        {
            Frm_Home frm = new Frm_Home();
            frm.Show();

        }

        private void Btn_open_Click(object sender, EventArgs e)
        {
            if (opndlog.ShowDialog() == DialogResult.OK)
            {
                path = opndlog.FileName;
                txt_area.LoadFile(path);
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (path == null)
                Btn_saveAs_Click(null, null);
            else
            {
                txt_area.SaveFile(path);
                MessageBox.Show("Saved successfully", "Save");
            }
        }

        private void Btn_saveAs_Click(object sender, EventArgs e)
        {
            if (savedlog.ShowDialog() == DialogResult.OK)
            {
                path = savedlog.FileName;
                txt_area.SaveFile(path);
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_fontEdit_Click(object sender, EventArgs e)
        {
            if (dlog_font.ShowDialog() == DialogResult.OK)
            {
                if (txt_area.SelectedText != "")
                {
                    txt_area.SelectionFont = dlog_font.Font;
                }
                else
                {
                    txt_area.Font = dlog_font.Font;
                }
            }
        }

        private void Btn_colorEdit_Click(object sender, EventArgs e)
        {
            if (dlog_color.ShowDialog() == DialogResult.OK)
            {
                if (txt_area.SelectedText != "")
                    txt_area.SelectionColor = dlog_color.Color;
                else
                    txt_area.ForeColor = dlog_color.Color;
            }
        }
    }
}