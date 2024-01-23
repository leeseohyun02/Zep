using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CharacterType
{
    bunny,
    bee
}

[System.Serializable]
public class Charater
{
    public CharacterType CharacterType;
    public Sprite CharaterSprite;
    public RuntimeAnimatorController AnimatorController;


}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<Charater> CharaterList = new List<Charater>();

    public Animator PlayerAnimator;
    public Text PlayerName;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
        
    }

    public void SetCharacter(CharacterType characterType, string name)
    {
        var character = GameManager.Instance.CharaterList.Find(item => item.CharacterType == characterType);

        PlayerAnimator.runtimeAnimatorController = character.AnimatorController;
        PlayerName.text = name;
    }
}
