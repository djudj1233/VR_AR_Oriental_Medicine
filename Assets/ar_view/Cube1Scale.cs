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

public class Cube1Scale : MonoBehaviour {
    //  public Transform fuerPos;
    public Transform pp;
    public Transform ysl;
    public Transform cha;
    // Use this for initialization
    void Start () {
        Vector3 temp = this.transform.localScale;
        Vector3 Ptemp = this.transform.position;

        pp.gameObject.SetActive(true);
        ysl.gameObject.SetActive(false);
        cha.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 temp = this.transform.localScale; 

       
        temp.x = Mathf.Clamp(temp.x, 1.5f, 6.5f);
        temp.y = Mathf.Clamp(temp.y, 1.5f, 6.5f);
        temp.z = Mathf.Clamp(temp.z, 1.5f, 6.5f);
        this.transform.localScale = temp;
        if (temp.y >= 1f && temp.y < 3.0f)
        {
            pp.gameObject.SetActive(true);
            ysl.gameObject.SetActive(false);
            cha.gameObject.SetActive(false);
        }
        if (temp.y >= 3.0f && temp.y <= 4.5f)
        {
            pp.gameObject.SetActive(false);
            ysl.gameObject.SetActive(true);
            cha.gameObject.SetActive(false);
        }
        if (temp.y > 4.5f && temp.y <= 6.5f)
        {
            pp.gameObject.SetActive(false);
            ysl.gameObject.SetActive(false);
            cha.gameObject.SetActive(true);
        }
        /*  if (this.transform.localScale.x >= 4f || this.transform.localScale.y >= 4f || this.transform.localScale.z >= 4f)
          {
              print("크구만");
              Vector3 Ptemp = this.transform.position;
              Ptemp.x = Mathf.Clamp(Ptemp.x, -6f, 6f);
              Ptemp.y = Mathf.Clamp(Ptemp.y, -10f, 0.5f);
              Ptemp.z = Mathf.Clamp(Ptemp.z, -7f, 2.2f);
          }
          else
          {
              print("작구만");
              Vector3 Ptemp = this.transform.position;
              Ptemp.x = Mathf.Clamp(Ptemp.x, -2f, 2f);
              Ptemp.y = Mathf.Clamp(Ptemp.y, -2.7f, 1.2f);
              Ptemp.z = Mathf.Clamp(Ptemp.z, -4f, 1.12f);
          }
          */
        /*if (this.transform.localScale.x >= 2f || this.transform.localScale.x < 4f || this.transform.localScale.y >= 2f || this.transform.localScale.y < 4f || this.transform.localScale.z >= 2f || this.transform.localScale.z < 4f)
        { // 찍어보고 바꿀 것.
            print("작구만");
            Vector3 Ptemp = this.transform.position;
            Ptemp.x = Mathf.Clamp(Ptemp.x, -2f, 2f);
            Ptemp.y = Mathf.Clamp(Ptemp.y, -2.7f, 1.2f);
            Ptemp.z = Mathf.Clamp(Ptemp.z, -4f, 1.12f);
        }*/
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);


        if (pos.x < 0f) pos.x = 0f;

        if (pos.x > 1f) pos.x = 1f;

        if (pos.y < -5f) pos.y = -2f;

        if (pos.y > 1f) pos.y = 1f;


        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
