using System.Drawing;
using System.Windows.Forms;

namespace MRP_Fatec.Elementos
{
    public partial class DetalheSpecPanel : Control
    {
        public Label fakeText = new Label()
        {
            Location = new Point(0, 0),
            Height = 28,
            Dock = DockStyle.Fill,
            Padding = new Padding(6, 3, 0, 3),
            Font = new Font(
                new FontFamily("Microsoft Sans Serif"),
                12
            ),
            ForeColor = SystemColors.ControlText,
            TabIndex = 2
        };
        public TextBoxCE textboxCE = new TextBoxCE()
        {
            Location = new Point(0, 0),
            Dock = DockStyle.Fill,
            TextboxRaio = 6,
            ForeColor = SystemColors.ControlText,
            BorderColor = SystemColors.Control,
            Br = SystemColors.Control,
            TabIndex = 1
        };
        public Label label = new Label()
        {
            Location = new Point(0, 0),
            Height = 21,
            Dock = DockStyle.Top,
            Padding = new Padding(6, 3, 0, 3),
            Font = new Font(
                new FontFamily("Microsoft Sans Serif"),
                9
            ),
            ForeColor = SystemColors.ControlDarkDark,
            TabIndex = 0
        };
        public Button botao = new Button()
        {
            Location = new Point(0, 0),
            Size = new Size(28, 49),
            Dock = DockStyle.Right,
            Font = new Font(
                new FontFamily("Microsoft Sans Serif"),
                15
            ),
            FlatStyle = FlatStyle.Flat,
            Image = MRP_Fatec.Properties.Resources.Edit_icone,
            TabIndex = 3
        };

        public DetalheSpecPanel()
        {
            this.fakeText.Parent = this;
            this.textboxCE.Parent = this;
            this.label.Parent = this;
            this.botao.Parent = this;

            base.Controls.Add(this.fakeText);
            base.Controls.Add(this.textboxCE);
            base.Controls.Add(this.label);
            base.Controls.Add(this.botao);

            this.Text = null;

            this.TabStop = false;
        }
    }
}