using UnityEngine;
using TMPro;

public class EndView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI endText = null;

    public void SetEndText(string text)
    {
        endText.gameObject.SetActive(true);
        endText.text = text;
    }

}
