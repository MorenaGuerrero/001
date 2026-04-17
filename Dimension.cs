using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
public class Dimension
{
    private double alto;
    private double ancho;
    private double profundidad;

    public Dimension()
    {
        alto = 0;
        ancho = 0;
        profundidad = 0;
    }

    public Dimension(double alto, double ancho, double profundidad)
    {
        this.alto = alto;
        this.ancho = ancho;
        this.profundidad = profundidad;
    }

    public double GetAlto() { return alto; }
    public void SetAlto(double alto) { this.alto = alto; }

    public double GetAncho() { return ancho; }
    public void SetAncho(double ancho) { this.ancho = ancho; }

    public double GetProfundidad() { return profundidad; }
    public void SetProfundidad(double profundidad) { this.profundidad = profundidad; }

    public double GetVolumen()
    {
        return alto * ancho * profundidad;
    }

    public override string ToString()
    {
        return $"Alto: {alto}, Ancho: {ancho}, Profundidad: {profundidad}, Volumen: {GetVolumen()}";
    }
}
}