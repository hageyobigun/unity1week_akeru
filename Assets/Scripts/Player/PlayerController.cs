﻿using System.Collections;
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
    private PlayerRotation playerRotation;

    private bool isPlay;
    [SerializeField] GameObject block = null;

    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new PlayerInput();
        playerMove = new PlayerMove(this.gameObject);
        playerRotation = new PlayerRotation(block);
        playerBlock = GetComponent<PlayerBlock>();

        //移動
        this.UpdateAsObservable()
            .Where(_ => isPlay)
            .Subscribe(_ => playerMove.Move());

        //穴をあける(ブロックを置く)
        this.UpdateAsObservable()
            .Where(_ => isPlay)
            .Where(_ => !EventSystem.current.IsPointerOverGameObject()) //UIと重っているときは向こう
            .Where(_ => playerInput.IsOpenHole())
            .Subscribe(_ =>
            {
                playerBlock.OpenHole(block);
                SoundManager.Instance.PlaySe("Break");
            });

        this.UpdateAsObservable()
            .Where(_ => isPlay)
            .Where(_ => playerInput.IsRotation())
            .Subscribe(_ => playerRotation.Rotation());
    }


    public void StopPlayer()
    {
        block.SetActive(false);
        isPlay = false;
    }

    public void StartPlayer()
    {
        block.SetActive(true);
        isPlay = true;
    }

}
