using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    [SerializeField] private int scene;

    public void NewScene (int num)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(num);
    }

    void Awake ()
    {
        Time.timeScale = 0;
    }
}
