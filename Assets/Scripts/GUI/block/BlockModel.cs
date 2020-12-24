using UniRx;

public class BlockModel
{
    // Model
    public ReactiveProperty<float> size;
    private float changeSize;

    //初期化
    public BlockModel(float startSizeValue)
    {
        size = new ReactiveProperty<float>();
        size.Value = startSizeValue;
        changeSize = startSizeValue / 5;
    }

    //拡大
    public void IncreaseSize()
    {
        size.Value += changeSize;
    }

    //縮小
    public void DecreaseSize()
    {
        if (size.Value > 0)
        {
            size.Value -= changeSize;
        }
    }
}
