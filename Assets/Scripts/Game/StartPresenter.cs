using System.Collections;
using UnityEngine;

public class StartPresenter : MonoBehaviour
{
    [SerializeField] private StartView startView = null;

    public IEnumerator StartGame()
    {
        startView.SetStartText("READY?");
        yield return new WaitForSeconds(1);
        startView.SetStartText("  GO!!");
        yield return new WaitForSeconds(1);
        startView.OffStartText();
    }

}
