
public class Avion
{
    //Campos EV2324
    private float altura;
    private float velocidad;
    private float combustible;
    private int orientacion;

    //Propiedades EV2324
    public float Altura
    {
        set
        {
            altura = value;
        }
    }

    public float Velocidad
    {
        set
        {
            velocidad = value;
        }
    }

    public float Combustible
    {
        set
        {
            combustible = value;
        }
    }
    public int Orientacion
    {
        set
        {
            orientacion = value;
        }
    }

    //Constructor EV2324
    public Avion(float altura, float velocidad, float combustible, int orientacion)
    {
        this.altura = altura;
        this.velocidad = velocidad;
        this.combustible = combustible;
        this.orientacion = orientacion;
    }

   //M�todos EV2324
    public void Virar(int grados)
    {
        orientacion = (orientacion + grados) % 360; 

        ConsumirFuel(grados * 0.1);
    }

    public void Ascender(float metros)
    {
        altura = altura + metros; 

        ConsumirFuel(metros * 0.3);
    }

    public void Descender(float metros)
    {
        altura = altura - metros;

        if (altura < 0)
        {
            altura = 0;
        }
    }

    private void ConsumirFuel(float litros)
    {
        combustible = combustible - litros;

        if (combustible < 0)
        {
            combustible = 0;
        }
    }
}
