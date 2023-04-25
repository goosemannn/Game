using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KillCounter : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int kills = 0;

    public void addToKillCounter()
    {
        kills += 1;
        text.text = kills.ToString();
    }

}
