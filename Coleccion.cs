using System;
using System.Collections.Generic;
using System.Text;

namespace TP1 
{
public class Coleccion
{
    private string nombreColeccion;
    private List<Figura> listaFiguras;

    public Coleccion(string nombre)
    {
        nombreColeccion = nombre;
        listaFiguras = new List<Figura>();
    }

    public string GetNombreColeccion() { return nombreColeccion; }
    public void SetNombreColeccion(string nombre) { nombreColeccion = nombre; }

    public void AnadirFigura(Figura fig)
    {
        listaFiguras.Add(fig);
    }

    public void SubirPrecio(double cantidad, string id)
    {
        foreach (Figura fig in listaFiguras)
        {
            if (fig.GetCodigo().Equals(id))
            {
                fig.SubirPrecio(cantidad);
                break;
            }
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Colección: " + nombreColeccion);

        foreach (Figura fig in listaFiguras)
        {
            sb.AppendLine(fig.ToString());
            sb.AppendLine("----------------");
        }

        return sb.ToString();
    }

    public string ConCapa()
    {
        StringBuilder sb = new StringBuilder();

        foreach (Figura fig in listaFiguras)
        {
            if (fig.GetSuperheroe().GetCapa())
            {
                sb.AppendLine(fig.ToString());
            }
        }

        return sb.ToString();
    }

    public Figura MasValioso()
    {
        if (listaFiguras.Count == 0) return null;

        Figura max = listaFiguras[0];

        foreach (Figura fig in listaFiguras)
        {
            if (fig.GetPrecio() > max.GetPrecio())
            {
                max = fig;
            }
        }

        return max;
    }

    public double GetValorColeccion()
    {
        double total = 0;

        foreach (Figura fig in listaFiguras)
        {
            total += fig.GetPrecio();
        }

        return total;
    }

    public double GetVolumenColeccion()
    {
        double total = 0;

        foreach (Figura fig in listaFiguras)
        {
            total += fig.GetDimensiones().GetVolumen();
        }

        return total + 200;
    }
}
}