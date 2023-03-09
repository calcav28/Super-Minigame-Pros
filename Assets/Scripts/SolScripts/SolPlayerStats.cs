using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class SolPlayerStats : MonoBehaviour
{
    public bool wasdMovement;
    public int testInt;
    public int solEasyHighScore;
    public int solMedHighScore;
    public int solHardHighScore;
    public int solGamesPlayed;

    public bool solHasQAbility;
    public bool solHasEAbility;
    public bool solHasRAbility;

    void Awake()
    {
         setMovementType();
    }


    public void setMovementType()
    {
        if(GameObject.Find("WASDMovement").activeSelf)
        {
            wasdMovement = true;
        }
        if (GameObject.Find("RightClickMovement").activeSelf)
        {
            wasdMovement = false;
        }
    }

    public void solBuyItem(string itemToActivate)
    {
        switch (itemToActivate)
        {
            case "qAbilityActivate":
                solHasQAbility = true;
                break;
            case "eAbilityActivate":
                solHasEAbility = true;
                break;
        }
    }
}
