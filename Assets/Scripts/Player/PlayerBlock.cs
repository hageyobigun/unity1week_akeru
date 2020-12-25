using UnityEngine;

public class PlayerBlock : MonoBehaviour
{
    [SerializeField]private Transform  blockParent = null;

    //穴をあける(ブロックを置く)
    public void OpenHole(GameObject block)
    {
        var blockClone = Instantiate(block, transform.position, Quaternion.identity).transform;
        blockClone.SetParent(blockParent, true);
    }

}
