using UnityEngine;

namespace FriendlyMonster.RhubarbTimeline
{
    //[RequireComponent(typeof(Material))]
    
    public class RhubarbSprite : MonoBehaviour
    {
        [SerializeField] Material mat;
        private Material _spriteRenderer;
        [SerializeField] private RhubarbSpriteSet _rhubarbSpriteSet;

        public RhubarbSpriteSet RhubarbSpriteSet
        {
            get { return _rhubarbSpriteSet; }
            set { _rhubarbSpriteSet = value; }
        }

        /*private void Awake()
        {
            mat = GetComponent<Material>();
        }*/

        public MouthShape MouthShape
        {
            set
            {
                if (mat == null)
                {
                    mat = GetComponent<Material>();
                }

                mat.mainTexture = _rhubarbSpriteSet.GetSprite(value);
            }
        }
    }
}