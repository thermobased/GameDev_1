using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public int count = 0;
    private TextMeshProUGUI textComponent;
    
    void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
        UpdateCounterText();
    }
    
    public void IncreaseCount()
    {
        count++;
        UpdateCounterText();
    }
    private void UpdateCounterText()
    {
        if (textComponent != null)
        {
            textComponent.text = count.ToString();
        }
    }
}
