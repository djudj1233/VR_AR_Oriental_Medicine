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

public class naechtePart : MonoBehaviour
{
    [Header("MooM")]
    public Button Nbts;
    public Toggle[] tG;
    private ColorBlock theColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		/*
        #region private ToG
        if (tG[0].isOn == true || tG[1].isOn == true || tG[2].isOn == true || tG[3].isOn == true || tG[4].isOn == true)
        {
            theColor.highlightedColor = Color.magenta;
            theColor.normalColor = Color.red;
            theColor.pressedColor = Color.green;
            theColor.colorMultiplier = 1;
            theColor.fadeDuration = 0.1f;
            Nbts.colors = theColor;
            print("changed");
        }
        #endregion
		*/
    }
}
