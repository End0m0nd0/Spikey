using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PuseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public TextMeshProUGUI timer;
    private float fixedDeltaTime;
    float x_copy;
    public GameObject resumeTimer;
    public float currentTime;

    void Awake()
    {
        // Make a copy of the fixedDeltaTime, it defaults to 0.02f, but it can be changed in the editor
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    private void Start()
    {
        currentTime = 3f;
    }

    void Update()
    {
        if (currentTime > 0) timer.text = "1";
        if (currentTime > 1) timer.text = "2";
        if (currentTime > 2) timer.text = "3";
        
        
        
        
        
        if (resumeTimer.activeSelf == true)
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            currentTime -= Time.deltaTime;
            Bird_Logic.Body.velocity = new Vector3(0, 0, 0);
        }
        if(currentTime<=0f)
        {
            currentTime = 3f;
            resumeTimer.SetActive(false);
            pauseMenuUI.SetActive(false);
            Resume();
            Bird_Logic.Body.velocity = new Vector3(0, 0, 0);
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeTimer();
                Bird_Logic.Body.AddForce(new Vector3(0f, Bird_Logic.jumpForce));
            }
            else
            {
                Pause();
            }
        }
    }

    public void ResumeTimer()
    {
        resumeTimer.SetActive(true);
    }
    
    public void Resume()
    {
        Bird_Logic.x = x_copy;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
        Bird_Logic.Body.AddForce(new Vector3(0f, -Bird_Logic.jumpForce));
    }

    void Pause()
    {
        x_copy = Bird_Logic.x;
        Bird_Logic.x = 0;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
    }

    public void LoadMenu()
    {
        Resume();
        SceneManager.LoadScene("Game_Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
