using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Collections;
using Unity.Rendering;
using Unity.Mathematics;

// this would probably in practical nomenclature a "spawner," like an interface between unityengine world and ecs world
// gameobjects != entities
public class ECSTest : MonoBehaviour {
    [SerializeField]
    private Mesh mesh;
    [SerializeField]
    private Material material;

    void Start() {
        // gets the "active" world - if you see a tutorial grabbing World.Active it's this
        EntityManager em = World.DefaultGameObjectInjectionWorld.EntityManager;

        EntityArchetype arch = em.CreateArchetype(
            typeof(FlierComponent),
            typeof(Translation),
            typeof(RenderMesh),
            typeof(LocalToWorld),   // probably something to store world coordinates transformed from local
            typeof(RenderBounds)    // won't render without this - i'm guessing the renderer might use it for culling? not sure
        );
        // temporarily allocates a bunch of entities using a blazing fast array
        NativeArray<Entity> entities = new NativeArray<Entity>(10000, Allocator.Temp);
        // fills the entities array with new entities based on the given archetype
        em.CreateEntity(arch, entities);

        foreach (Entity e in entities) {
            em.SetComponentData(e, new FlierComponent { 
                speed = UnityEngine.Random.Range(-5, 5) 
            });

            em.SetComponentData(e, new Translation {
                Value = new float3(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-4, 4))
            });

            em.SetSharedComponentData(e, new RenderMesh {
                mesh = mesh,
                material = material
            });
        }

        // disposes of the array - i would have assumed that telling the native array to be
        // temporarily allocated would have done something about this automagically, but ¯\_(ツ)_/¯
        entities.Dispose();
    }
}
