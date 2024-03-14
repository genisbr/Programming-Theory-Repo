using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cuadrado : Poligono 
{
    public Cuadrado(float medidaLado) : base(4,medidaLado)
    {

    }
   
    public override float CalculaArea()
    { 
        return Mathf.Pow(MedidaLado, 2);
    }

}
