using System.Drawing;
using System.Windows.Forms;

namespace MRP_Fatec.Elementos
{
    public partial class SpecPanel : Control
    {
        public TextBoxCE textboxCE = new TextBoxCE()
        {
            Location = new Point(0, 0),
            Dock = DockStyle.Fill,
            TextboxRaio = 6,
            ForeColor = SystemColors.GrayText
        };
        public Panel espacador = new Panel()
        {
            Location = new Point(0, 0),
            Height = 12,
            Dock = DockStyle.Bottom
        };
        public Label label = new Label()
        {
            Location = new Point(0, 0),
            Height = 27,
            Dock = DockStyle.Top,
            Padding = new Padding(6, 6, 0, 6),
            ForeColor = SystemColors.ControlDarkDark,
            Font = new Font(
                new FontFamily("Microsoft Sans Serif"),
                9
            )
        };

        public SpecPanel()
        {
            this.textboxCE.Parent = this;
            this.espacador.Parent = this;
            this.label.Parent = this;

            base.Controls.Add(this.textboxCE);
            base.Controls.Add(this.espacador);
            base.Controls.Add(this.label);

            this.Text = null;

            this.TabStop = false;
        }
    }
}
