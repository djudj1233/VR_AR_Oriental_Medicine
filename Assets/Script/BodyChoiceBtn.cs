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

public class BodyChoiceBtn : ObjectBtn{// MonoBehaviour {
    #region private vG
    public Transform tappingPng;
   // float schein = 0f;  // 5초만 보여주기
    bool fick = false;

    int sshow = (int)ShowOn;

    public GameObject Camscript;    // Head
    public GameObject Camscript2;   // Body
    public GameObject Camscript3;   // fuss
    public GameObject Camscript4;   // arme


    [Header("precious")]
    public Transform She;


    [Header("Head")]
    public Button Muri;
    public Transform eins;  // halo 넣을 것.
    public Transform zwei;

    [Header("Body")]
    public Button Body;
    public Transform un;
    public Transform deux;

    [Header("Fuss")]
    public Button fuss;
    public Transform uno;
    public Transform dos;

    [Header("Arme")]
    public Button arm;
    public Transform hana;
    public Transform duel;

    [Header("fragenListe")] 
    public Transform f033;
    public Transform f054;
    public Transform f082;
    public Transform f094;
    public Transform f105;
    public Transform f116;
    public Transform f127;
    public Transform f133;
    public Transform f135;
    public Transform f145;
    public Transform f146;
    #endregion

    // Use this for initialization
    void Start () {
        #region private Sg
        sshow = (int)ShowOn;
       
        tappingPng.gameObject.SetActive(false);

      
        Camscript.gameObject.SetActive(false);
        Camscript2.gameObject.SetActive(false);
        Camscript3.gameObject.SetActive(false);
        Camscript4.gameObject.SetActive(false);

       
        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);

      
        f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        f145.gameObject.SetActive(false);
        f146.gameObject.SetActive(false);
        #endregion
    }

    // Update is called once per frame
    void Update () {
        //Camscript.gameObject.SetActive(false);
        #region private IG
        if (sshow == 33)
        {
            //HeadBtnClick();
            f033_SA();
            fick = false;
            //StartCoroutine("HeadBtnClick_co");
            sshow = 0;
        }

        if (sshow == 54)
        {
            //FussBtnClick();
            f054_SA();
            fick = false;
            //StartCoroutine("HeadBtnClick_co");
            sshow = 0;
        }
        #endregion
        // switch
        #region private swiss
        switch (sshow)
        {
            case 82:
                f082_SA();
                fick = false;
                sshow = 0;
                break;

            case 94:
                f094_SA();
                fick = false;
                sshow = 0;
                break;

            case 105:
                f105_SA();
                fick = false;
                sshow = 0;
                break;

            case 116:
                f116_SA();
                fick = false;
                sshow = 0;
                break;

            case 127:
                f127_SA();
                fick = false;
                sshow = 0;
                break;

            case 133:
                f133_SA();
                fick = false;
                sshow = 0;
                break;

            case 135:
                f135_SA();
                fick = false;
                sshow = 0;
                break;

            case 145:
                f145_SA();
                fick = false;
                sshow = 0;
                    break;

			case 146:
				f146_SA();
				fick = false;
				sshow = 0;
				break;

			default:
                sshow = 0;
                Debug.Log("You've choosen nothing..");
                Debug.Log("Just enjoy the anatomy. Chiao Amigo");
                break;

        }
        #endregion
    }
    #region private FcG
    public void f033_SA()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }
        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = Vector3.zero;
        She.transform.localScale = new Vector3(2, 2, 2);

        f033.gameObject.SetActive(true);
        //다 날려도 가능
        #region protected del
        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);
        #endregion
        #region protected fGroup
        //f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        #endregion
    }
    public void f054_SA()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }
        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = Vector3.zero;
        She.transform.localScale = new Vector3(2, 2, 2);

        f054.gameObject.SetActive(true);
        //다 날려도 가능
        #region protected del
        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);
        #endregion
        #region protected fGroup
        f033.gameObject.SetActive(false);
        //f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        #endregion
    }
    public void f082_SA()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }
        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = Vector3.zero;
        She.transform.localScale = new Vector3(2, 2, 2);

        f082.gameObject.SetActive(true);
        //다 날려줘.
        #region protected del
        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);
        #endregion
        #region protected fGroup
        f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        //f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        #endregion
    }
    public void f094_SA()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }
        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = Vector3.zero;
        She.transform.localScale = new Vector3(2, 2, 2);

        f094.gameObject.SetActive(true);
        //다 날려줘.
        #region protected del
        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);
        #endregion
        #region protected fGroup
        f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        //f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        #endregion
    }
    public void f105_SA()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }
        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = Vector3.zero;
        She.transform.localScale = new Vector3(2, 2, 2);

        f105.gameObject.SetActive(true);
        //다 날려줘.
        #region protected del
        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);
        #endregion
        #region protected fGroup
        f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        //f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        #endregion
    }
    public void f116_SA()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }
        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = Vector3.zero;
        She.transform.localScale = new Vector3(2, 2, 2);

        f116.gameObject.SetActive(true);
        //다 날려줘.
        #region protected del
        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);
        #endregion
        #region protected fGroup
        f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        //f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        #endregion
    }
    public void f127_SA()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }
        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = Vector3.zero;
        She.transform.localScale = new Vector3(2, 2, 2);

        f127.gameObject.SetActive(true);
        //다 날려줘.
        #region protected del
        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);
        #endregion
        #region protected fGroup
        f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        //f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        #endregion
    }
    public void f133_SA()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }

        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = new Vector3(0, -90f, 0);
        She.transform.localScale = new Vector3(2, 2, 2);

        f133.gameObject.SetActive(true);
        //다 날려줘.
        #region protected del
        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);
        #endregion
        #region protected fGroup
        f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        //f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        #endregion
    }
    public void f135_SA()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }

        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = new Vector3(0, -90f, 0);
        She.transform.localScale = new Vector3(2, 2, 2);

        f135.gameObject.SetActive(true);
        //다 날려줘.
        #region protected del
        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);
        #endregion
        #region protected fGroup
        f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        //f135.gameObject.SetActive(false);
        #endregion
    }
    public void f145_SA()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }

        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = new Vector3(0, 0, 0);
        She.transform.localScale = new Vector3(2, 2, 2);

        f145.gameObject.SetActive(true);
        //다 날려줘.
        #region protected del
        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);
        #endregion
        #region protected fGroup
        f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        #endregion
    }
	public void f146_SA()
	{
		if (fick == true) tappingPng.gameObject.SetActive(false);
		else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }

		She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
		She.transform.eulerAngles = new Vector3(0, 0, 0);
		She.transform.localScale = new Vector3(2, 2, 2);

		f146.gameObject.SetActive(true);
		//다 날려줘.
		#region protected del
		eins.gameObject.SetActive(false);
		zwei.gameObject.SetActive(false);
		un.gameObject.SetActive(false);
		deux.gameObject.SetActive(false);
		uno.gameObject.SetActive(false);
		dos.gameObject.SetActive(false);
		hana.gameObject.SetActive(false);
		duel.gameObject.SetActive(false);
		#endregion
		#region protected fGroup
		f033.gameObject.SetActive(false);
		f054.gameObject.SetActive(false);
		f082.gameObject.SetActive(false);
		f094.gameObject.SetActive(false);
		f105.gameObject.SetActive(false);
		f116.gameObject.SetActive(false);
		f127.gameObject.SetActive(false);
		f133.gameObject.SetActive(false);
		f135.gameObject.SetActive(false);
		#endregion
	}
	#endregion
	#region private first Model
	public void HeadBtnClick()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }

        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = Vector3.zero;
        She.transform.localScale = new Vector3(2, 2, 2);

        Camscript.gameObject.SetActive(true);

        eins.gameObject.SetActive(true);
        zwei.gameObject.SetActive(true);
        // 나머지는 false 시켜야지 지것만 나오게.

        //f033.gameObject.SetActive(false);

        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);
        // 여기서 부턴 질문링크드 객체
        #region protected fGroup
        f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        #endregion

    }

    public void BodyBtnClick()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }

        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = Vector3.zero;
        She.transform.localScale = new Vector3(2, 2, 2);

        Camscript2.gameObject.SetActive(true);

        un.gameObject.SetActive(true);
        deux.gameObject.SetActive(true);
        //====================
        //f033.gameObject.SetActive(false);

        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);
        //
        #region protected fGroup
        f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        #endregion
    }

    public void FussBtnClick()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }

        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = Vector3.zero;
        She.transform.localScale = new Vector3(2, 2, 2);

        Camscript3.gameObject.SetActive(true);

        uno.gameObject.SetActive(true);
        dos.gameObject.SetActive(true);
        //=====
        //f033.gameObject.SetActive(false);

        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        hana.gameObject.SetActive(false);
        duel.gameObject.SetActive(false);
        //
        #region protected fGroup
        f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        #endregion
    }

    public void ArmBtnClick()
    {
        if (fick == true) tappingPng.gameObject.SetActive(false);
        else { tappingPng.gameObject.SetActive(true); StartCoroutine("fickRe"); }

        She.transform.position = new Vector3(0.03f, 0.84f, -3.01f);
        She.transform.eulerAngles = new Vector3(0,-90f,0);
        She.transform.localScale = new Vector3(2, 2, 2);

        Camscript4.gameObject.SetActive(true);

        hana.gameObject.SetActive(true);
        duel.gameObject.SetActive(true);
        //=====
        f033.gameObject.SetActive(false);

        eins.gameObject.SetActive(false);
        zwei.gameObject.SetActive(false);
        un.gameObject.SetActive(false);
        deux.gameObject.SetActive(false);
        uno.gameObject.SetActive(false);
        dos.gameObject.SetActive(false);
        //
        #region protected fGroup
        f033.gameObject.SetActive(false);
        f054.gameObject.SetActive(false);
        f082.gameObject.SetActive(false);
        f094.gameObject.SetActive(false);
        f105.gameObject.SetActive(false);
        f116.gameObject.SetActive(false);
        f127.gameObject.SetActive(false);
        f133.gameObject.SetActive(false);
        f135.gameObject.SetActive(false);
        #endregion
    }
    #endregion
    #region private Corou
    IEnumerator fickRe()
    {
        //print("코쟁이");
        fick = true;
        yield return new WaitForSeconds(4f);
        tappingPng.gameObject.SetActive(false);
    }
    #endregion
}
