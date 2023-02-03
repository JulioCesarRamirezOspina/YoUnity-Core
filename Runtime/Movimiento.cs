using DG.Tweening;
using UnityEngine;

namespace Yosoft.Core
{
    public class Movimiento : MonoBehaviour
    {
        [SerializeField] public Vector3 endValue;
        [SerializeField] public float duration;
        [SerializeField] public float delay;
        [SerializeField] public int loop;
        [SerializeField] public LoopType loopType;
        [SerializeField] public Ease easy;

        [SerializeField] public bool eslocal = true;
        // Start is called before the first frame update
    
        void Start()
        {
            if (eslocal)
            {
                transform.DOLocalMove(endValue, duration).SetEase(easy).SetDelay(delay).SetLoops(loop, loopType);
            
            }
            else
            {
                transform.DOMove(endValue, duration).SetEase(easy).SetDelay(delay).SetLoops(loop, loopType);
            }

        }
    

        private void OnDisable()
        {
            transform.DOKill();
        }
    }
}
