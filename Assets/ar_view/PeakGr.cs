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

public class PeakGr : MonoBehaviour
{
    static WebCamTexture PaekKam;

    void Start()
    {
        if (PaekKam == null)
            PaekKam = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = PaekKam;

        if (!PaekKam.isPlaying)
            PaekKam.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
