using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Jobs;
using Unity.Entities;
using System;

namespace ECS
{
    public class RenderSystem : JobComponentSystem
    {
        struct RenderJob : IJobProcessComponentData<RendererData>
        {
            // Job shared data
            public float TopBound;


            public void Execute(ref RendererData c0)
            {

            }
        }

        protected override JobHandle OnUpdate(JobHandle inputDeps)
        {
            RenderJob renderJob = new RenderJob
            {
                TopBound = 1
            };

            //JobHandle renderHandle = renderJob.Schedule(64, 8, inputDeps);
            JobHandle renderHandle = new JobHandle();
            return renderHandle;
        }
    }
}

