using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthUi : MonoBehaviour
{
    public Text livesText;

    void Update()
    {
        livesText.text = "Lives: " + PlayerStats.Lives.ToString();
    }
}
