using UnityEngine;

public class PlayerMove
{
    private readonly GameObject player;

    public PlayerMove(GameObject _player)
    {
        player = _player;
    }

    public void Move()
    {
        //マウス位置座標を取得する
        var mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        Vector2 movePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        
        player.transform.position = movePosition;
    }
}
