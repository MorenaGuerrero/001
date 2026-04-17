using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
class Program
{
    static void Main(string[] args)
    {
        Superheroe spiderman = new Superheroe("Spiderman");
        spiderman.SetDescripcion("Traje rojo y azul");
        spiderman.SetCapa(false);

        Dimension dim = new Dimension(10, 5, 2);

        Figura figura = new Figura("F001", 150, dim, spiderman);

        Coleccion coleccion = new Coleccion("Marvel");
        coleccion.AnadirFigura(figura);

        System.Console.WriteLine(coleccion.ToString());
    }
}
}