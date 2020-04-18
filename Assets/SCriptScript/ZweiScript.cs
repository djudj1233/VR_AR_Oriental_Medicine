/* #region private Copyright
Copyright(c)2019 BadCompany All rights reserved.
Copyright(c)2019 by BadCompany. All pictures cannot be copied without permission. 

This presentation is protected by U.S. and International Copyright laws. Reproduction and distribution of the
presentation without written permission of sponsor is prohibited.
©2019 BadCompany & Owner of Bad.co
#endregion
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZweiScript : EinsScript //: MonoBehaviour
{
    #region public VaG
    lotteCost Lc;
    
    public static int Sc;
    public static int ScV; // = (int)lotteCost.Bm;
    public Transform paek;
    public Toggle eiai;
    Renderer reEnd;
    Touch ttouch;
    bool adios = true;
    Renderer[] reEnds;
    public Transform[] zg;
    private Transform z01;
    private Transform z02;
    private float touchDDuration = 0f;

    [Header("머리혈자리")] // 혈자리 설명
    public Transform TaeYang;
    public Transform Pungji;
    public Transform HundertMal;

    [Header("팔혈자리")]
    public Transform GyenU;
    public Transform GyeonJung;
    public Transform Taechung;

    [Header("근육")]
    public Transform[] GeonYuk;
    // public Transform Susnag;
    // public Transform Gyeonjeong;
    //  public Transform CheonJong;
    // public Transform Pungsi;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        #region private SG
        Sc = (int)Qm;
        ScV = (int)lotteCost.Bm;

        //print("제대로 넘어왔니" + Sc);
        print("골드" + ScV);
        //
        for (int i = 1; i < zg.Length; i++)
        { zg[i].gameObject.SetActive(false); }
        paek.gameObject.SetActive(true);
        //
        TaeYang.gameObject.SetActive(false);
        Pungji.gameObject.SetActive(false);
        HundertMal.gameObject.SetActive(false);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        ScV = (int)lotteCost.Bm;
        //print(ScV);
        #region private ScSwi
        switch (Sc)
        {
            case 001:
                Zeig01Obj();
                Sc = 0;
                
                break;
            case 002:
                Zeig02Obj();
                Sc = 0;
                break;
            case 003:
                Zeig03Obj();
                Sc = 0;
                break;
            default:
                Sc = 0;
                break;
        }
        #endregion
        #region private ScVswi
        switch (ScV)
        {
            case 001:
                Zeig01Obj();
                Sc = 0;
               // ScV = 0;
                break;
            case 002:
                Zeig02Obj();
                Sc = 0;
               // ScV = 0;
                break;
            case 003:
                Zeig03Obj();
                Sc = 0;
               // ScV = 0;
                break;
            default:
                Sc = 0;
                //ScV = 0;
                break;
        }
        #endregion
        //print("제대로 넘어왔니" + Sc);
       // print("SCV : " + ScV);
        #region private eiai
        if (eiai.isOn == false)
        { paek.gameObject.SetActive(false); }
        else { paek.gameObject.SetActive(true); }
        #endregion
        #region private touchStart
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null && adios == true)
                {
                    PrintdieName(hit.transform.gameObject);
                    printtheTag(hit.transform.gameObject);

                    //sek.text = hit.transform.gameObject.name;
                    //seki4.text = hit.transform.gameObject.tag;

#if UNITY_EDITOR
                    //StartCoroutine("dich", hit.transform.gameObject);
#endif
                    reEnd = hit.transform.GetComponentInChildren<Renderer>();
                   // reEnds = hit.transform.GetComponentsInChildren<Renderer>();   === 1

                    reEnd.material.SetColor("_Color", Color.yellow); // Random.ColorHSV()
                    print("들어오긴 하냐");                                            // for (int i = 0; i < reEnds.Length; i++)   === 1 
                    adios = false;                                   // { reEnds[i].material.SetColor("_Color", Random.ColorHSV()); } === 1

                  /*  switch (reEnd.material.color == Color.yellow)
                    {
                        default:
                            break;
                    }*/

                    switch (hit.transform.gameObject.name)
                    {
                        case "태양혈":
                            if (reEnd.material.color == Color.yellow)
                            {
                                TaeYang.gameObject.SetActive(true);
                                Pungji.gameObject.SetActive(false);
                                HundertMal.gameObject.SetActive(false);
                            }
                            else
                            {
                                TaeYang.gameObject.SetActive(false);
                                Pungji.gameObject.SetActive(false);
                                HundertMal.gameObject.SetActive(false);
                            }
                            break;

                        case "풍지혈":
                            TaeYang.gameObject.SetActive(false);
                            Pungji.gameObject.SetActive(true);
                            HundertMal.gameObject.SetActive(false);
                            break;

                        case "백회혈":
                            TaeYang.gameObject.SetActive(false);
                            Pungji.gameObject.SetActive(false);
                            HundertMal.gameObject.SetActive(true);
                            break;

                        case "견우혈":
                            GyenU.gameObject.SetActive(true);
                            GyeonJung.gameObject.SetActive(false);
                            Taechung.gameObject.SetActive(false);
                            break;
                        case "견중수혈":
                            GyenU.gameObject.SetActive(false);
                            GyeonJung.gameObject.SetActive(true);
                            Taechung.gameObject.SetActive(false);
                            break;
                        case "태충혈":
                            GyenU.gameObject.SetActive(false);
                            GyeonJung.gameObject.SetActive(false);
                            Taechung.gameObject.SetActive(true);
                            break;
                        case "수삼리혈":
                            for (int i = 0; i < GeonYuk.Length; i++)
                            { GeonYuk[i].gameObject.SetActive(false); }
                            GeonYuk[0].gameObject.SetActive(true);
                            break;
                        case "견정혈":
                            for (int i = 0; i < GeonYuk.Length; i++)
                            { GeonYuk[i].gameObject.SetActive(false); }
                            GeonYuk[1].gameObject.SetActive(true);
                            break;
                        case "천종혈":
                            for (int i = 0; i < GeonYuk.Length; i++)
                            { GeonYuk[i].gameObject.SetActive(false); }
                            GeonYuk[2].gameObject.SetActive(true);
                            break;
                        case "풍시혈":
                            for (int i = 0; i < GeonYuk.Length; i++)
                            { GeonYuk[i].gameObject.SetActive(false); }
                            GeonYuk[3].gameObject.SetActive(true);
                            break;

                        default:
                            break;
                    }
                }

            }
         
        }
        #endregion
        #region protected fucked
        // touch
        /*
        #region private cancel
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null && adios == false)
                {
                    PrintdieName(hit.transform.gameObject);
                    printtheTag(hit.transform.gameObject);             
#if UNITY_EDITOR
                   // StartCoroutine("dich", hit.transform.gameObject);
#endif
                    reEnd = hit.transform.GetComponentInChildren<Renderer>();
                    if (reEnd.material.color == Color.yellow)
                    {
                        print("노란둥이");
                        reEnd.material.SetColor("_Color", Color.green); // Random.ColorHSV()
                        adios = true;
                    }
                }

            }
        
        }
        #endregion
        */
        #endregion
        #region private Tapppp
        if (Input.touchCount > 0)
        { //if there is any touch
            touchDDuration += Time.deltaTime;
            ttouch = Input.GetTouch(0);

            if (ttouch.phase == TouchPhase.Ended && touchDDuration < 0.2f) //making sure it only check the touch once && it was a short touch/tap and not a dragging.
                StartCoroutine("singleOrDoubleorTriple");
        }
        else
            touchDDuration = 0.0f;
    }
    #endregion
    #region private cocungtang
    IEnumerator singleOrDoubleorTriple()
    {
        yield return new WaitForSeconds(0.3f);
        if (ttouch.tapCount == 1)
        {
            Debug.Log("Single");
            /// 여기서
            if (adios == false)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 100.0f))
                {
                    if (hit.transform != null)
                    {
                        //float delta = Time.time - orstzet;
                        //Debug.Log("Delta : " + delta);
                        //if (delta >= 2f)

                        Rigidbody rb;

                        //if (rb = hit.transform.GetComponent<Rigidbody>())
                        //{
                        PrintdieName(hit.transform.gameObject);
                        // hit.transform.gameObject.SetActive(false);
                        // rend = hit.transform.GetComponent<Renderer>();
                        reEnd = hit.transform.GetComponentInChildren<Renderer>();
                        reEnd.material.SetColor("_Color", Color.clear); // Random.ColorHSV()
                        adios = true;

                        //orstzet = 0f;


                    }
                }
            }/// 여기까지 지우면 됨.
        }
        else if (ttouch.tapCount == 2)
        {
            //this coroutine has been called twice. We should stop the next one here otherwise we get two double tap
            //StopCoroutine("singleOrDouble");
            Debug.Log("Double");
            GameObject temp = GameObject.Find("LeanTouch");
            //   temp.SetActive(false); // 린터치 없애는 거였는데 일단 지운다.


            //hitler.Camscript.gameObject.SetActive(false);
            //adolf.CamOrigPos();
            //deutsch.gameObject.SetActive(true);
        }
        else if (ttouch.tapCount == 3)
        {
            Debug.Log("Triple");
            //    lean.SetActive(true); // 린터치 다시 나오게하는 거였는데 일단 지운다.
            //deutsch.gameObject.SetActive(false);
        }
    }
    #endregion

    #region private showing
    void Zeig01Obj()
    {
        zg[0].gameObject.SetActive(true);
        for (int i = 1; i < zg.Length; i++)
        { zg[i].gameObject.SetActive(false); }
    }
    void Zeig02Obj()
    {
        for (int i = 1; i < zg.Length; i++)
        { zg[i].gameObject.SetActive(false); }
        zg[1].gameObject.SetActive(true);
    }
    void Zeig03Obj()
    {
        for (int i = 1; i < zg.Length; i++)
        { zg[i].gameObject.SetActive(false); }
        zg[2].gameObject.SetActive(true);
    }
    #endregion
    #region private mB
    public void PPaek()
    { SceneManager.LoadScene("BlutEins"); Sc = 0; }
    #endregion
    #region private JB
    public void JaPaek()
    { SceneManager.LoadScene("BlutEins"); 
        switch(ScV)
        { 
             case 001:
                SceneManager.LoadScene("acupuncture_ MusclePain_Scene");

                // ScV = 0;
                break;
        case 002:
                SceneManager.LoadScene("acupuncture_ ShoulderPain_Scene");
                // ScV = 0;
                break;
        case 003:
                SceneManager.LoadScene("acupuncture_BackPain_Scene");
                // ScV = 0;
                break;
        //허리는 없다 지금.
        default:
           
            //ScV = 0;
            break;
        }
    }    // 나중에 바꿀것.
    #endregion
    #region oth
    private void PrintdieName(GameObject go)
    {
        print(go.name);
        //StartCoroutine("dich");
    }
    private void printtheTag(GameObject go)
    {
        print("Tag : " + go.gameObject.tag);
    }
    #endregion
}
