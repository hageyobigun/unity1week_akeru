using UnityEngine;
using TMPro;

public class StartView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI startText = null;

    public void SetStartText(string text)
    {
        startText.text = text;
    }

    public void OffStartText()
    {
        startText.enabled = false;
    }
}