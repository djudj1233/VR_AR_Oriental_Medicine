using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JHM : MonoBehaviour
{
    public Transform sib;
    public Transform body;
    public Transform Neuf;
    private float Taima = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Neuf.transform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Taima += Time.deltaTime;

        sib.transform.Rotate(Vector3.up * Time.deltaTime * 60f);
        body.transform.Translate(Vector3.up * Time.deltaTime * 0.4f);
        if (Taima >= 5f)
        {
            Neuf.transform.gameObject.SetActive(true);
            Neuf.transform.Rotate(-Vector3.up * Time.deltaTime * 10f);
            Taima = 0f;
        }
        if (body.transform.position.y >= 2.75f) { body.gameObject.SetActive(false);//Destroy(body.gameObject); 
        }
        Vector3 temp = Neuf.transform.eulerAngles;
        temp.y = Mathf.Clamp(temp.y, 2.2f, 180);
        Neuf.transform.eulerAngles = temp;
        if (Neuf.transform.eulerAngles.y == 2.2f)
        { Neuf.transform.gameObject.SetActive(false); }
    }
    public void MunBtn()
    { SceneManager.LoadScene("BMQ1Body"); }
    public void GyeonBtn()
    { SceneManager.LoadScene("acupuncture_ MusclePain_Scene"); }
}
