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
#region public WayPoint
public class foolWP : MonoBehaviour
{
    public Color lineColor = Color.blue;
    private Transform[] points;

    void OnDrawGizmos()
    {
        // 라인의 색상 지정
        Gizmos.color = lineColor;
        // WayPointGroup 게임 오브젝트 아래에 있는 모든 Point 게임오브젝트 추출
        points = GetComponentsInChildren<Transform>();

        int nextIdx = 1;

        Vector3 currPos = points[nextIdx].position;
        Vector3 nextPos;

        // Point 게임오브젝트를 순회하면서 라인을 그림
        for (int i = 0; i <= points.Length; i++)
        {
            // 마지막 Point일 경우 첫 번째 Point로 지정
            nextPos = (++nextIdx >= points.Length) ? points[1].position :
                points[nextIdx].position;
            // 시작 위치에서 종료 위치까지 라인을 그림
            Gizmos.DrawLine(currPos, nextPos);

            currPos = nextPos;
        }
    }
}
#endregion