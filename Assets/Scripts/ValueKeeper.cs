using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ValueKeeper : MonoBehaviour
{
    int save;
    readonly List<char> progress = new();
    public void StartGame(int saveNumber, string scene)
    {
        DontDestroyOnLoad(gameObject);
        save = saveNumber;

        char[] cArray;
        cArray = PlayerPrefs.GetString("save" + save).ToCharArray();

        foreach (char c in cArray)
        {
            progress.Add(c);
        }

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
