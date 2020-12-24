using UniRx;
using UnityEngine;

public class BlockModel
{
    // Model
    public ReactiveProperty<float> size;
    public ReactiveProperty<Sprite> blockSprite;

    //初期化
    public BlockModel()
    {
        size = new ReactiveProperty<float>();
        blockSprite = new ReactiveProperty<Sprite>();
        size.Value = 1;
    }

    //形変更
    public void ChangeBlockSprite(Sprite sprite)
    {
        blockSprite.Value = sprite;
    }

    //拡大
    public void IncreaseSize()
    {
        size.Value += 1;
    }

    //縮小
    public void DecreaseSize()
    {
        if (size.Value > 0)
        {
            size.Value -= 1;
        }
    }
}
