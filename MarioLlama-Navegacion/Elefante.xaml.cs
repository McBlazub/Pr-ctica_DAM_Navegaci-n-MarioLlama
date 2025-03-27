namespace MarioLlama_Navegacion;

public partial class Elefante : ContentPage
{
    /// <summary>
    /// Información del elefante
    /// </summary>
    public Elefante()
	{
		InitializeComponent();
	}

    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles //Cambia a otra página, mostrandosé lo que hay dentro del BindingContext
        {
            BindingContext = new Class1
            {
                Texto = "Elefante",
                Texto2 = "\n\nPertenece a la familia de mamíferos placentarios del orden proboscideos. Antiguamente se clasificaban, junto con otros mamíferos" +
                "\nde piel gruesa, en el orden, ahora inválido, de los paquidermos. Existen hoy en día tres especies y diversas subespecies. " +
                "\nEntre los géneros extintos de esta familia destacan los mamuts." +
                "\nLos elefantes son los animales terrestres más grandes que existen en la actualidad." +
                "\nLos elefantes actuales se clasifican en dos géneros distintos, Loxodonta (elefantes africanos) y Elephas (elefantes asiáticos), pertenecientes " +
                "\na dos tribus distintas."
            }
        });
    }
}