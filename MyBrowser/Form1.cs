using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using System.Drawing;
using MyBrowser;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer1;
        private List<Particle> particles = new List<Particle>();
        private Random random = new Random();

        public static bool GenZMode = false;

        private WebView2 webView;
        private Point closeButtonOriginalLoc;
        private Point minimizeButtonOriginalLoc;
        private Size closeButtonOriginalSize;
        private Size minimizeButtonOriginalSize;

        private TabControl tabControl;
        private List<WebView2> webViews = new List<WebView2>();

        public Form1()
        {
            InitializeComponent();
            InitializeTabControl();
            AddNewTab();

            closeButtonOriginalLoc = closeButton.Location;
            minimizeButtonOriginalLoc = minimizeButton.Location;
            closeButtonOriginalSize = closeButton.Size;
            minimizeButtonOriginalSize = minimizeButton.Size;

            this.Resize += MainForm_Resize;

            if (GenZMode)
            {
                timer1 = new System.Windows.Forms.Timer();
                timer1.Interval = 1;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();
                DoubleBuffered = true;
                background1();
            }
        }
        private void InitializeTabControl()
        {
            tabControl = new TabControl
            {
                Location = new Point(12, 46),
                Size = new Size(976, 542)
            };
            Controls.Add(tabControl);
        }
        private void AddNewTab(string url = "https://cse.google.com/cse?cx=a32a2f51bbb3e4fd7&gsc.tab=0&q=#gsc.tab=0")
        {
            TabPage newPage = new TabPage("New Tab  ×");
            WebView2 newWebView = new WebView2
            {
                Dock = DockStyle.Fill
            };

            newPage.Controls.Add(newWebView);
            tabControl.TabPages.Add(newPage);
            webViews.Add(newWebView);

            // Event-Handler für Mausklick auf Tab
            tabControl.MouseClick += (s, e) =>
            {
                var tabRect = tabControl.GetTabRect(tabControl.SelectedIndex);
                var closeRect = new Rectangle(tabRect.Right - 20, tabRect.Top + 4, 16, 16);

                if (closeRect.Contains(e.Location) && tabControl.SelectedTab == newPage)
                {
                    CloseTab(newPage);
                }
            };

            InitializeWebView(newWebView, url, newPage);
            tabControl.SelectedTab = newPage;
        }
        private async void InitializeWebView(WebView2 webView, string url, TabPage page)
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.Source = new Uri(url);
            webView.NavigationCompleted += (s, e) =>
            {
                page.Text = webView.CoreWebView2.DocumentTitle + "  ×";
                if (page.Text.Length > 25)
                    page.Text = page.Text.Substring(0, 22) + "...  ×";
            };
        }
        private void CloseTab(TabPage page)
        {
            if (tabControl.TabPages.Count > 1)
            {
                var webView = page.Controls.OfType<WebView2>().FirstOrDefault();
                if (webView != null)
                {
                    webViews.Remove(webView);
                    webView.Dispose();
                }
                tabControl.TabPages.Remove(page);
            }
        }
        private async void InitializeBrowser()
        {
            webView = new WebView2
            {
                Location = new Point(12, 46),
                Size = new Size(976, 542)
            };
            Controls.Add(webView);

            await webView.EnsureCoreWebView2Async(null);

            if (webView.CoreWebView2 == null)
            {
                MessageBox.Show("WebView2 was not able to initialize!");
                return;
            }

            webView.Anchor = AnchorStyles.None;
            webView.TabIndex = 0;
            webView.Focus();
            webView.Source = new Uri("https://www.google.com");
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GoButton_Click(sender, e);
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            var currentWebView = tabControl.SelectedTab.Controls.OfType<WebView2>().FirstOrDefault();
            if (currentWebView != null)
            {
                if (urlTextBox.Text.Contains("."))
                {
                    string url = urlTextBox.Text.StartsWith("https://") ? urlTextBox.Text : "https://" + urlTextBox.Text;
                    if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
                    {
                        currentWebView.Source = uri;
                    }
                }
                else
                {
                    currentWebView.Source = new Uri($"https://cse.google.com/cse?cx=a32a2f51bbb3e4fd7&gsc.tab=0&q={urlTextBox.Text}");
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var currentWebView = tabControl.SelectedTab?.Controls.OfType<WebView2>().FirstOrDefault();
            if (currentWebView?.CanGoBack == true)
            {
                currentWebView.GoBack();
            }
        }

        private void ForewardButton_Click(object sender, EventArgs e)
        {
            var currentWebView = tabControl.SelectedTab?.Controls.OfType<WebView2>().FirstOrDefault();
            if (currentWebView?.CanGoForward == true)
            {
                currentWebView.GoForward();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            closeButton.Location = new Point(
                this.ClientSize.Width - closeButtonOriginalSize.Width - 10,
                10
            );
            closeButton.Size = closeButtonOriginalSize;

            minimizeButton.Location = new Point(
                closeButton.Location.X - minimizeButtonOriginalSize.Width - 10,
                10
            );
            minimizeButton.Size = minimizeButtonOriginalSize;

            urlTextBox.Location = new Point(
                (this.ClientSize.Width - urlTextBox.Width) / 2,
                10
            );

            GoButton.Location = new Point(
                urlTextBox.Location.X + urlTextBox.Width + 10,
                urlTextBox.Location.Y
            );

            BackButton.Location = new Point(
                urlTextBox.Location.X - 80,
                urlTextBox.Location.Y
            );

            ForewardButton.Location = new Point(
                urlTextBox.Location.X - 40,
                BackButton.Location.Y
            );

            tabControl.Location = new Point(
                10,
                urlTextBox.Location.Y + urlTextBox.Height + 10
            );
            tabControl.Size = new Size(
                this.ClientSize.Width - 20,
                this.ClientSize.Height - tabControl.Location.Y - 10
            );
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            FormWindowState formWindowState = FormWindowState.Minimized;
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon...");
        }
        private void background1()
        {
            int numParticles = 50;
            for (int i = 0; i < numParticles; i++)
            {
                double angle = random.NextDouble() * 2 * Math.PI;
                double speed = random.Next(1, 3);
                particles.Add(new Particle()
                {
                    Position = new PointF(random.Next(0, ClientSize.Width), random.Next(0, ClientSize.Height)),
                    Velocity = new PointF((float)(Math.Cos(angle) * speed), (float)(Math.Sin(angle) * speed)),
                    Radius = random.Next(2, 5),
                    Color = Color.White
                });
            }
        }

        private void background2()
        {
            float slowFactor = 0.5f;
            foreach (var particle in particles)
            {
                particle.Position = new PointF(
                    particle.Position.X + particle.Velocity.X * slowFactor,
                    particle.Position.Y + particle.Velocity.Y * slowFactor);

                if (particle.Position.X < 0) particle.Position = new PointF(ClientSize.Width, particle.Position.Y);
                if (particle.Position.X > ClientSize.Width) particle.Position = new PointF(0, particle.Position.Y);
                if (particle.Position.Y < 0) particle.Position = new PointF(particle.Position.X, ClientSize.Height);
                if (particle.Position.Y > ClientSize.Height) particle.Position = new PointF(particle.Position.X, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            background2();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            foreach (var particle in particles)
            {
                e.Graphics.FillEllipse(new SolidBrush(particle.Color),
                    particle.Position.X - particle.Radius,
                    particle.Position.Y - particle.Radius,
                    particle.Radius * 2, particle.Radius * 2);

                foreach (var otherParticle in particles)
                {
                    if (particle != otherParticle)
                    {
                        float dx = particle.Position.X - otherParticle.Position.X;
                        float dy = particle.Position.Y - otherParticle.Position.Y;
                        float distance = (float)Math.Sqrt(dx * dx + dy * dy);

                        if (distance < 50)
                        {
                            int alpha = (int)((1.0f - (distance / 50.0f)) * 255.0f);
                            e.Graphics.DrawLine(new Pen(Color.FromArgb(alpha, Color.Magenta), 1),
                                particle.Position, otherParticle.Position);
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void AddTabButton_Click(object sender, EventArgs e)
        {
            AddNewTab();
        }
    }
}
public class Particle
{
    public PointF Position { get; set; }
    public PointF Velocity { get; set; }
    public int Radius { get; set; }
    public Color Color { get; set; }
}