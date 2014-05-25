using UnityEngine;
using System.Collections;

public class GUI_Label_Controller : MonoBehaviour
{

    public Translation translation;

    public UILabel characterName;
    public UILabel race;
    public UILabel raceName;
    public UILabel gender;
    public UILabel genderMale;
    public UILabel genderFemale;


    // Use this for initialization
    void Start()
    {
        RefreshLabels(null);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RefreshLabels(UIPopupList popupList)
    {
        if (popupList != null) translation.SetLanguage(popupList.value);

        characterName.text = translation.GetText("CharacterName");
        race.text = translation.GetText("race");
        raceName.text = translation.GetText("raceName");
        gender.text = translation.GetText("gender");
        genderMale.text = translation.GetText("GenderMale");
        genderFemale.text = translation.GetText("GenderFemale");
    }
}
