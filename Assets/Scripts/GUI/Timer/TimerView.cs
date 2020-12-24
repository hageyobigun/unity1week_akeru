using UnityEngine;
using TMPro;

public class TimerView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeValueText = null;

    public void SetTimer(int timeValue)
    {
        timeValueText.text = timeValue.ToString();
    }
}
