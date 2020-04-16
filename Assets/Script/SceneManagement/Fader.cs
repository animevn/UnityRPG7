using System;
using System.Collections;
using UnityEngine;

namespace Script.SceneManagement
{
    public class Fader : MonoBehaviour
    {
        [SerializeField] private float timeFade;

        private CanvasGroup canvas;
        
        private void Start()
        {
            canvas = GetComponent<CanvasGroup>();
            StartCoroutine(FadeOut(timeFade));
        }

        private IEnumerator FadeOut(float time)
        {
            while (Math.Abs(canvas.alpha - 1) > 0)
            {
                canvas.alpha += Time.deltaTime / time;
                yield return null;
            }
        }
    }   
}
