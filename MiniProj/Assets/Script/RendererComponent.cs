using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;


namespace ECS
{
    [Serializable]
    public struct RendererData : IComponentData
    {
      public UnityEngine.Renderer renderer;
    }


    public class RendererComponent : ComponentDataProxy<RendererData> { }

}