using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerMove playerMove;
    private PlayerBlock playerBlock;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = new PlayerInput();
        playerMove = new PlayerMove(this.gameObject);
        playerBlock = GetComponent<PlayerBlock>();

        //移動
        this.UpdateAsObservable()
            .Subscribe(_ => playerMove.Move());

        //穴をあける(ブロックを置く)
        this.UpdateAsObservable()
            .Where(_ => !EventSystem.current.IsPointerOverGameObject()) //UIと傘っているときは向こう
            .Where(_ => playerInput.IsOpenHole())
            .Subscribe(_ => playerBlock.OpenHole());
    }

}
