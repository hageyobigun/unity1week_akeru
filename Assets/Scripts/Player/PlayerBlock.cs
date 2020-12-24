using UnityEngine;

public class PlayerBlock : MonoBehaviour
{
    [SerializeField]private GameObject block = null;
    [SerializeField]private Transform  blockParent = null;

    //穴をあける(ブロックを置く)
    public void OpenHole()
    {
        var blockClone = Instantiate(block, transform.position, Quaternion.identity).transform;
        blockClone.SetParent(blockParent, true);
    }

}
