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

    public Poligono() { Debug.Log("Public Poligono"); }

    public Poligono(int numVertices,float medidaLado)
    {
        Debug.Log("Public Poligono con parametros");
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
    public virtual String Descripcion()
    {
        return "Vertex Number: " + NumVertices + "\n "+
               "Size Length: " + MedidaLado;
    }
    public void SetNumSides(int numVertex)
    {
        this.NumVertices = numVertex;
    }
    public void SetLengthSide(int medidaLado)
    {
        this.MedidaLado = medidaLado;
    }


}
