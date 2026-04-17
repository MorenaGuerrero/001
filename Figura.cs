using System;
using System.Collections.Generic;
using System.Text;

namespace TP1 
{
public class Figura
{
    private string codigo;
    private double precio;
    private Superheroe superheroe;
    private Dimension dimensiones;

    public Figura(string codigo, double precio, Dimension dimensiones, Superheroe superheroe)
    {
        this.codigo = codigo;
        this.precio = precio;
        this.dimensiones = dimensiones;
        this.superheroe = superheroe;
    }

    public string GetCodigo() { return codigo; }
    public void SetCodigo(string codigo) { this.codigo = codigo; }

    public double GetPrecio() { return precio; }
    public void SetPrecio(double precio) { this.precio = precio; }

    public Superheroe GetSuperheroe() { return superheroe; }
    public void SetSuperheroe(Superheroe superheroe) { this.superheroe = superheroe; }

    public Dimension GetDimensiones() { return dimensiones; }
    public void SetDimensiones(Dimension dimensiones) { this.dimensiones = dimensiones; }

    public void SubirPrecio(double cantidad)
    {
        precio += cantidad;
    }

    public override string ToString()
    {
        return $"Codigo: {codigo}, Precio: {precio}\n{superheroe}\n{dimensiones}";
    }
}
}