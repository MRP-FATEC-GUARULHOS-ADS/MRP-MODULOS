using System;
using System.Drawing;
using System.Windows.Forms;

public class TextBoxSdC : TextBox
{
    [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
    (
        // X-padding da cimesquerda
        int nLeftRect,
        // Y-padding da cimesquerda
        int nTopRect,
        // X-padding da baixireita
        int nRightRect,
        // Y-padding da baixireita
        int nBottomRect,
        // Raio de arredondezabilidade
        // altura da elipse
        int nheightRect,
        // largura da elipse
        int nweightRect
    );
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        // mude esses valores até achar algum que o agrade
        this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15));
    }
}