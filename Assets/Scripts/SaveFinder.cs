using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveFinder : MonoBehaviour
{
    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (PlayerPrefs.GetString("save" + i) != "")
            {
                transform.GetChild(i).transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(i).transform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }

}
