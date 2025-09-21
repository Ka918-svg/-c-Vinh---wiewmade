using System;
using System.Drawing;
using System.Windows.Forms;

namespace FakeMsgBox
{
    public class MainForm : Form
    {
        public MainForm()
        {
            // Form chính
            this.Text = "Warning";
            this.Size = new Size(400, 200);

            Label lbl = new Label();
            lbl.Text = "The file in trash. Continue?";
            lbl.AutoSize = true;
            lbl.Location = new Point(50, 40);
            this.Controls.Add(lbl);

            // Nút Yes
            Button btnYes = new Button();
            btnYes.Text = "Yes";
            btnYes.Location = new Point(220, 100);
            btnYes.Click += (s, e) =>
            {
                ShowSpamWindows();
            };
            this.Controls.Add(btnYes);

            // Nút No
            Button btnNo = new Button();
            btnNo.Text = "No";
            btnNo.Location = new Point(120, 100);
            btnNo.Click += (s, e) =>
            {
                this.Close(); // hoặc không làm gì
            };
            this.Controls.Add(btnNo);
        }

        private void ShowSpamWindows()
        {
            Random rnd = new Random();

            // Thông báo 1
            Form msg1 = new Form();
            msg1.Text = "Vinh đẹp trai";
            msg1.Size = new Size(300, 150);
            msg1.StartPosition = FormStartPosition.Manual;
            msg1.Location = new Point(rnd.Next(0, Screen.PrimaryScreen.Bounds.Width - 300),
                                      rnd.Next(0, Screen.PrimaryScreen.Bounds.Height - 150));

            Button ok1 = new Button();
            ok1.Text = "OK";
            ok1.Dock = DockStyle.Bottom;
            ok1.Click += (s, e) =>
            {
                msg1.Close();
                ShowSpamWindows(); // bấm OK thì lại tạo thêm
            };
            msg1.Controls.Add(ok1);
            msg1.Show();

            // Thông báo 2
            Form msg2 = new Form();
            msg2.Text = "Được làm bởi Đức Vinh";
            msg2.Size = new Size(350, 180);
            msg2.StartPosition = FormStartPosition.Manual;
            msg2.Location = new Point(rnd.Next(0, Screen.PrimaryScreen.Bounds.Width - 350),
                                      rnd.Next(0, Screen.PrimaryScreen.Bounds.Height - 180));

            Button ok2 = new Button();
            ok2.Text = "OK";
            ok2.Dock = DockStyle.Bottom;
            ok2.Click += (s, e) =>
            {
                msg2.Close();
                ShowSpamWindows(); // bấm OK thì lại tạo thêm
            };
            msg2.Controls.Add(ok2);
            msg2.Show();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
