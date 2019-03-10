using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Collections;



namespace ECS
{
    public class GameManager : MonoBehaviour
    {
        EntityManager m_Manager;
        public GameObject SrcPrefab;



        // Start is called before the first frame update
        void Start()
        {

            m_Manager = World.Active.GetOrCreateManager<EntityManager>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void AddShips(int amount)
        {
            NativeArray<Entity> entities = new NativeArray<Entity>(amount, Allocator.Temp);

            m_Manager.Instantiate(SrcPrefab, entities);

            for (int i = 0; i < amount; i++)
            {
                m_Manager.SetComponentData(entities[i], new RendererData { });

            }
            entities.Dispose(); // release references


        }
    }

}