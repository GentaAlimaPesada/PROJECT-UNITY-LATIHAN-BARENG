using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public AudioSource enemySound;
    Collider2D soundTrigger;


    private void Awake()
    {
        enemySound = GetComponent<AudioSource>();   
        soundTrigger = GetComponent<Collider2D>();
    }
    // Mendapatkan komponen AudioSource dari objek ini
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enemySound.Play();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //Player keluar collider 
    }

}
