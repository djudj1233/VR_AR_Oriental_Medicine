using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmReadControl : MonoBehaviour
{
	public DBAccess DBaccess;
	GameObject temp = null;

	private void Start()
	{
		ReadAnswer();
	}

	void ReadAnswer()
	{
		DBaccess = new DBAccess();
		string sql = "select * from UserInterview where USERID='" + UserInfo.ConnUserId + "'";
		string[] result = DBaccess.getCheckData(sql);
		int length = result.Length;

		if (ToggleState.toggleState == 1) //문진결과 일때 토글버튼 비활성화
		{
			for (int i = 47; i < 58; i++)
			{
				temp = GameObject.FindWithTag((i + 1).ToString());
				int childCount = temp.transform.GetChildCount(); //태그에 자식 Count
																 //print((i+1)+"번째CHILD!=" + childCount);
				if (i < childCount - 1)
				{
					for (int j = 1; j < childCount; j++)
					{
						GameObject child = temp.transform.GetChild(j).gameObject;
						Toggle tg = child.GetComponent<Toggle>();
						tg.enabled = false;
					}
				}
				else    //마지막문한에 TXTENDING 때문에 새로 처리
				{
					for (int j = 1; j < childCount - 1; j++)
					{
						GameObject child = temp.transform.GetChild(j).gameObject;
						Toggle tg = child.GetComponent<Toggle>();
						tg.enabled = false;
					}
				}
			}
		}

		for (int i = 47; i < 58; i++)
		{
			temp = GameObject.FindWithTag((i + 1).ToString());
			GameObject child = temp.transform.GetChild(int.Parse(result[i])).gameObject;
			//print(i+"tag="+temp.transform.GetChild(int.Parse(result[i])));
			Toggle tg = child.GetComponent<Toggle>();
			tg.isOn = true;
			/*
			print("CHILD=>" + child);
			print("TAG-->" + temp);
			print(i + "==" + result[i]);
			*/
		}
	}
}
