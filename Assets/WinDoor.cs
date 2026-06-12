using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Cinemachine;


public class WinDoor : MonoBehaviour
{

    public GameObject winScreen;
    public CinemachineCamera virtualCamera;
    
    //This method when the teacher reaches the door makes it so the win screen is displayed
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //looks for collision with teacher
        if (collision.CompareTag("Enemy"))
        {   
            //has a check to see if its null and then activates the win screen
            if(virtualCamera != null)
            {
                virtualCamera.Follow = this.transform;
            }
            
            
            if(winScreen != null)
           {
                winScreen.SetActive(true);
            }
           Time.timeScale = 0f; 
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
