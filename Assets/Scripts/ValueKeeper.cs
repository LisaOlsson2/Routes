using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ValueKeeper : MonoBehaviour
{
    int save;
    char[] progress;

    public void StartGame(int saveNumber, string scene)
    {
        DontDestroyOnLoad(gameObject);
        save = saveNumber;
        progress = PlayerPrefs.GetString("save" + save).ToCharArray();
        SceneManager.LoadScene(scene);
    }

    public void SaveAndExit()
    {
        string s = "";

        foreach (char c in progress)
        {
            s += c;
        }

        PlayerPrefs.SetString("save" + save, s);
        SceneManager.LoadScene("Start");
        Destroy(gameObject);
    }
}
