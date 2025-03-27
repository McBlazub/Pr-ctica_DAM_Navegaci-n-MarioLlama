namespace MarioLlama_Navegacion;

public partial class Elefante : ContentPage
{
    /// <summary>
    /// Informaci�n del elefante
    /// </summary>
    public Elefante()
	{
		InitializeComponent();
	}

    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles //Cambia a otra p�gina, mostrandos� lo que hay dentro del BindingContext
        {
            BindingContext = new Class1
            {
                Texto = "Elefante",
                Texto2 = "\n\nPertenece a la familia de mam�feros placentarios del orden proboscideos. Antiguamente se clasificaban, junto con otros mam�feros" +
                "\nde piel gruesa, en el orden, ahora inv�lido, de los paquidermos. Existen hoy en d�a tres especies y diversas subespecies. " +
                "\nEntre los g�neros extintos de esta familia destacan los mamuts." +
                "\nLos elefantes son los animales terrestres m�s grandes que existen en la actualidad." +
                "\nLos elefantes actuales se clasifican en dos g�neros distintos, Loxodonta (elefantes africanos) y Elephas (elefantes asi�ticos), pertenecientes " +
                "\na dos tribus distintas."
            }
        });
    }
}