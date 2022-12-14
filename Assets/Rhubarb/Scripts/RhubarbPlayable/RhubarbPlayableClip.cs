using System;
using UnityEngine.Playables;
using FriendlyMonster.RhubarbTimeline;
using System.Collections.Generic;

namespace UnityEngine.Timeline
{
    /*[Serializable]
    public class RhubarbPlayableClip : PlayableAsset, ITimelineClipAsset
    {
        public override double duration
        {
            get { return 0.5f; }
        }

        public RhubarbPlayableBehaviour template = new RhubarbPlayableBehaviour();

        public ClipCaps clipCaps
        {
            get { return ClipCaps.Blending; }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<RhubarbPlayableBehaviour>.Create(graph, template);
            return playable;
        }
    }*/


    public class RhubarbPlayableClip : PlayableAsset
    {
        public MouthShape _mouthShape;


        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<RhubarbPlayableBehaviour>.Create(graph);
            RhubarbPlayableBehaviour rhubarbPlayableBehaviour = playable.GetBehaviour();
            rhubarbPlayableBehaviour.mouthShape = _mouthShape;

            return playable;
        }
    }
}

