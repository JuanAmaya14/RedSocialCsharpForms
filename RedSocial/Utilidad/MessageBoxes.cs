using System.Windows.Forms;

public static class MessageBoxes
{
    public static void MostrarMensajeInformacion(string mensaje)
    {
        MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void MostrarMensajeAdvertencia(string mensaje)
    {
        MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static void MostrarMensajeError(string mensaje)
    {
        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void MostrarMensajeConfirmacion(string mensaje)
    {
        MessageBox.Show(mensaje, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
