using UnityEngine;

public class BlockView : MonoBehaviour
{
    [SerializeField] private GameObject block = null;
    private SpriteRenderer blockSprite;

    public void Start()
    {
        blockSprite = block.GetComponent<SpriteRenderer>();
    }

    //形変更
    public void UpdateSprite(Sprite sprite)
    {
        blockSprite.sprite = sprite;
    }

    //大きさ変更
    public void UpdateSize(float size)
    {
        block.transform.localScale = new Vector3(size, size, 0);
    }
}
