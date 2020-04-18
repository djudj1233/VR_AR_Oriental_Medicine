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

public class Movingscript3 : MonoBehaviour {     // 이건 이상없음.
    public Transform Cam;
    public Transform tar;
    public Transform lok;
    public float speed = 0.3f;

    Vector3 CamOriginPos;

	// Use this for initialization
	void Start () {
        //CamOriginPos = Cam.transform.position; // 원래 자리 저장해놔야 나중에 돌아오지.
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Cam.transform.position = Vector3.Lerp(Cam.transform.position, tar.transform.position, speed * Time.deltaTime);
        //Cam.transform.LookAt(lok);//이거 쓰던지

        //Cam.transform.rotation = Quaternion.identity;
       // lok.transform.rotation = Quaternion.identity;
       // Cam.transform.rotation = Quaternion.RotateTowards(transform.rotation, lok.transform.position - Cam.transform.position, speed);
           
    }
}
