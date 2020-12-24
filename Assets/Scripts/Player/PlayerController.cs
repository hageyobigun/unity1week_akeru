using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

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
            .Where(_ => playerInput.IsMouseButton())
            .Subscribe(_ => playerBlock.OpenHole());
    }

}
