using DSkin.Forms;

namespace UI.Q
{
    public partial class QForm : DSkinForm
    {
        public QForm()
        {
            InitializeComponent();

            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9);
            this.CaptionOffset = new System.Drawing.Point(5, 0);
            this.CaptionTextRender = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.ShowShadow = true;
            this.ShadowColor = System.Drawing.Color.FromArgb(200, 155, 155, 155);
            this.ShadowWidth = 4;
            this.CaptionColor = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Radius = 4;
            this.CaptionHeight = 25;
        }
    }
}
