
public class Avion
{
    //Campos EV2324
    private float Altura;
    private float Velocidad;
    private float Combustible;
    private int Orientacion;

    //Propiedades EV2324
    public float Altura
    {
        set
        {
            Altura = value;
        }
    }

    public float Velocidad
    {
        set
        {
            Velocidad = value;
        }
    }

    public float Combustible
    {
        set
        {
            Combustible = value;
        }
    }
    public int Orientacion
    {
        set
        {
            Orientacion = value;
        }
    }

    //Constructor EV2324
    public Avion(float altura, float velocidad, float combustible, int orientacion)
    {
        this.Altura = altura;
        this.Velocidad = velocidad;
        this.Combustible = combustible;
        this.Orientacion = orientacion;
    }

   //Métodos EV2324
    public void Virar(int grados)
    {
        Orientacion = (Orientacion + grados) % 360; 

        ConsumirFuel(grados * 0.1);
    }

    public void Ascender(float metros)
    {
        Altura = Altura + metros; 

        ConsumirFuel(metros * 0.3);
    }

    public void Descender(float metros)
    {
        Altura = Altura - metros;

        if (Altura < 0)
        {
            Altura = 0;
        }
    }

    private void ConsumirFuel(float litros)
    {
        Combustible = Combustible - litros;

        if (Combustible < 0)
        {
            Combustible = 0;
        }
    }
}
