using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pentagono : Poligono 
{
    public Pentagono(float medidaLado) : base(5,medidaLado)
    {

    }
   
    public override float CalculaArea() 
    { 
        return (5/4)*Mathf.Tan(54)*Mathf.Pow(MedidaLado, 2);
    }
    public override String Descripción()
    {
        return "Vertex Number: " + NumVertices + "\n " +
               "Size Length: " + MedidaLado+"\n " +
               "Remember it's 5/2*l*a";
    }
}
