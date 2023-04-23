using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenueCOde : MonoBehaviour
{
    public InputField userInput1;
    public string userName;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSubmitCLick()
    {
        userName = userInput1.text;
        if(userName != "0")
        { 
            userName = userInput1.text;
            PlayerPrefs.SetString("userName", userName);
            SceneManager.LoadScene("SampleScene");
        }
    }

}
