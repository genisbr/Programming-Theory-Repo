using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PracticeManager : MonoBehaviour
{
    public TMPro.TMP_InputField Sides;
    public TMPro.TMP_InputField Length;
    public TMP_Text Result;
    public PerimeterCalculator PC;
    
    public void Calculate()
    {
        int sides = (int)float.Parse(Sides.text);
        int length = (int)float.Parse(Length.text);
        PC.SetMedidaLado(length);
        PC.SetNumVertex(sides);
        Result.text = "Result: " + ( PC.CalculaPerimetro() );
    }
}
