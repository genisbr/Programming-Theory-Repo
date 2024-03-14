using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject MenuScreen;
    public GameObject PracticeScreen;
    public GameObject GameScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartPractice()
    {
        MenuScreen.SetActive(false);
        PracticeScreen.SetActive(true);
    }
    public void StartGame()
    {
        MenuScreen.SetActive(false);
        GameScreen.SetActive(true);
    }
}
