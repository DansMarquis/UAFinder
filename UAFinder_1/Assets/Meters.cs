using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Meters : MonoBehaviour
{
    public TMP_Text _DestinationDistance;
  
    public void DisplayTargetInformation(float targetDistance)
    {
        _DestinationDistance.text = targetDistance.ToString("0.00");
    }

    public void UpdateDistance(float targetDistance)
    {
        _DestinationDistance.text = targetDistance.ToString("0.00");
    }


    public void ResetTargetInformation()
    {
        _DestinationDistance.text = "0.00";
    }

}
