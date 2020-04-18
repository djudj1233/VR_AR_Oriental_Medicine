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

public class Leica : MonoBehaviour {
    #region private Leica
    public float schwindigkeit = 0.4f;

    public Transform LeiKa;
    Vector3 leicaPos;

    public Transform MovedCam;
    public Transform schauen;

    // Use this for initialization
    void Start () {
		
	}

    void FixedUpdate()
    {
        MovedCam.transform.position = Vector3.Lerp(MovedCam.transform.position, LeiKa.transform.position, schwindigkeit * Time.deltaTime);
       // MovedCam.transform.LookAt(schauen);//이거 쓰던지

        //Cam.transform.rotation = Quaternion.identity;
        // lok.transform.rotation = Quaternion.identity;
        // Cam.transform.rotation = Quaternion.RotateTowards(transform.rotation, lok.transform.position - Cam.transform.position, speed);

    }
    #endregion
}

