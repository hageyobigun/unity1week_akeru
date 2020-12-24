using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class BlockPresenter : MonoBehaviour
{
    [SerializeField] private Button plusButton = null;
    [SerializeField] private Button minusButton = null;
    [SerializeField] private Dropdown blockList = null;

    private BlockModel blockModel;
    private BlockView blockView;

    // Start is called before the first frame update
    void Start()
    {
        blockModel = new BlockModel();
        blockView = GetComponent<BlockView>();

        //+ボタン（ブロックのサイズを大きくする）
        plusButton.OnClickAsObservable()
            .Subscribe(_ => blockModel.IncreaseSize());

       //-ボタン（ブロックのサイズを小さくする）
        minusButton.OnClickAsObservable()
            .Subscribe(_ => blockModel.DecreaseSize());

        //サイズ反映
        blockModel.size
            .Subscribe(size => blockView.UpdateSize(size));

        //形が変わった時
        blockList.OnValueChangedAsObservable()
            .Subscribe(_ => blockModel.ChangeBlockSprite(blockList.captionImage.sprite));

        //形反映
        blockModel.blockSprite
            .Subscribe(sprite => blockView.UpdateSprite(sprite));


    }
}
