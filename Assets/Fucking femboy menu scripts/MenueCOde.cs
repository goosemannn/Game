using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenueCOde : MonoBehaviour
{
    public InputField userInput1;
    public string userName;
    public Dropdown Pronowns;
    public int pronownvar;
    public Dropdown Level;
    public int levelvarl;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnSubmitCLick()
    {
        userName = userInput1.text;
        if (userName != "0")
        {
            userName = userInput1.text;
            PlayerPrefs.SetString("userName", userName);
            pronownvar = Pronowns.value + 1;
            PlayerPrefs.SetInt("Pronowns",pronownvar);
            levelvarl = Level.value + 1;
            PlayerPrefs.SetInt("dificulty", levelvarl);
            SceneManager.LoadScene("SampleScene");
        }
    }
}
