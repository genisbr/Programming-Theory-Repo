using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poligono : MonoBehaviour
{
    private int numVertices;
    private float medidaLado;

    protected int NumVertices { get => numVertices; set => numVertices = value; }
    protected float MedidaLado { get => medidaLado; set => medidaLado = value; }

    public Poligono() { }

    public Poligono(int numVertices,float medidaLado)
    {
        NumVertices = numVertices;
        MedidaLado = medidaLado;
    }

    public Poligono(float medidaLado)
    {
        this.medidaLado = medidaLado;
    }

    public float CalculaPerimetro() 
    {
        return NumVertices * MedidaLado;
    }
    public virtual float CalculaArea()
    {
        return 0;
    }
    public virtual String Descripción()
    {
        return "Vertex Number: " + NumVertices + "\n "+
               "Size Length: " + MedidaLado;
    }
}
