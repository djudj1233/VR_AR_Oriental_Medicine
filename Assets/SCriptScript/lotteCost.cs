/*
Copyright(c)2019 BadCompany All rights reserved.
Copyright(c)2019 by BadCompany. All pictures cannot be copied without permission. 

This presentation is protected by U.S. and International Copyright laws. Reproduction and distribution of the
presentation without written permission of sponsor is prohibited.
©2019 BadCompany & Owner of Bad.co
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lotteCost : MonoBehaviour
{
    public static float Bm = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #region protected ScPa
    public void McBtnClick()
    { SceneManager.LoadScene("Blut2Wei"); Bm = 001f; }
    public void ShoBtnClick()
    { SceneManager.LoadScene("Blut2Wei"); Bm = 002f; }
    public void KopfBtnClick()
    { SceneManager.LoadScene("Blut2Wei"); Bm = 003f; }
    public void WstBtnClick()
    { SceneManager.LoadScene("Blut3rei"); /*Bm = 004f;*/ }
    public void GGuztu()
    { SceneManager.LoadScene("fragenListe"); }
    public void JsMcBtnClick()
    { SceneManager.LoadScene("acupuncture_ MusclePain_Scene"); }
    public void JsShoBtnClick()
    { SceneManager.LoadScene("acupuncture_ ShoulderPain_Scene"); }
    public void JsKopBtnClick()
    { SceneManager.LoadScene("acupuncture_BackPain_Scene"); }
    public void JsWstClick()
    { SceneManager.LoadScene("acupuncture_HeadPain_Scene"); }
	public void BackBtn()
	{
		SceneManager.LoadScene("MenuScene");
	}
    public void Imsi()
    { SceneManager.LoadScene("SiBal"); }
    #endregion
}
