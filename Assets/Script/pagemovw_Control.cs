using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pagemovw_Control : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
    public void Btn_Body() //문진작성
    {
        SceneManager.LoadScene("BMQ1Body");
    }
	public void Btn_ResultBody() //문진결과
	{
		SceneManager.LoadScene("ResultQ1Body");
	}

    public void Btn_Head()
    {
        SceneManager.LoadScene("BMQ2Head");
    }
	public void Btn_ResultHead()
	{
		SceneManager.LoadScene("ResultQ2Head");
	}

	public void Btn_Leg()
    {
        SceneManager.LoadScene("BMQ3Leg");
    }
	public void Btn_ResultLeg()
	{
		SceneManager.LoadScene("ResultQ3Leg");
	}

	public void Btn_Arm()
    {
        SceneManager.LoadScene("BMQ4Arm");
    }
	public void Btn_ResultArm()
	{
		SceneManager.LoadScene("ResultQ4Arm");
	}

	public void Btn_Symptoms()
    {
        SceneManager.LoadScene("BMQ5Symptoms");
    }

	public void Btn_ResultSymptoms()
	{
		SceneManager.LoadScene("ResultQ5Symptoms");
	}

	// 일단 한번에 다 돌아가는 기능 구현 위해서 추가
	public void JuJangBtn()
    { SceneManager.LoadScene("MenuScene"); }
}
