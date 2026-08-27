using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class KillZone : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player == null)
            return;
        player.HP -= 100;
        if (player.HP <= 0)
        {
            player.HP = 0;
            UIManager.Instance.ShowNotiText($"GAME OVER\nPoin: {player.Point}");
            Time.timeScale = 0f;
            UIManager.Instance.ShowHideRestartButton(true);
        }
    }
}
