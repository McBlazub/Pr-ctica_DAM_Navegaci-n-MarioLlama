namespace MarioLlama_Navegacion;

public partial class Jabali : ContentPage
{
    /// <summary>
    /// Informaci�n del jabal�
    /// </summary>
	public Jabali()
	{
		InitializeComponent();
	}

    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles //Cambia a otra p�gina, mostrandos� lo que hay dentro del BindingContext
        {
            BindingContext = new Class1 
            { 
                Texto = "Jabali" , 
                Texto2 = "\n\nEs una especie de mam�fero artiod�ctilo de la familia de los suidos." +
                "\nes un mam�fero de tama�o mediano provisto de una cabeza grande y alargada, en la " +
                "\nque destacan unos ojos muy peque�os. El cuello es grueso y las patas son muy cortas," +
                "\nlo que acent�a a�n m�s su rechoncho cuerpo. Compensa su mala vista con un importante " +
                "\ndesarrollo del olfato." +
                "\nEs de comportamiento muy sociable, no es muy territorialista y se desplaza en grupos matriarcales."
            }
        });
    }
}