using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupStartMenu : MonoBehaviour
{
    [SerializeField] private Image characterSprite;
    [SerializeField] private InputField inputField;
    [SerializeField] private GameObject informaition;
    [SerializeField] private GameObject selectCharacter;

    private CharacterType characterType;
    public void OnClickCharacter()
    {
        informaition.SetActive(false);
        selectCharacter.SetActive(true);
    }

    public void OnClickSelectCharater(int index) // 0이면 버니, 1이면 비
    {
        characterType = (CharacterType)index;
        var character = GameManager.Instance.CharaterList.Find(item => item.CharacterType == characterType);
        characterSprite.sprite = character.CharaterSprite;
        characterSprite.SetNativeSize();

        selectCharacter.SetActive(false);
        informaition?.SetActive(true);

    }

    public void OnClickJoin()
    {
        if(2<inputField.text.Length && inputField.text.Length < 9)
        {
            GameManager.Instance.SetCharacter(characterType, inputField.text);

            Destroy(gameObject);// UI에 있는 오브젝트 삭제

        }
               
    }
}
