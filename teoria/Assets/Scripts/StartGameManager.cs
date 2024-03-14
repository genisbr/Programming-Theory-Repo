using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartGameManager : MonoBehaviour
{
    public List<GameObject> poligons;
    private GameObject ActiveGO;
    private Poligono ActivePolygon;
    public TMP_Text Description;
    public TMP_Text CorrectScore;
    public TMP_Text FailScore;
    public TMP_InputField ValueArea;
    public TMP_InputField ValuePerimeter;
    private int Correct;
    private int Fail;
    // Start is called before the first frame update
    void Start()
    {
        Correct = 0;
        Fail = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GenerateRandomPoligon()
    {
        if (ActiveGO != null) { Destroy(ActiveGO); }
        int Random_Sides = Random.Range(3, 6);
        int Random_Length = Random.Range(1, 10);
        GeneratePoligon(Random_Sides, Random_Length);
        if (ActivePolygon != null)
        {
            UpdateInfo(ActivePolygon.Descripcion());

        }
    }
    private void UpdateInfo(string Descripcion)
    {
        Description.text = Descripcion;
    }

    public void SendResult()
    {
        float AreaValue = float.Parse(ValueArea.text);
        int PerimetroValue = int.Parse(ValuePerimeter.text);
        if (ActivePolygon.CalculaArea() == AreaValue && ActivePolygon.CalculaPerimetro() == PerimetroValue)
        {
            Correct++;
        }
        else
        {
            Fail++;
        }
        Destroy(ActiveGO);
        CorrectScore.text = "Correct: " + Correct;
        FailScore.text = "Fail: " + Fail;
        ValuePerimeter.text = "";
        ValueArea.text = "";
        GenerateRandomPoligon();
    }

    private void GeneratePoligon(int random_Sides, int random_Length)
    {
        
        switch (random_Sides)
        {
            case 3:
                ActiveGO = Instantiate<GameObject>(poligons[0]);
                break;
            case 4:
                ActiveGO = Instantiate<GameObject>(poligons[1]);
                break;
            case 5:
                ActiveGO = Instantiate<GameObject>(poligons[2]);           
                break;
        }
        ActivePolygon = ActiveGO.GetComponent<Poligono>();
        ActivePolygon.SetLengthSide(random_Length);
        ActivePolygon.SetNumSides(random_Sides);
    }
}
