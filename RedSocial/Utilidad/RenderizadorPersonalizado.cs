using System.Drawing;
using System.Windows.Forms;

public class RenderizadorPersonalizado : ToolStripProfessionalRenderer
{
    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        base.OnRenderMenuItemBackground(e);

        if (e.Item.Selected)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkOrchid), e.Item.ContentRectangle);
        }
        else
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Indigo), e.Item.ContentRectangle);
        }
    }

    protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
    {
        e.TextColor = Color.White;
        base.OnRenderItemText(e);
    }
}
