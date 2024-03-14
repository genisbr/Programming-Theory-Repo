using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Triangulo : Poligono 
{
    public Triangulo(float medidaLado) : base(3,medidaLado)
    {
        Debug.Log("Public Triangulo");
    }
   
    public override float CalculaArea() 
    { 
        return (Mathf.Sqrt(3) / 4) * Mathf.Pow(MedidaLado, 2);
    }

}
