using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : MonoBehaviour
{
    public static event Action SettingLanguage;
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("language"))
        {
            PlayerPrefs.SetString("language", "FA");
        }
        SettingLanguage?.Invoke();
    }
    public void SettingLanguageEN()
    {
        AudioManagerMainMenu.instance.PlayChangeSound();
        PlayerPrefs.SetString("language", "EN");
        SettingLanguage?.Invoke();
    }
    public void SettingLanguageFA()
    {
        AudioManagerMainMenu.instance.PlayChangeSound();
        PlayerPrefs.SetString("language", "FA");
        SettingLanguage?.Invoke();
    }
}