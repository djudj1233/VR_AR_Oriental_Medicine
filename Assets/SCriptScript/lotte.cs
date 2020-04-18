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

public class lotte : MonoBehaviour
{
    #region public vvvaarr
    private int wm = 0;
    [Header("muscle")]
    public Text[] mcArr;
    public Text mc;
    public Text mcex;

    string mc1 = "근육";
    string mc2 = "근육통에는 뱀탕이 좋으며 보신탕도 좋습니다. 나중에 한끼하러 가쉴? ㅎㅎ ";
   
    //public Text mct;
    [Header("Heddo")]
    // 나중에 배열로 넣을 것.
    public Text hd;
    public Text hdex;

    string hd1 = "에효";
    string hd2 = "점심에는 한솥갈까 버거킹갈까 맥날을 갈까 고민듕..";
    //
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        //mc.text 
        //string va =  {get { return mc1; } set { mc = mc1; }}
       
        mc.enabled = false;
        mcex.enabled = false;

        hd.enabled = false;
        hdex.enabled = false;
       

    }

    // Update is called once per frame
    void Update()
    {
        print(wm);
        #region private wmSwi
        switch (wm)
        {
            case 1:
                for (int i = 0; i < mcArr.Length; i++)
                {
                    mc.text = mc1;
                    mcex.text = mc2;
                    mcArr[i].enabled = true;
                }
               // mc.enabled = true;
               // mcex.enabled = true;
               // hd.enabled = false;
               // hdex.enabled = false;
                break;

            case 2:
                for (int i = 0; i < mcArr.Length; i++)
                {
                    mcArr[i].enabled = false;
                }
                hd.text = hd1;
                hdex.text = hd2;
                hd.enabled = true;
                hdex.enabled = true;
                break;

            default:
                wm = 0;
                break;
        }
        #endregion
    }
    #region private PassV
    public void mcBtn()
    {
        wm = 1;
    }
    public void koBtn()
    {
        wm = 2;
    }
    public void mmaaiin()
    { SceneManager.LoadScene("BlutEins"); }
    #endregion
}
