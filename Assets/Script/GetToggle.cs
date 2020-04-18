using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GetToggle : MonoBehaviour
{
	public DBAccess dbaccess;

	private List<Toggle> toggles;
	string selectTag;
	string selectTag_value;

	private void Awake()
	{
		this.toggles = GetComponentsInChildren<Toggle>().ToList();
		foreach(Toggle toggle in this.toggles)
		{
			toggle.onValueChanged.AddListener((bool isOn) =>
			{
				if(isOn)
				{
					int nextIndex = this.toggles.IndexOf(toggle); //몇번째 TAG
					selectTag = this.toggles[nextIndex].tag; // 선택된 Tag 값
					//print("nextIndex" + nextIndex);
					SPlitTag(selectTag, nextIndex);
				}
			});
		}
	}

	void SPlitTag(string selectTag, int nextIndex)
	{
		dbaccess = new DBAccess();
		string[] split_txt;
		split_txt = selectTag.Split('.');
		string txtNum = split_txt[0]; //문제번호
		int txtValue = int.Parse(split_txt[1]); //체크된 답

		dbaccess.AnswerCheck(txtNum, txtValue);
	}

	
}
