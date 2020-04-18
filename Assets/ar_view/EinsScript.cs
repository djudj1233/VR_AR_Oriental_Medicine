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

public class EinsScript : MonoBehaviour
{
    public static float Qm;

    public void McBtnClick()
    { SceneManager.LoadScene("Blut2Wei"); Qm = 001f; }
    public void ShoBtnClick()
    { SceneManager.LoadScene("Blut2Wei"); Qm = 002f; }
    public void KopfBtnClick()
    { SceneManager.LoadScene("Blut2Wei"); Qm = 003f; }
    public void WstBtnClick()
    { SceneManager.LoadScene("Blut3rei"); /*Qm = 004f;*/ }
    public void GGuztu()
    { SceneManager.LoadScene("fragenListe"); }
}
