using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    public string level1;
    public string level2;
    public string level3;

    public void LoadLevel1()
    {
        SceneManager.LoadScene(Level1);
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene(Level2);
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene(Level3);
    }
}

