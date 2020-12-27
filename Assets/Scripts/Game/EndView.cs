using UnityEngine;
using TMPro;

public class EndView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI endText = null;
    [SerializeField] private GameObject endImage = null;

    public void SetEndText(string text)
    {
        endText.gameObject.SetActive(true);
        endText.text = text;
    }

    public void SetEndImage()
    {
        endImage.SetActive(true);
    }

    public void OffEndText()
    {
        endText.gameObject.SetActive(false);
    }

    public void OFFEndImage()
    {
        endImage.SetActive(false);
    }

}
