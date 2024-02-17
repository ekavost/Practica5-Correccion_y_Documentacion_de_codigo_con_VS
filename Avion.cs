
public class Avion
{
    public Avion(float altura, float velocidad, float combustible, int orientacion)
    {
        this.Altura = altura;
        this.Velocidad = velocidad;
        this.Combustible = combustible;
        this.Orientacion = orientacion;
    }

    public float Altura
    {
        get 
        { 
            return Altura; 
        }
    }

    public int Orientacion
    {
        get
        {
            return Orientacion;
        }
    }
    //EV2324
    public void Virar(int grados)
    {
        Orientacion = (Orientacion + grados) % 360; 

        ConsumirFuel(grados * 0.1);
    }

    public float Combustible
    { 
        get 
        { 
            return Combustible; 
        } 
    }
    //Metodos que sirve para ascender los metros indicados

    public void Ascender(float metros) //M son los metros
    {
        Altura = Altura + metros; 

        ConsumirFuel(metros * 0.3);
    }
    //Metodos que sirve para descender los metros indicados

    public void Descender(float metros)
    {
        Altura = Altura - metros;

        if (Altura < 0)
        {
            Altura = 0;
        }
    }

    private float Altura;
    private float Velocidad; // Velocidad del avion
    private float Combustible; 
    private int Orientacion;

    private void ConsumirFuel(float litros)
    {
        Combustible = Combustible - litros;

        if (Combustible < 0)
        {
            Combustible = 0;
        }
    }
}
