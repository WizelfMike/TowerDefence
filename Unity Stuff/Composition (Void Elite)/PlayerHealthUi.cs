using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealthUi : MonoBehaviour
{
    [SerializeField] private Text _text;


    public void UpdateUI(float nrOfLives)
    {
        _text.text = "Player Lives : " + nrOfLives;
    }
}
