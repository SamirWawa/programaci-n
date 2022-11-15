internal partial class Program
{
    private static void Main(string[] args)
    {
        /*EJERCICIO 10
        Introduce por teclado una secuencia de calificaciones de los alumnos de un instituto
        (números enteros entre cero y diez).
        La secuencia termina con la introducción de un número menor que cero o mayor que
        diez.
        Se supone que como máximo podemos tener 25 alumnos.
        Se trata de obtener la frecuencia de las notas (número de veces que cada nota
        aparece).
        💡 Pista: Puedes usar un array para guardar las frecuencias, relacionando la posición del
        array con la nota del alumno. Incrementando el contenido de la posición i , cada vez que
        salga una nota n .
        Ejemplo: Imagina que tengo 10 notas notas = [2][4][4][5][5][5][6][7][7][9]
        En un array de tamaño 11 llamado frecuenciaNotas = [0][0][0][0][0][0][0][0][0][0][0]
        guardaremos la cuenta de cada una de ellas. Fíjate, que los índices en ese array van del 0 al
        10 que son los posibles valores válidos de notas. Por tanto, en la posición de índice 5
        guardaremos la cuenta de las veces que ha aparecido la nota 5 en notas que es 3.
        Al final del proceso de notas el array frecuenciaNotas quedará ...
        0 1 2 3 4 5 6 7 8 9 10
        [ 0 ][ 0 ][ 1 ][ 0 ][ 2 ][ 3 ][ 1 ][ 2 ][ 0 ][ 1 ][ 0 ]*/

        char[] calificaciones=new char[25];
        int[] frecuencia = new int[11];
        string aux ="";
        int nota=default;

        do
        {
            Console.WriteLine("Introduzca notas entre 0 y 10");
            nota = int.Parse(Console.ReadLine());
            aux+=nota.ToString();
        }while(nota>0 || nota<10);

        for(int j=0;j<aux.Length;j++)
        {
            calificaciones[j]=aux[j];
        }

        for(int i=0;i<calificaciones.Length;i++)
        {
            if(calificaciones[i]==0)
                frecuencia[0]+=1;

            if(calificaciones[i]==1)
                frecuencia[1]++;
            
            if(calificaciones[i]==2)
                frecuencia[2]++;

            if(calificaciones[i]==3)
                frecuencia[3]++;

            if(calificaciones[i]==4)
                frecuencia[4]++;

            if(calificaciones[i]==5)
                frecuencia[5]++;
            
            if(calificaciones[i]==6)
                frecuencia[6]++;
            
            if(calificaciones[i]==7)
                frecuencia[7]++;
            
            if(calificaciones[i]==8)
                frecuencia[8]++;

            if(calificaciones[i]==9)
                frecuencia[9]++;
            
            if(calificaciones[i]==10)
                frecuencia[10]++;
        }
        Console.WriteLine(frecuencia);
    }
}