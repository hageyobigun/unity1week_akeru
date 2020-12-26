using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class BlockPresenter : MonoBehaviour
{
    [SerializeField] private float startSizeValue = 0.1f;
    [SerializeField] private Button plusButton = null;
    [SerializeField] private Button minusButton = null;
    [SerializeField] private Dropdown blockList = null;

    [SerializeField]private BlockView blockView = null;
    private BlockModel blockModel;


    // Start is called before the first frame update
    private void Awake()
    {
        blockModel = new BlockModel(startSizeValue);

        //+ボタン（ブロックのサイズを大きくする）
        plusButton.OnClickAsObservable()
            .Subscribe(_ => blockModel.IncreaseSize());

       //-ボタン（ブロックのサイズを小さくする）
        minusButton.OnClickAsObservable()
            .Subscribe(_ => blockModel.DecreaseSize());

        //サイズ反映
        blockModel.size
            .Subscribe(size => blockView.UpdateSize(size));

        //形が変わった時  形反映
        blockList.OnValueChangedAsObservable()
            .Subscribe(_ => blockView.UpdateSprite(blockList.captionImage.sprite));

    }
}
