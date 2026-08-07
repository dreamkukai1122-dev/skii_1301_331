using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player == null)
            return;
        UIManager.Instance.ShowNotiText($"YOU WINNNNN!\nPoin: {player.Point}");
    }
}
