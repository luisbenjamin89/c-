namespace Ejemplo_herencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animalito = new Animal("perro", 5.5f, true, false);
            Ballena willy = new Ballena("willy", 10.5f, true, true, 30);
            Canguro jack = new Canguro("jack", 20.5f, true, true, 20);
            //acciones de animal
            animalito.MostrarDatos();
            animalito.RespirarAire();
            animalito.Existir();

            //acciones de ballena
            willy.MostrarDatos();
            willy.RespirarAire();
            willy.Existir();
            willy.ComerFocas(5); 

            //acciones de canguro
            jack.MostrarDatos();
            jack.RespirarAire();
            jack.Existir();
            jack.saltar();


        }
    }
}
