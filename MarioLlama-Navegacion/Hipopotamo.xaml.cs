using static System.Net.Mime.MediaTypeNames;

namespace MarioLlama_Navegacion;

public partial class Hipopotamo : ContentPage
{
    /// <summary>
    /// Información del hipopótamo
    /// </summary>
	public Hipopotamo()
	{
		InitializeComponent();
	}

    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles //Cambia a otra página, mostrandosé lo que hay dentro del BindingContext
        {
            BindingContext = new Class1
            {
                Texto = "Hipopótamo",
                Texto2 = "\n\nEste mamifero es un gran mamífero artiodáctilo fundamentalmente herbívoro que habita en el África subsahariana." +
                 "\nEs un animal semiacuático que habita en ríos y lagos y donde machos adultos territoriales con grupos de cinco a treinta" +
                 "\nhembras y jóvenes controlan una zona del río. Durante el día reposan en el agua o en el fango y al anochecer se vuelven más " +
                 "\nactivos y salen a comer hierbas terrestres. Es fácilmente reconocible por su torso en forma de barril, enorme boca y dientes, " +
                 "\ncuerpo con la piel lisa y casi sin pelo, patas rechonchas y su gran tamaño. Es el quinto animal terrestre por su peso (entre 1,5 " +
                 "\ny 3 toneladas), detrás del rinoceronte " +
                 "\nA pesar de su parecido físico con los cerdos y otros ungulados terrestres, sus parientes vivos más cercanos son los cetáceos." +
                 "\nEs, junto al hipopótamo pigmeo, uno de los dos únicos miembros actuales de la familia Hippopotamidae."
            }
        });
    }
}