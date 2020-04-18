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
#if UNITY_EDITOR
using UnityEditor;
#endif
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using UnityEngine.SceneManagement;

public class ObjectBtn : FrageSceneCtrl{//MonoBehaviour {
										//public FrageSceneCtrl Fc;
	#region public fickVar
	public DBAccess dbaccess;

	public Transform braIn;
    bool bk = true;
    public Transform Cube;
    public Transform frau;
    public Canvas va;
    public Canvas va2;
    public GameObject panel;
    public GameObject panelUno;
    public Toggle how;
    public GameObject lean;
    Touch touch;

    //FrageSceneCtrl fsc;
    public static float ShowOn; // = qM;
    // 문진표
    FrageSceneCtrl Fc;
    public static int stern;
    //근육 / 피부
    public Transform muskel;
    public Transform skkkkiny;
    //
    Renderer rend;  // 색 바꾸기
    bool lutschen = false;
    float orstzet = 0f;
    // 시간 홀드해서 색 바꾸기.
    [Header("pages")]
    public Text sek;
    public Text sek2;
    public Text seki3;
    public Text seki4;

	string selectTag;

    [Header("keine")]
    public Transform deutsch; // leice

    BodyChoiceBtn hitler;
    Movingscript adolf;
    //public Button []bts;
    public Transform btsTemp; // 버튼집합

    float zeit = 0f;
    bool piO = false;   // 캔버스 내 패널이 on되었는지
    float touchDuration;
    #endregion
    // 디비를 할 경우 넘겨줄 값들.
    protected static string Bk; // 이름
    protected static string Ak; // 태그

    private void Start()
    {
        #region private SternB
        braIn.gameObject.SetActive(true);
        Cube.gameObject.SetActive(true);
        frau.gameObject.SetActive(false);
        va.enabled = false;
        panel.gameObject.SetActive(false);
        va2.enabled = false;
        how.gameObject.SetActive(false);
        how.isOn = false;

        sek.enabled = false;
        sek2.enabled = false;
        seki3.enabled = false;
        seki4.enabled = false;

        GameObject temp = GameObject.Find("bts");
        temp.gameObject.SetActive(false);
        deutsch.gameObject.SetActive(false);
        //
        ShowOn = qM;
        print("선택된 질문 : " + ShowOn);
        muskel.gameObject.SetActive(false);
        skkkkiny.gameObject.SetActive(false);

        //stern = (int)FrageSceneCtrl.Xm;   // <= ㅄ인가..진짜.. 상속했는데도 이러네..
        stern = (int)Xm;
        #endregion
    }

    private void Update()
    {
        stern = (int)Xm;

        print("선택된 질문 : " + ShowOn);
        #region private fickBr
        if (bk)
        {
            zeit += Time.deltaTime;
            if (zeit >= 2f)
            { braIn.gameObject.SetActive(false); zeit = 0f; bk = false; }
        }
        #endregion

        #region private GehtLos
        if (Input.GetMouseButtonDown(0))
            {
           // print("터치 먹었냐");
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, 100.0f))
                {
                    if (hit.transform != null)
                    {

                        Rigidbody rb;

                        if (rb = hit.transform.GetComponent<Rigidbody>())
                        {
                        PrintName(hit.transform.gameObject);
                        hit.transform.gameObject.SetActive(false);
                        frau.gameObject.SetActive(true);
                        va.enabled = true;
                        va2.enabled = true;
                        panel.gameObject.SetActive(true);
                        how.gameObject.SetActive(true);
                        how.isOn = true;
                        piO = true;
                        sek.enabled = true;
                        sek2.enabled = true;
                        seki3.enabled = true;
                        seki4.enabled = true;

                        btsTemp.gameObject.SetActive(true);
                    }
                    }
                }
            }

        if (piO)
        {
            /// if(va.enalbled)
            //print(va.enabled);
            zeit += Time.deltaTime;
            //print(zeit);
            if (zeit >= 4f)
            { //va.enabled = false; 
                panel.gameObject.SetActive(false);
                //va.enabled = false;
                //va2.enabled = true;
                how.isOn = false;
                zeit = 0f;
                piO = false;
            }
        }
        #endregion
        /// UI 에 터치 안먹으므로 태핑으로 일단 해봄.
        #region private TTapping
        if (Input.touchCount > 0)
        { //if there is any touch
            touchDuration += Time.deltaTime;
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Ended && touchDuration < 0.2f) //making sure it only check the touch once && it was a short touch/tap and not a dragging.
                StartCoroutine("singleOrDouble");
        }
        else
            touchDuration = 0.0f;
        #endregion

        #region private life is suck.
        Renderer rend;

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null && lutschen == false)
                {
                    PrintName(hit.transform.gameObject);
                    printTag(hit.transform.gameObject);

                    sek.text = hit.transform.gameObject.name;
                    seki4.text = hit.transform.gameObject.tag;
					selectTag = hit.transform.gameObject.tag;

				#if UNITY_EDITOR
					StartCoroutine("dich", hit.transform.gameObject);
                #endif
                    rend = hit.transform.GetComponentInChildren<Renderer>();
                    rend.material.SetColor("_Color", Color.green); // Random.ColorHSV()
                    lutschen = true;
                    orstzet = 0f;
                }

            }
            #region private fucked
            /*if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null && lutschen == true)
                {
                    float delta = Time.time - orstzet;
                    Debug.Log("Delta : " + delta);
                    if (delta >= 2f)
                    {
                        Rigidbody rb;

                        //if (rb = hit.transform.GetComponent<Rigidbody>())
                        //{
                        PrintName(hit.transform.gameObject);
                        // hit.transform.gameObject.SetActive(false);
                        // rend = hit.transform.GetComponent<Renderer>();
                        rend = hit.transform.GetComponentInChildren<Renderer>();
                        rend.material.SetColor("_Color", Color.clear); // Random.ColorHSV()
                        lutschen = false;

                        orstzet = 0f;

                    }
                }
            }*/
            #endregion
        }// 여 선택 췤
        #endregion
        /// 토글이 '온'되었을때
        #region private TgOn
        if (how.isOn == true)
        {
            //va.enabled = true;
            panel.gameObject.SetActive(true);
            panelUno.gameObject.SetActive(true);
        }
        else
        {
            //va.enabled = false;
            panel.gameObject.SetActive(false);
            panelUno.gameObject.SetActive(false);
        }
        #endregion
    }
    #region private othersettings
    public void muskelBtn()
    {
        muskel.gameObject.SetActive(true);
        skkkkiny.gameObject.SetActive(false);
    }
    public void skkiinBtn()
    {
        skkkkiny.gameObject.SetActive(true);
        muskel.gameObject.SetActive(false);
    }
    public void PhilipP()
    {
        muskel.gameObject.SetActive(false);
        skkkkiny.gameObject.SetActive(false);
    }
    public void PaekBtn()
    { SceneManager.LoadScene("FragenScene");  qM = 0; }
    public void PPPaekBtn()
    {
        Bk = "WTF";
        Ak = "WTHELL";

        switch (stern)
        {
            case 200:
            {
				SplitTag(selectTag);
				SceneManager.LoadScene("BMQ1Body"); Xm = 0;
			}
            break;
            case 201:
            {
				SplitTag(selectTag);
				SceneManager.LoadScene("BMQ2Head"); Xm = 0;
			}
            break;
            case 202:
            {
				SplitTag(selectTag);
				SceneManager.LoadScene("BMQ3Leg"); Xm = 0;
			}
            break;
            case 203:
            {
				SplitTag(selectTag);
				SceneManager.LoadScene("BMQ4Arm"); Xm = 0;
			}
            break;

            default:
                break;
        }
    }

	void SplitTag(string selectTag)
	{
		dbaccess = new DBAccess();
		string[] split_txt;
		split_txt = selectTag.Split('.');
		string txtNum = split_txt[0]; //문제번호
		int txtValue = int.Parse(split_txt[1]); //체크된 답
		dbaccess.AnswerCheck(txtNum, txtValue);
	}

	#endregion
	#region private othFc
	public void RzEnter()
    {
        print("들어왔군");
    }
    private void PrintName(GameObject go)
    {
        print(go.name);
        //StartCoroutine("dich");
    }
    private void printTag(GameObject go)
    {
        print("Tag : " + go.gameObject.tag);
    }
    #endregion
    #region private myLove
    IEnumerator singleOrDouble()
    {
        yield return new WaitForSeconds(0.3f);
        if (touch.tapCount == 1)
        {
            Debug.Log("Single");
            /// 여기서
            if (lutschen)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 100.0f))
                {
                    if (hit.transform != null)
                    {
                        float delta = Time.time - orstzet;
                        //Debug.Log("Delta : " + delta);
                        //if (delta >= 2f)
                      
                            Rigidbody rb;

                            //if (rb = hit.transform.GetComponent<Rigidbody>())
                            //{
                            PrintName(hit.transform.gameObject);
                            // hit.transform.gameObject.SetActive(false);
                            // rend = hit.transform.GetComponent<Renderer>();
                            rend = hit.transform.GetComponentInChildren<Renderer>();
                            rend.material.SetColor("_Color", Color.clear); // Random.ColorHSV()
                            lutschen = false;

                            //orstzet = 0f;

                        
                    }
                }
            }/// 여기까지 지우면 됨.
        }
        else if (touch.tapCount == 2)
        {
            //StopCoroutine("singleOrDouble");
            Debug.Log("Double");
            GameObject temp = GameObject.Find("LeanTouch");
            //   temp.SetActive(false); // 린터치 없애는 거였는데 일단 지운다.
            //hitler.Camscript.gameObject.SetActive(false);
            //adolf.CamOrigPos();
            deutsch.gameObject.SetActive(true);
        }
        else if (touch.tapCount == 3)
        {
            Debug.Log("Triple");
            //    lean.SetActive(true); // 린터치 다시 나오게하는 거였는데 일단 지운다.
            deutsch.gameObject.SetActive(false);
        }
    }
    #endregion
    #region private sibal
#if UNITY_EDITOR
    IEnumerator dich(GameObject gay)
    {
        SerializedObject halo = new SerializedObject(gay.gameObject.GetComponent("Halo"));
        halo.FindProperty("m_Size").floatValue += 0.1f;
        if (halo.FindProperty("m_Size").floatValue >= 1f)
        {
            halo.FindProperty("m_Size").floatValue = 0.1f;
        }
        halo.FindProperty("m_Enabled").boolValue = true;
        halo.FindProperty("m_Color").colorValue = Color.green;
        halo.ApplyModifiedProperties();

        yield return new WaitForSeconds(3f);
    }
#endif
}
#endregion


