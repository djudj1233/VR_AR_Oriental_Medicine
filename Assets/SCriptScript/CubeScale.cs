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

public class CubeScale : MonoBehaviour {
   
    // Use this for initialization
    void Start () {
        Vector3 temp = this.transform.localScale;
        print(temp.x);
        print(temp.y);
        print(temp.z);

     
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 temp = this.transform.localScale;
        //  if (this.transform.localScale.x >= 3f)
        //  { temp.x = 3f; }
        //print(temp.x);
        //print(temp.y);
        // print(temp.z);
        temp.x = Mathf.Clamp(temp.x, 1.5f, 5.5f);
        temp.y = Mathf.Clamp(temp.y, 1.5f, 5.5f);
        temp.z = Mathf.Clamp(temp.z, 1.5f, 5.5f);
        this.transform.localScale = temp;

        #region private Seks
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

        if (pos.x < 0f) pos.x = 0f;

        if (pos.x > 1f) pos.x = 1f;

        if (pos.y < 0f) pos.y = 0f;

        if (pos.y > 1f) pos.y = 1f;


        transform.position = Camera.main.ViewportToWorldPoint(pos);
        #endregion
    }
}
