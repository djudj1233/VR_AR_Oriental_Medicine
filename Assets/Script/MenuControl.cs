using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToggleState
{
	public static int toggleState;
}

public class MenuControl : MonoBehaviour
{
	public Text nameTxt;
	public Button writeBtn;
	public Button resultBtn;
	public Button searchBtn;

    // Start is called before the first frame update
    void Start()
    {
		nameTxt.text = UserInfo.ConnUserId;
    }

	public void MedicalWrite()
	{
		SceneManager.LoadScene("BMQ1Body");
	}

	public void MedicalResult()
	{
		ToggleState.toggleState = 1;
		SceneManager.LoadScene("ResultQ1Body");
	}

	public void MedicalSearch()
	{
		SceneManager.LoadScene("acupuncture_ MusclePain_Scene");
	}


    // Update is called once per frame
    void Update()
    {
        
    }
}
