using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script.SceneManagement
{
    public class Portal : MonoBehaviour
    {
        [SerializeField] private int sceneToLoad = -1;

        private static bool IsPlayerCollider(Component player)
        {
            return player.CompareTag("Player");
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (IsPlayerCollider(other))
            {
                SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Single);
            }
        }
    }
}
