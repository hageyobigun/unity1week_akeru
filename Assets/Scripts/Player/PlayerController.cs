using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerMove playerMove;
    private PlayerBlock playerBlock;
    private SpriteRenderer playerSprite;
    [SerializeField] private Image selectBlock = null;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = new PlayerInput();
        playerMove = new PlayerMove(this.gameObject);
        playerBlock = GetComponent<PlayerBlock>();
        playerSprite = GetComponent<SpriteRenderer>();

        //移動
        this.UpdateAsObservable()
            .Subscribe(_ => playerMove.Move());

        //穴をあける(ブロックを置く)
        this.UpdateAsObservable()
            .Where(_ => playerInput.IsMouseButton())
            .Subscribe(_ => playerBlock.OpenHole(playerSprite.sprite));

        //sprite切り替え
        this.UpdateAsObservable()
            .Subscribe(_ => playerSprite.sprite = selectBlock.sprite);

    }
}
