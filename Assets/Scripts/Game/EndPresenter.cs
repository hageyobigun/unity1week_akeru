using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPresenter : MonoBehaviour
{
    [SerializeField] private EndView endView = null;

    public void EndGame()
    {
        endView.SetEndText("FINISH!");
    }

}
