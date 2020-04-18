/* #region private Copyright
Copyright(c)2019 BadCompany All rights reserved.
Copyright(c)2019 by BadCompany. All pictures cannot be copied without permission. 

This presentation is protected by U.S. and International Copyright laws. Reproduction and distribution of the
presentation without written permission of sponsor is prohibited.
©2019 BadCompany & Owner of Bad.co
#endregion
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrageSceneCtrl : MonoBehaviour
{
    public static float qM = 0;
    public static float Xm = 0; // 몸0 머리1 다리2  팔3 주소증
    #region private ScN
    private void Update()
    {
        print("qM : " + qM);
    }
    public void F033_Btn()
    {
        SceneManager.LoadScene("ManUtd_BtnAni");
        //DontDestroyOnLoad
        qM = 33;
        Xm = 200;
    }
    public void F054_Btn()
    {
        SceneManager.LoadScene("ManUtd_BtnAni");
        //DontDestroyOnLoad
        qM = 54;
        Xm = 200;
    }
    public void F082_Btn()
    {
        SceneManager.LoadScene("ManUtd_BtnAni");
        qM = 82;
        Xm = 200;
    }
    public void F094_Btn()
    {
        SceneManager.LoadScene("ManUtd_BtnAni");
        qM = 94;
        Xm = 200;
    }
    public void F105_Btn()
    {
        SceneManager.LoadScene("ManUtd_BtnAni");
        qM = 105;
    }
    public void F116_Btn()
    {
        SceneManager.LoadScene("ManUtd_BtnAni");
        qM = 116;
        Xm = 201;
    }
    public void F127_Btn()
    {
        SceneManager.LoadScene("ManUtd_BtnAni");
        qM = 127;
        Xm = 203;
    }
    public void F133_Btn()
    {
        SceneManager.LoadScene("ManUtd_BtnAni");
        qM = 133;
        Xm = 203;
    }
    public void F135_Btn()
    {
        SceneManager.LoadScene("ManUtd_BtnAni");
        qM = 135;
        Xm = 203;
    }
    public void F145_Btn()
    {
        SceneManager.LoadScene("ManUtd_BtnAni");
        qM = 145;
        Xm = 202;
    }
	public void F146_Btn()
	{
		SceneManager.LoadScene("ManUtd_BtnAni");
		qM = 146;
		Xm = 202;
	}
    public void scene()
    { SceneManager.LoadScene("ManUtd_BtnAni"); }
    #endregion
}
