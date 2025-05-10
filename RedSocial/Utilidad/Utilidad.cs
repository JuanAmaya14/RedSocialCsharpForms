using System.Windows.Forms;

public static class Utilidad
{

    // Método para mostrar mensaje de información
    public static void MostrarMensajeInformacion(string mensaje)
    {
        MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // Método para mostrar mensaje de advertencia
    public static void MostrarMensajeAdvertencia(string mensaje)
    {
        MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    // Método para mostrar mensaje de error
    public static void MostrarMensajeError(string mensaje)
    {
        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    // Método para mostrar mensaje de confirmación
    public static void MostrarMensajeConfirmacion(string mensaje)
    {
        MessageBox.Show(mensaje, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
