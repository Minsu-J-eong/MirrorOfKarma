using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("버튼")]
    public GameObject newGameButton;
    public GameObject continueButton;
    public GameObject optionButton;
    public GameObject quitButton;

    void Start()
    {
        bool hasSaveData = PlayerPrefs.HasKey("SaveExists");
        continueButton.SetActive(hasSaveData);
    }

    // 새로하기
    public void OnNewGameClick()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("CharacterSelect");
    }

    // 이어하기 → 로비로
    public void OnContinueClick()
    {
        if (PlayerPrefs.HasKey("SaveExists"))
        {
            SceneManager.LoadScene("Lobby");
        }
    }

    // 옵션
    public void OnOptionClick()
    {
        Debug.Log("옵션 클릭");
    }

    // 종료
    public void OnQuitClick()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}