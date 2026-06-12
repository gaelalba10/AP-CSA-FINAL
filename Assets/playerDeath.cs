using UnityEngine;
using UnityEngine.SceneManagement;


public class playerDeath : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("PHYSICS TOUCH DETECTED! Object name: " + collision.gameObject.name + " | Tag: " + collision.gameObject.tag);

        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
