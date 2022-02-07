using System.Collections;
using UnityEngine;

public class ScaleAnimation : MonoBehaviour
{
   [SerializeField] private float animationDuration = 1f;
   [SerializeField] private AnimationCurve scaleAnimationCurve = AnimationCurve.Linear(0,0,1,1);
   
   public void PlayAnimation(float value)
   {
      StartCoroutine(AnimationCoroutine(value));
   }

   private IEnumerator AnimationCoroutine(float value)
   {
      var progress = 0f;

      while (progress <1f)
      {
         progress += Time.deltaTime / animationDuration;

         var scaleValue = scaleAnimationCurve.Evaluate(progress);

         scaleValue *= value;
         
         transform.localScale = new Vector3(
            1 + scaleValue, 
            1, 
            1 + scaleValue);
         yield return null;
      }

      transform.localScale = Vector3.one;

   }
}
