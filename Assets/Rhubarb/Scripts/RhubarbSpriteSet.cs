using UnityEngine;
#pragma warning disable 0649

namespace FriendlyMonster.RhubarbTimeline
{
    [CreateAssetMenu(menuName = "Rhubarb/Sprite Set")]
    public class RhubarbSpriteSet : ScriptableObject
    {
        [SerializeField] private Texture A;
        [SerializeField] private Texture B;
        [SerializeField] private Texture C;
        [SerializeField] private Texture D;
        [SerializeField] private Texture E;
        [SerializeField] private Texture F;
        [SerializeField] private Texture G;
        [SerializeField] private Texture H;
        [SerializeField] private Texture X;

        public Texture GetSprite(MouthShape mouthShape)
        {
            switch (mouthShape)
            {
                case MouthShape.A:
                    return A;
                case MouthShape.B:
                    return B;
                case MouthShape.C:
                    return C;
                case MouthShape.D:
                    return D;
                case MouthShape.E:
                    return E;
                case MouthShape.F:
                    return F;
                case MouthShape.G:
                    return G;
                case MouthShape.H:
                    return H;
                case MouthShape.X:
                    return X;
            }

            return null;
        }
    }
}