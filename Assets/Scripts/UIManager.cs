using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    private TextMeshProUGUI vehicle1GemText, vehicle2GemText;
    // Start is called before the first frame update
    void Start()
    {
        vehicle1GemText = GetComponent<TextMeshProUGUI>();
        vehicle2GemText = GetComponent<TextMeshProUGUI>();
        
    }

    public void UpdateGemText(PlayerController playerController)
    {
        vehicle1GemText.text = playerController.numberOfGems.ToString();
        vehicle2GemText.text = playerController.numberOfGems.ToString();
    }
}
