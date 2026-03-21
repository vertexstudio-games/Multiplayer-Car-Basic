using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private GameObject completedObject;
 
    private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.CompareTag("Player")) 
        {
            completedObject.SetActive(true);
        }
    }

    public void NextLevelUp(int nextLevel)
    {
        SceneManager.LoadScene(nextLevel);
    }
}
