class TablaImpares:TablaEnteros
{
    private int dimension;
    public TablaImpares(int dimension):base(dimension)
    {
        this.dimension=dimension;
        GuardarNumerosEnTabla();
    }
    public override void GuardarNumerosEnTabla()
    {
        int num=0;
        Random semilla=new Random();
        for(int i=0;i<tabla.Length;i++)
        {
            num= semilla.Next(-10,10);
            if(num%2==0)
                tabla[i]=num;
            else
                i--;
        }
    }
}