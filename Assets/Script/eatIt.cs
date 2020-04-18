/*
Copyright(c)2019 BadCompany All rights reserved.
Copyright(c)2019 by BadCompany. All pictures cannot be copied without permission. 

This presentation is protected by U.S. and International Copyright laws. Reproduction and distribution of the
presentation without written permission of sponsor is prohibited.
©2019 BadCompany & Owner of Bad.co
*/
#region private GaeNoDap
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatIt : MonoBehaviour
{
    //public Transform kli;
    public float sisisisi = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up * sisisisi * Time.deltaTime);   
    }
}
#endregion