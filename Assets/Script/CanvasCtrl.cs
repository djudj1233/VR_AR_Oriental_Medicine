/*
Copyright(c)2019 BadCompany All rights reserved.
Copyright(c)2019 by BadCompany. All pictures cannot be copied without permission. 

This presentation is protected by U.S. and International Copyright laws. Reproduction and distribution of the
presentation without written permission of sponsor is prohibited.
©2019 BadCompany & Owner of Bad.co
*/
#region private Where
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasCtrl : MonoBehaviour {

    [SerializeField]
    Transform cas;
    float zeit = 0;
    // Use this for initialization
    void Start () {
        cas.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        zeit += Time.deltaTime;
        cas.gameObject.SetActive(true);
        if (zeit >= 5f)
        { cas.gameObject.SetActive(false); }
    }
    public void onClickBtn()
    {
        cas.gameObject.SetActive(true);
    }


}
#endregion
