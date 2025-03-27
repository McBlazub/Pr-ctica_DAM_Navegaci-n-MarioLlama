namespace MarioLlama_Navegacion;

public partial class Jabali : ContentPage
{
    /// <summary>
    /// Información del jabalí
    /// </summary>
	public Jabali()
	{
		InitializeComponent();
	}

    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles //Cambia a otra página, mostrandosé lo que hay dentro del BindingContext
        {
            BindingContext = new Class1 
            { 
                Texto = "Jabali" , 
                Texto2 = "\n\nEs una especie de mamífero artiodáctilo de la familia de los suidos." +
                "\nes un mamífero de tamaño mediano provisto de una cabeza grande y alargada, en la " +
                "\nque destacan unos ojos muy pequeños. El cuello es grueso y las patas son muy cortas," +
                "\nlo que acentúa aún más su rechoncho cuerpo. Compensa su mala vista con un importante " +
                "\ndesarrollo del olfato." +
                "\nEs de comportamiento muy sociable, no es muy territorialista y se desplaza en grupos matriarcales."
            }
        });
    }
}