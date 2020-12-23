using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangeSize : MonoBehaviour
{
    //拡大
    public void Increase()
    {
        this.transform.localScale += new Vector3(1,1,0);
    }

    //縮小
    public void Decrease()
    {
        this.transform.localScale -= new Vector3(1, 1, 0);
    }
}
