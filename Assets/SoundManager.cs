using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager soundManager;
    //Sources
    public AudioSource jumpAudioSource;
    public AudioSource backgroundMusicSource;

    public AudioClip jumpSound;

    private void Awake()
    {
        if (soundManager == null)
        {
            soundManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        { 
            Destroy(gameObject);
        }
            
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayJumpSound()
    {
        jumpAudioSource.PlayOneShot(jumpSound);
    }
}
