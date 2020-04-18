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

public class ColorChagne : MonoBehaviour
{
    Renderer blutrend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #region private Byeong
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "바보")
        {
           // print("들어옴");
            blutrend = this.transform.GetComponent<Renderer>();
            blutrend.material.SetColor("_Color", Color.red);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "바보")
        {
           // print("기나감");
            blutrend = this.transform.GetComponent<Renderer>();
            blutrend.material.SetColor("_Color", Color.white);
        }
    }
    #endregion
}
