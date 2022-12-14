using System;
using FriendlyMonster.RhubarbTimeline;
using UnityEngine;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [Serializable]
    public class RhubarbPlayableBehaviour : PlayableBehaviour
    {
        public MouthShape mouthShape;

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            Debug.Log("ProcessFrame, " + mouthShape);

            RhubarbSprite rhubarbSprite = playerData as RhubarbSprite;
            rhubarbSprite.MouthShape = mouthShape;
        }
    }
}
