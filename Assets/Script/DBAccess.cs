using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Mono.Data.Sqlite;
using System.Data;
using UnityEngine.SceneManagement;

public class UserInfo
{
	public static string ConnUserId;
}

public class DBAccess : MonoBehaviour
{
	public IDbConnection dbconn;
	string conn;

	public InputField InputID;
	public InputField InputPW;
	public Text CheckVal;

	// Start is called before the first frame update
	void Start()
    {
		conn = "URI=file:" + Application.dataPath + "/UserDB.db";
		CheckVal.text = "ID PW 입력";
	}

	public void LoginBtn() //로그인 버튼 눌렀을경우
	{
		
		dbconn = (IDbConnection)new SqliteConnection(conn);
		dbconn.Open();
		IDbCommand dbcmd = dbconn.CreateCommand();
		string sql = "select USERID,USERPW from UserInfo where USERID='" + InputID.text+ "'";
		dbcmd.CommandText = sql;

		IDataReader reader = dbcmd.ExecuteReader();

		if(InputID.text != "" && InputPW.text != "")
		{
			//while (reader.Read())
			if(reader.Read())
			{
				string userPW = reader.GetString(1);
				print("USERPW" + userPW);
				if (userPW == InputPW.text)
				{
					UserInfo.ConnUserId = reader.GetString(0);
					print("USERID" + reader.GetString(0));
					SceneManager.LoadScene("MenuScene");
					
				}
				else if (userPW != InputPW.text)
				{
					CheckVal.text = "PW를 잘못입력하였습니다.";
				}
			}
			else
			{
				CheckVal.text = "해당 ID가 존재하지 않습니다.";
			}
		}
		else
		{
			CheckVal.text = "ID 또는 PW를 입력하세요!";
		}
		
		reader.Close();
		reader = null;
		dbcmd.Dispose();
		dbcmd = null;
		ConnClose();
		
		//SceneManager.LoadScene("MenuScene");
	}

	public void AnswerCheck(string question, int answer)
	{
		//print("닶: "+question + "," + answer);
		conn = "URI=file:" + Application.dataPath + "/UserDB.db";
		dbconn = (IDbConnection) new SqliteConnection(conn);
		dbconn.Open();
		IDbCommand dbcmd = dbconn.CreateCommand();
		string sql = "update UserInterview set Q" + question + " = '" + answer + "' where USERID='" + UserInfo.ConnUserId + "'";

		dbcmd.CommandText = sql;
		dbcmd.ExecuteNonQuery();

		dbcmd.Dispose();
		dbcmd = null;
		//dbconn.Close();
		//dbconn = null;
		ConnClose();
	}

	public string[] getCheckData(string sql) //체크된 값 받아오기
	{
		conn = "URI=file:" + Application.dataPath + "/UserDB.db";
		dbconn = (IDbConnection)new SqliteConnection(conn);
		dbconn.Open();
		IDbCommand dbcmd = dbconn.CreateCommand();
		dbcmd.CommandText = sql;

		IDataReader reader = dbcmd.ExecuteReader();
		int count = reader.FieldCount - 2; //문제 갯수 컬럼

		string[] answers = new string[count];
		
		if (reader.Read())
		{
			for(int i = 0; i < count; i++)
			{
				answers[i] = reader.GetString(i+2);
				//print(i+ "번쨰 답: "+ answers[i]);
			}
		}
		
		dbcmd.Dispose();
		dbcmd = null;
		dbconn.Close();
		dbconn = null;
		
		return answers;
	}

	public void JoinBtn()
	{

	}

	void ConnClose() //연결 끊기
	{
		print("DB 끊어짐");
		dbconn.Close();
		dbconn = null;
	}
}
