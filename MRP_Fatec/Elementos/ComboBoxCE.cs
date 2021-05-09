using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MRP_Fatec.Elementos
{
    public partial class ComboBoxCE : Control
    {
        // não mude o raio aqui, mude na tela de design
        private int radius = 15;
        public ComboBox combobox = new ComboBox();
        private GraphicsPath shape;
        private GraphicsPath innerRect;
        private Color br;
        private Color _borderColor = Color.Gray;
        private int _borderSize = 1;

        public ComboBoxCE()
        {
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            this.combobox.Parent = this;
            base.Controls.Add(this.combobox);
            combobox.Font = this.Font;
            combobox.FlatStyle = FlatStyle.Flat;
            combobox.Sorted = true;
            // cores
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Black;
            this.br = Color.White;
            combobox.BackColor = this.br;
            this.Text = null;
            base.Size = new Size(360, 33);

            //this.TabStop = false;
            // adicionando os eventhandlers da combobox
            combobox.KeyDown += new KeyEventHandler(ComboBox_KeyDown);
            combobox.TextChanged += new EventHandler(ComboBox_TextChanged);
            combobox.MouseDoubleClick += new MouseEventHandler(ComboBox_MouseDoubleClick);
            combobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(ComboBox_KeyPress);
        }

        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }

        private void ComboBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                combobox.SelectAll();
            }
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = combobox.Text;
        }

        private void ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                combobox.SelectionStart = 0;
                combobox.SelectionLength = this.Text.Length;
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            combobox.Font = this.Font;
            base.Invalidate();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            combobox.ForeColor = this.ForeColor;
            base.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.shape = new RectCE((float)base.Width, (float)base.Height, (float)this.radius, 0f, 0f).Path;
            this.innerRect = new RectCE(base.Width - 0.5f, base.Height - 0.5f, (float)this.radius, 0.5f, 0.5f).Path;
            if (combobox.Height >= (base.Height - 4))
            {
                base.Height = combobox.Height + 4;
            }
            // margem do texto da combobox
            combobox.Location = new Point(this.radius , (base.Height / 2) - (combobox.Font.Height / 2) - 4);
            combobox.Width = base.Width - ((int)(this.radius * 1.5));
            // pra parar de cortar o 'g'
            combobox.AutoSize = false;

            e.Graphics.SmoothingMode = ((SmoothingMode)SmoothingMode.HighQuality);

            // sei la oq faz isso...
            // Bitmap bitmap = new Bitmap(base.Width, base.Height);
            // Graphics graphics = Graphics.FromImage((Image)bitmap);

            Pen pp = new Pen(_borderColor, _borderSize);
            e.Graphics.DrawPath(pp, this.shape);

            using (SolidBrush brush = new SolidBrush(this.br))
            {
                e.Graphics.FillPath((Brush)brush, this.innerRect);
            }
            Transform.MakeTransparent(this, e.Graphics);
            base.OnPaint(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            combobox.Text = this.Text;
        }
        public void SelectAll()
        {
            combobox.SelectAll();
        }
        public Color Br
        {
            get =>
                this.br;
            set
            {
                this.br = value;
                if (this.br != Color.Transparent)
                {
                    combobox.BackColor = this.br;
                }
                base.Invalidate();
            }
        }
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = Color.Transparent;
        }
        public Color BorderColor
        {
            get =>
                this._borderColor;
            set { this._borderColor = value; Invalidate(); }
        }
        public int ComboBoxRaio
        {
            get =>
                this.radius;
            set { this.radius = value; Invalidate(); }
        }
        public int BorderSize
        {
            get =>
                this._borderSize;
            set { this._borderSize = value; Invalidate(); }
        }
    }
}