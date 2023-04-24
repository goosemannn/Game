using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathscreen : MonoBehaviour
{
	public void OnButtonClick()
	{
		SceneManager.LoadScene("SampleScene");
	}
}
