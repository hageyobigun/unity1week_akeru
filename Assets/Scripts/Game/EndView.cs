using UnityEngine;
using TMPro;

public class EndView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI endText = null;
    [SerializeField] private GameObject endImage = null;

    public void SetEndText(string text)
    {
        endText.gameObject.SetActive(true);
        endImage.SetActive(true);
        endText.text = text;
    }

    public void OffEndText()
    {
        endText.gameObject.SetActive(false);
        endImage.SetActive(false);
    }

}
