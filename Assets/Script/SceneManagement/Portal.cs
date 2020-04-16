using System.Collections;
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
                StartCoroutine(Transition());
            }
        }

        private IEnumerator Transition()
        {
            DontDestroyOnLoad(gameObject);
            yield return SceneManager.LoadSceneAsync(sceneToLoad);
            print("Scene " + sceneToLoad + " just loaded");
            Destroy(gameObject);
        }
    }
}
