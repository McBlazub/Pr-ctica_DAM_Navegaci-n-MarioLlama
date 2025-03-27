namespace MarioLlama_Navegacion;

public partial class Rinoceronte : ContentPage
{
    /// <summary>
    /// Informaci�n del rinoceronte
    /// </summary>
    public Rinoceronte()
    {
        InitializeComponent();
    }

    private void DetallesBTN(object sender, EventArgs e)
     {
         Navigation.PushAsync(new Detalles //Cambia a otra p�gina, mostrandos� lo que hay dentro del BindingContext
         {
             BindingContext = new Class1 
             {
                 Texto = "\nRinoceronte",
                 Texto2 = "\n\nEste mamifero se trata de un animal placentario del suborden ceratomorfos perteneciente al orden de los perisod�ctilos." +
                 "\nDestaca por sus caracter�sticos cuernos en el hocico, su fuerte coraza y gran tama�o, siendo de las pocas especies consideradas como" +
                 "\nmegafauna existentes hoy d�a, junto con elefantes e hipop�tamos; todas las especies pueden sobrepasar como m�nimo la tonelada de peso." +
                 "\nActualmente existen cinco especies: el rinoceronte blanco y el rinoceronte negro en �frica y el rinoceronte de Java, el rinoceronte" +
                 "\nde la India y el rinoceronte de Sumatra en Asia. Seg�n la clasificaci�n de estado de conservaci�n confeccionada por la Uni�n Internacional " +
                 "\npara la Conservaci�n de la Naturaleza, las especies de rinocerontes de Java, Sumatra y negro se encuentran en �peligro cr�tico�; el de" +
                 "\nla India se considera �vulnerable� y el blanco �casi amenazado�."
             }

         });


     }

}