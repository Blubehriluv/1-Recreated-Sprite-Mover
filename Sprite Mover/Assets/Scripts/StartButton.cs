using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject thisMenu;
    public GameObject otherMenu;
    // Start is called before the first frame update
    void Start()
    {
        thisMenu = GameObject.Find("MainMenu");
        thisMenu = GameObject.Find("ColorChanger");


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScreen()
    {
        Debug.Log("Hi there");
        otherMenu.SetActive(false);
        thisMenu.SetActive(true);
    }
}
