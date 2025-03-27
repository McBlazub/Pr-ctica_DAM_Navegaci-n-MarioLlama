namespace MarioLlama_Navegacion;

public partial class Rinoceronte : ContentPage
{
    /// <summary>
    /// Información del rinoceronte
    /// </summary>
    public Rinoceronte()
    {
        InitializeComponent();
    }

    private void DetallesBTN(object sender, EventArgs e)
     {
         Navigation.PushAsync(new Detalles //Cambia a otra página, mostrandosé lo que hay dentro del BindingContext
         {
             BindingContext = new Class1 
             {
                 Texto = "\nRinoceronte",
                 Texto2 = "\n\nEste mamifero se trata de un animal placentario del suborden ceratomorfos perteneciente al orden de los perisodáctilos." +
                 "\nDestaca por sus característicos cuernos en el hocico, su fuerte coraza y gran tamaño, siendo de las pocas especies consideradas como" +
                 "\nmegafauna existentes hoy día, junto con elefantes e hipopótamos; todas las especies pueden sobrepasar como mínimo la tonelada de peso." +
                 "\nActualmente existen cinco especies: el rinoceronte blanco y el rinoceronte negro en África y el rinoceronte de Java, el rinoceronte" +
                 "\nde la India y el rinoceronte de Sumatra en Asia. Según la clasificación de estado de conservación confeccionada por la Unión Internacional " +
                 "\npara la Conservación de la Naturaleza, las especies de rinocerontes de Java, Sumatra y negro se encuentran en «peligro crítico»; el de" +
                 "\nla India se considera «vulnerable» y el blanco «casi amenazado»."
             }

         });


     }

}