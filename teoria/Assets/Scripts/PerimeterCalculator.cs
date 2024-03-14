using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PerimeterCalculator : Poligono
{
    //This class is to test the polymorphism for the constructor. so we can generate a poligon that has N number of sides and X length of the sides.
    //After setting them we can get the perimeter as any other polygon. Area will return 0 as it's not overrided.
    public PerimeterCalculator() : base()
    {

    }
    public void SetNumVertex(int numVertex)
    {
        this.NumVertices = numVertex;
    }
    public void SetMedidaLado(int medidaLado)
    {
        this.MedidaLado = medidaLado;
    }
 
}
