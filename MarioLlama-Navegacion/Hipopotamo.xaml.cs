using static System.Net.Mime.MediaTypeNames;

namespace MarioLlama_Navegacion;

public partial class Hipopotamo : ContentPage
{
    /// <summary>
    /// Informaci�n del hipop�tamo
    /// </summary>
	public Hipopotamo()
	{
		InitializeComponent();
	}

    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles //Cambia a otra p�gina, mostrandos� lo que hay dentro del BindingContext
        {
            BindingContext = new Class1
            {
                Texto = "Hipop�tamo",
                Texto2 = "\n\nEste mamifero es un gran mam�fero artiod�ctilo fundamentalmente herb�voro que habita en el �frica subsahariana." +
                 "\nEs un animal semiacu�tico que habita en r�os y lagos y donde machos adultos territoriales con grupos de cinco a treinta" +
                 "\nhembras y j�venes controlan una zona del r�o. Durante el d�a reposan en el agua o en el fango y al anochecer se vuelven m�s " +
                 "\nactivos y salen a comer hierbas terrestres. Es f�cilmente reconocible por su torso en forma de barril, enorme boca y dientes, " +
                 "\ncuerpo con la piel lisa y casi sin pelo, patas rechonchas y su gran tama�o. Es el quinto animal terrestre por su peso (entre 1,5 " +
                 "\ny 3 toneladas), detr�s del rinoceronte " +
                 "\nA pesar de su parecido f�sico con los cerdos y otros ungulados terrestres, sus parientes vivos m�s cercanos son los cet�ceos." +
                 "\nEs, junto al hipop�tamo pigmeo, uno de los dos �nicos miembros actuales de la familia Hippopotamidae."
            }
        });
    }
}