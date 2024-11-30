using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Kiwi : MonoBehaviour
{

[SerializeField]
TextMeshProUGUI CounterText;

int counter;

public void UpdateCounter()
{
    counter++;
    CounterText.text = counter.ToString();
}

}