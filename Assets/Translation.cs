using UnityEngine;
using System.Collections;
using SimpleXMLTranslation;
using System;

public class Translation : MonoBehaviour
{
    private SimpleTranslation translation;

    public ENUMS.LANGUAGES language = ENUMS.LANGUAGES.english;

    // Use this for initialization
    void Awake()
    {
        string filePath = (Application.dataPath+"/").Replace("/","\\");
        string fileName = "Translation.xml";

        Debug.Log(filePath+fileName);
        translation = new SimpleTranslation(filePath, fileName,"english");
        //translation = new SimpleTranslation(filePath, fileName);
        
        Debug.Log(translation.GetLanguages()[0]);

        translation.SetLanguage(language.ToString());

    }

    // Update is called once per frame
    void Update()
    {

    }

    public string GetText(string keyword)
    {
        return translation.GetText(keyword);
    }

    public void SetLanguage(string language)
    {
        SetLanguage((ENUMS.LANGUAGES) Enum.Parse(typeof(ENUMS.LANGUAGES), language));
    }

    public void SetLanguage(ENUMS.LANGUAGES language)
    {
        this.language = language;
        translation.SetLanguage(this.language.ToString());
    }
}
