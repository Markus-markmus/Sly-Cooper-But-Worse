using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BottleCollector : MonoBehaviour
{
    private int BottleCount = 0;

    public TextMeshProUGUI BottleCountText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == ("Bottle"))
        {
            BottleCount++;
            BottleCountText.text = ": " + BottleCount.ToString();
            Debug.Log("Bottle Count: " + BottleCount);
            Destroy(other.gameObject);
        }
    }
}
