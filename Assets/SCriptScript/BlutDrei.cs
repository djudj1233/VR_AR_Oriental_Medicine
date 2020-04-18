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
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlutDrei : MonoBehaviour
{
    public Transform Herz;
    public Transform KyengHee;
    public Toggle holyshit;
    public Transform moly;
    float Kpzeit = 0f;

    // Start is called before the first frame update
    void Start()
    {
        holyshit.isOn = true;
        Herz.gameObject.SetActive(true);
        KyengHee.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        #region private scheisse
        Kpzeit += Time.deltaTime;
        if (Kpzeit >= 3f)
        { Herz.gameObject.SetActive(false); KyengHee.gameObject.SetActive(true); }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
               // print("들어오나");
                //Debug.DrawRay(Camera.main.ScreenPointToRay(Input.mousePosition), Vector3.forward, Color.green);
                if (hit.transform != null)
                {
                    //print("엔터~");
                    Rigidbody rb;

                    if (rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        //print("이상하네");
                        PrintName(hit.transform.gameObject);
                    /*if (hit.transform.gameObject.name == "심장")
                    {hit.transform.gameObject.SetActive(false); KyengHee.gameObject.SetActive(true);}*/

                    }
                }
            }
        }
        #endregion
        #region private AiTurnOn/Off
        if (holyshit.isOn == false)
        { moly.gameObject.SetActive(false); }
        else
        { moly.gameObject.SetActive(true); }
        #endregion
    }
    void PrintName(GameObject go) { Debug.Log(go.name); }
    public void maingazua()
    { SceneManager.LoadScene("acupuncture_BackPain_Scene"); }
}
