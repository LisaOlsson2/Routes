using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    ValueKeeper valueKeeper;

    private void Start()
    {
        valueKeeper = FindObjectOfType<ValueKeeper>();
    }

    public void Exit()
    {
        valueKeeper.SaveAndExit();
    }
    public void NewGame(Transform save)
    {
        int saveNumber = save.GetSiblingIndex();
        PlayerPrefs.SetString("save" + saveNumber, ":");
        valueKeeper.StartGame(saveNumber, "GameGame");
    }
    public void LoadGame(Transform save)
    {
        valueKeeper.StartGame(save.GetSiblingIndex(), "Game");
    }
    public void ClearSave(Transform save)
    {
        save.GetChild(1).gameObject.SetActive(false);
        save.GetChild(0).gameObject.SetActive(true);
        PlayerPrefs.SetString("save" + save.GetSiblingIndex(), "");
    }
}
