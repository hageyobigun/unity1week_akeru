using UnityEngine;

public class PlayerBlock : MonoBehaviour
{
    [SerializeField]private GameObject block = null;
    [SerializeField]private Transform  blockParent = null;
    private SpriteRenderer spriteRenderer;

    public void Start()
    {
        spriteRenderer = block.GetComponent<SpriteRenderer>();
    }


    //穴をあける(ブロックを置く)
    public void OpenHole(Sprite playerSprite)
    {
        spriteRenderer.sprite = playerSprite;//プレイヤーの形に合わせる
        var blockClone = Instantiate(block, transform.position, Quaternion.identity).transform;
        blockClone.SetParent(blockParent, true);
    }

}
