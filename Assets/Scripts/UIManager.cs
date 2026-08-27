using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;

    [SerializeField]
    private GameObject restartBotton;

    [SerializeField]
    private Player player;

    public static UIManager Instance;

    void Awake()
    {
        Instance = this;

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }
    public void RestartGame() 
    {
        //player.transform.position = new Vector3(0f, 87f, -85f);
        //player.HP = 100;
        //ShowNotiText("RESTART");
        //ShowHideRestartButton(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ShowHideRestartButton(bool flag)
    {
        restartBotton.SetActive(flag);
    }
}