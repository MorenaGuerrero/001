using System;
using System.Collections.Generic;
using System.Text;

namespace TP1 
{
public class Superheroe
{
    private string nombre;
    private string descripcion;
    private bool capa;

    public Superheroe(string nombre)
    {
        this.nombre = nombre;
        this.descripcion = "";
        this.capa = false;
    }

    public string GetNombre() { return nombre; }
    public void SetNombre(string nombre) { this.nombre = nombre; }

    public string GetDescripcion() { return descripcion; }
    public void SetDescripcion(string descripcion) { this.descripcion = descripcion; }

    public bool GetCapa() { return capa; }
    public void SetCapa(bool capa) { this.capa = capa; }

    public override string ToString()
    {
        return $"Nombre: {nombre}, Descripcion: {descripcion}, Capa: {capa}";
    }
}
}