/*
Copyright(c)2019 BadCompany All rights reserved.
Copyright(c)2019 by BadCompany. All pictures cannot be copied without permission. 

This presentation is protected by U.S. and International Copyright laws. Reproduction and distribution of the
presentation without written permission of sponsor is prohibited.
©2019 BadCompany & Owner of Bad.co
*/
#region private Kam
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Indai : MonoBehaviour {


    static WebCamTexture backCam;
   

    void Start()
    {
        if (backCam == null)
            backCam = new WebCamTexture();

        GetComponent<Renderer>().material.mainTexture = backCam;

        if (!backCam.isPlaying)
            backCam.Play();

    }

    void Update()
    {
         
    }
}
#endregion